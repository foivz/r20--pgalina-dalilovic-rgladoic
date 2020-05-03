using System;
using SkyFlyReservation.Class;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyFlyReservation
{
    public partial class FormRezervacijaKarte : Form
    {
        private Let odabraniLet;
        private Korisnik odabraniPutnik;
        public FormRezervacijaKarte(Let selektiraniLet, Korisnik putnik)
        {
            odabraniLet = selektiraniLet;
            odabraniPutnik = putnik;
            InitializeComponent();
        }

        private void FormRezervacijaKarte_Load(object sender, EventArgs e)
        {
            OsvjeziDetalje();
        }

        private void OsvjeziDetalje()
        {
            oznakaOdabranogLetaLabel.Text = odabraniLet.BrojLeta;
            odabraniPolazisniTextBox.Text = odabraniLet.NazivPolazisnogAerodroma;
            odabraniOdredisniTextBox.Text = odabraniLet.NazivOdredisnogAerodroma;
            avionNaLetuTextBox.Text = odabraniLet.DohvatiAvion().ProizvodacAviona + " " + odabraniLet.DohvatiAvion().TipAviona;
            vrijemePolaskaTextBox.Text = odabraniLet.DatumPolaska.ToString();
            vrijemeDolaskaTextBox.Text = odabraniLet.DatumDolaska.ToString();
            cijenaKarteTextBox.Text = odabraniLet.CijenaKarte.ToString() + " " + odabraniLet.OznakaValute;

            Avion avion = odabraniLet.DohvatiAvion();

            foreach (Sjedalo sjedalo in avion.SjedalaUAvionu)
            {
                foreach (TextBox textBox in sjedalaUAvionuPanel.Controls)
                {
                    if(sjedalo.OznakaSjedala == textBox.Name)
                    {
                        if(sjedalo.StatusSjedala == StanjeSjedala.Slobodno)
                        {
                            textBox.BackColor = Color.Green;
                            textBox.Text = sjedalo.OznakaSjedala.ToString();
                        }
                        else if(sjedalo.StatusSjedala == StanjeSjedala.Zauzeto)
                        {
                            textBox.BackColor = Color.Red;
                            textBox.Text = sjedalo.OznakaSjedala.ToString();
                        }
                    }
                }
            }
        }

        private void rezervirajSjedaloButton_Click(object sender, EventArgs e)
        {
            //Koristi se za testiranje 
            Sjedalo initSjedalo = odabraniLet.DohvatiAvion().AzurirajSjedalo("A2", StanjeSjedala.Zauzeto);

            
            Rezervacija initRezervacija = new Rezervacija(odabraniPutnik, odabraniLet, initSjedalo, StanjeRezervacije.Neplaćena);
            odabraniLet.BrojSlobodnihMjesta--;
            odabraniLet.PutniciNaLetu.Add(odabraniPutnik);
            odabraniPutnik.RezervacijePutnika.Add(initRezervacija);
            

            if ((odabraniLet.DatumPolaska.Date.Day - DateTime.Now.Date.Day) < 3)
            {
                MessageBox.Show("Rok za rezervaciju karata za odabrani let je istekao.");
            }

            /* Zakomentirano zbog metode AzurirajSjedalo() koja ne dohvaća fokusirani TextBox
            
            Sjedalo sjedalo = AzurirajSjedalo();

            if (sjedalo != null)
            {
                Rezervacija rezervacija = new Rezervacija(odabraniPutnik, odabraniLet, sjedalo, StanjeRezervacije.Neplaćena);
                odabraniLet.BrojSlobodnihMjesta--;
                odabraniLet.PutniciNaLetu.Add(odabraniPutnik);
                odabraniPutnik.RezervacijePutnika.Add(rezervacija);
            
                MessageBox.Show($"Uspješno ste rezervirali sjedalo {sjedalo.OznakaSjedala} na letu {odabraniLet.BrojLeta}.");

                ------<VIŠAK>------
                Avion avion = odabraniLet.DohvatiAvion();
                avion.AzurirajSjedalo(sjedalo.OznakaSjedala, StanjeSjedala.Zauzeto);
                -------------------
            }
            else
            {
                MessageBox.Show($"Sjedalo {sjedalo.OznakaSjedala} na letu {odabraniLet.BrojLeta} je zauzeto.");
            }*/

            OsvjeziDetalje();
        }

        private Sjedalo AzurirajSjedalo()
        {
            Sjedalo sjedalo = null;

            foreach (TextBox textBox in sjedalaUAvionuPanel.Controls)
            {
                if (textBox.ContainsFocus) // dodati da dohvaća sjedalo koje je fokusirano
                {
                    Avion avion = odabraniLet.DohvatiAvion();
                    Sjedalo odabranoSjedalo = avion.DohvatiSjedalo(textBox.Text);
                    sjedalo = avion.AzurirajSjedalo(odabranoSjedalo.OznakaSjedala, StanjeSjedala.Zauzeto);

                    //sjedalo = avion.AzurirajSjedalo(textBox.Text.ToString(), StanjeSjedala.Zauzeto);
                }
            }

            return sjedalo;
        }
    }
}
