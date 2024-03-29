﻿using System;
using SkyFlyReservation.Class;
using System.Net;
using System.Net.Mail;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserHelpControler;

namespace SkyFlyReservation
{
    public partial class FormRezervacijaKarte : Form
    {
        private Let selektiraniLet;
        private TextBox odabranoSjedalo;
        public FormRezervacijaKarte(Let let)
        {
            selektiraniLet = let;
            InitializeComponent();
        }

        private void FormRezervacijaKarte_Load(object sender, EventArgs e)
        {
            OsvjeziDetalje();

            List<Sjedalo> rezerviranaSjedala = RepozitorijSkyFlyReservation.DohvatiRezerviranaSjedala(selektiraniLet);
            OsvjeziSjedalaUAvionu(rezerviranaSjedala);
        }

        private void OsvjeziSjedalaUAvionu(List<Sjedalo> rezerviranaSjedala)
        {
            foreach (TextBox sjedaloTextBox in sjedalaUAvionuPanel.Controls.OfType<TextBox>().OrderBy(c => c.TabIndex))
            {
                if(sjedaloTextBox.TabIndex <= selektiraniLet.AvionNaLetu.BrojMjesta)
                {
                    if (rezerviranaSjedala.Exists(s => s.OznakaSjedala == sjedaloTextBox.Name))
                    {
                        sjedaloTextBox.GotFocus += TextBoxFocused;
                        sjedaloTextBox.BackColor = Color.Red;
                    }
                    else
                    {
                        sjedaloTextBox.GotFocus += TextBoxFocused;
                        sjedaloTextBox.BackColor = Color.Green;
                    }
                }
                else
                {
                    sjedaloTextBox.BackColor = Color.Black;
                    sjedaloTextBox.Enabled = false;
                }
            }
        }

        private void TextBoxFocused(object sender, EventArgs e)
        {
            odabranoSjedalo = (TextBox)sender;
        }

        private void OsvjeziDetalje()
        {
            oznakaOdabranogLetaLabel.Text = selektiraniLet.BrojLeta;
            odabraniPolazisniTextBox.Text = selektiraniLet.PolazisniAerodrom.NazivAerodroma;
            odabraniOdredisniTextBox.Text = selektiraniLet.OdredisniAerodrom.NazivAerodroma;
            avionNaLetuTextBox.Text = selektiraniLet.AvionNaLetu.ProizvodacAviona + " " + selektiraniLet.AvionNaLetu.ModelAviona;
            vrijemePolaskaTextBox.Text = selektiraniLet.DatumPolaska.ToString();
            vrijemeDolaskaTextBox.Text = selektiraniLet.DatumDolaska.ToString();
            cijenaKarteTextBox.Text = selektiraniLet.CijenaKarte.ToString();
        }

        private void rezervirajSjedaloButton_Click(object sender, EventArgs e)
        {
            if ((selektiraniLet.DatumPolaska.Date.Day - DateTime.Now.Date.Day) < 3 && (selektiraniLet.DatumDolaska.Date.Month == DateTime.Now.Date.Month))
            {
                MessageBox.Show($"Rok za rezervaciju karata za let {selektiraniLet.PolazisniAerodrom.NazivAerodroma}->{selektiraniLet.OdredisniAerodrom.NazivAerodroma} je istekao.");
                return;
            }
            if (odabranoSjedalo == null)
            {
                MessageBox.Show("Niste odabrali sjedalo za koje želite rezervirati kartu.");
                return;
            }
            if (odabranoSjedalo.BackColor == Color.Red)
            {
                MessageBox.Show($"Sjedalo {odabranoSjedalo.Name} na letu {selektiraniLet.PolazisniAerodrom.NazivAerodroma}->{selektiraniLet.OdredisniAerodrom.NazivAerodroma} je zauzeto.");
                return;
            }
            else
            {
                Sjedalo sjedalo = RepozitorijSkyFlyReservation.DohvatiSjedalo(odabranoSjedalo.Name);

                Rezervacija rezervacija = new Rezervacija()
                {
                    LetRezervacije = selektiraniLet,
                    KorisnikRezervacije = RepozitorijSkyFlyReservation.prijavljeniKorisnik,
                    RezerviranoSjedalo = sjedalo,
                    DatumVrijemeRezervacije = DateTime.Now
                };

                int numAffectedRowsInsert = RepozitorijSkyFlyReservation.DodajRezervacijuKarte(rezervacija);
                int numAffectedRowsUpdate = RepozitorijSkyFlyReservation.AzurirajBrojSlobodnihMjesta(selektiraniLet);

                if(numAffectedRowsInsert > 0 && numAffectedRowsUpdate > 0)
                {
                    MessageBox.Show($"Uspješno ste rezervirali sjedalo {sjedalo.OznakaSjedala} na letu {selektiraniLet.PolazisniAerodrom.NazivAerodroma}->{selektiraniLet.OdredisniAerodrom.NazivAerodroma}.\n\nNa Vašu e-mail adresu poslani su podaci za plaćanje.");
                    PošaljiObavijest(selektiraniLet, sjedalo);
                    OsvjeziSjedalaUAvionu(RepozitorijSkyFlyReservation.DohvatiRezerviranaSjedala(selektiraniLet));
                }
                else
                {
                    MessageBox.Show("Dogodila se pogreška kod rezervacije sjedala.Rezervacija nije evidentirana.");
                    this.Close();
                    return;
                }
            }
        }

        private void PošaljiObavijest(Let let, Sjedalo sjedalo)
        {
            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

            client.UseDefaultCredentials = false;
            NetworkCredential cred = new NetworkCredential("skyflyreservation@gmail.com", "sj6IWP3o");

            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress("skyflyreservation@gmail.com");

            Msg.To.Add($"{RepozitorijSkyFlyReservation.prijavljeniKorisnik.EmailKorisnika}");

            Msg.Subject = "Potvrda rezervacije karte";

            Msg.Body = $"Poštovani {RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika} {RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika},\n\n" +
                $"Vaša rezervacija za sjedalo {sjedalo.OznakaSjedala} na letu {let.BrojLeta} | {let.PolazisniAerodrom.NazivAerodroma}->{let.OdredisniAerodrom.NazivAerodroma} je zabilježena u sustav.\n" +
                "Molimo Vas da rezervaciju platite najkasnije 3 dana prije polaska.\n" +
                "Uplatu možete izvršiti putem aplikacije ili putem uplatnice.\n\n" +
                "Podaci za plaćanje putem uplatnice ili internet bankarstva:\n" +
                $"Primatelj: {let.AvionNaLetu.Aviokompanija.NazivAviokompanije}\n" +
                $"           {let.AvionNaLetu.Aviokompanija.AdresaAviokompanije}\n" +
                $"      OIB: {let.AvionNaLetu.Aviokompanija.OIBAviokompanije}\n" +
                $"IBAN ili broj računa primatelja: {let.AvionNaLetu.Aviokompanija.IBANAviokompanije}\n" +
                $"Opis plaćanja: Plaćanje rezervacije za sjedalo {sjedalo.OznakaSjedala} na letu {let.BrojLeta} | {let.PolazisniAerodrom.NazivAerodroma}->{let.OdredisniAerodrom.NazivAerodroma}.\n\n" +
                "S poštovanjem,\n" +
                "SkyFlyReservation";

            client.Credentials = cred;

            client.EnableSsl = true;

            client.Send(Msg);
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            if(odabranoSjedalo == null)
            {
                MessageBox.Show("Niste odabrali sjedalo za koje želite kupiti kartu.");
                return;
            }

            if (odabranoSjedalo.BackColor == Color.Red)
            {
                MessageBox.Show($"Sjedalo {odabranoSjedalo.Name} na letu {selektiraniLet.PolazisniAerodrom.NazivAerodroma}->{selektiraniLet.OdredisniAerodrom.NazivAerodroma} je zauzeto.");
                return;
            }
            else
            {
                Sjedalo sjedalo = RepozitorijSkyFlyReservation.DohvatiSjedalo(odabranoSjedalo.Name);

                FormPlatiKartu form = new FormPlatiKartu(selektiraniLet, sjedalo);
                form.ShowDialog();

                OsvjeziSjedalaUAvionu(RepozitorijSkyFlyReservation.DohvatiRezerviranaSjedala(selektiraniLet));
            }
        }

        private void FormRezervacijaKarte_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();

                controler.OtvoriUserHelp(this, "RezervacijaKupnjaKarte.htm");
            }
        }
    }
}
