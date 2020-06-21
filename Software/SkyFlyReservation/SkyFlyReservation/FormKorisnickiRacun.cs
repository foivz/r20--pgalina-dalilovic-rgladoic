using SkyFlyReservation.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserHelpControler;
using Validation;

namespace SkyFlyReservation
{
    public partial class FormKorisnickiRacun : Form
    {
        private bool seePassword1 = false;
        public FormKorisnickiRacun()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormKorisnickiRacun_Load(object sender, EventArgs e)
        {
            PopuniPolja();
        }

        private void PopuniPolja()
        {
            txtIme.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika;
            txtPrezime.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika;
            txtEmail.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.EmailKorisnika;
            txtAdresa.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.AdresaKorisnika;
            txtKontakt.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.KontaktTelefonKorisnika;
            txtOib.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.OIBKorisnika;
            txtKorIme.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnickoImeKorisnika;
            txtLozinka.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.LozinkaKorisnika;
            txtLozinka.ReadOnly = true;
            txtLozinka.PasswordChar = '•';
        }

        private void btnSeePassword1_Click_1(object sender, EventArgs e)
        {
            if (seePassword1)
            {
                txtLozinka.PasswordChar = '•';
                seePassword1 = false;
            }
            else
            {
                txtLozinka.PasswordChar = '\0';
                seePassword1 = true;
            }
        }

        private void btnPromijeniLozinku_Click(object sender, EventArgs e)
        {
            FormLozinka form = new FormLozinka();
            form.ShowDialog();
            PopuniPolja();
        }

        private void btnSpremiPromjene_Click(object sender, EventArgs e)
        {
            string[] validiraj = new string[7];
            validiraj[0] = txtIme.Text;
            validiraj[1] = txtPrezime.Text;
            validiraj[2] = txtEmail.Text;
            validiraj[3] = txtAdresa.Text;
            validiraj[4] = txtKontakt.Text;
            validiraj[5] = txtOib.Text;
            validiraj[6] = txtKorIme.Text;

            ValidacijaPromjena validacija = new Validation.ValidacijaPromjena();

            string poruka = validacija.Validiraj(validiraj);
            Korisnik dohvaceniKorisnik = RepozitorijSkyFlyReservation.DohvatiKorisnika(txtKorIme.Text);

            if (poruka != "")
            {
                MessageBox.Show(poruka);
            }
            else if (dohvaceniKorisnik != null && dohvaceniKorisnik.KorisnickoImeKorisnika != RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnickoImeKorisnika)
            {
                MessageBox.Show("Korisničko ime je zauzeto!");
            }
            else if (dohvaceniKorisnik.EmailKorisnika == txtEmail.Text && dohvaceniKorisnik.KorisnickoImeKorisnika != RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnickoImeKorisnika)
            {
                MessageBox.Show("Taj email već koristi drugi račun!");
            }
            else
            {
                Korisnik korisnik = new Korisnik()
                {
                    ImeKorisnika = txtIme.Text,
                    PrezimeKorisnika = txtPrezime.Text,
                    AdresaKorisnika = txtAdresa.Text,
                    KontaktTelefonKorisnika = txtKontakt.Text,
                    EmailKorisnika = txtEmail.Text,
                    OIBKorisnika = txtOib.Text,
                    KorisnickoImeKorisnika = txtKorIme.Text,
                    LozinkaKorisnika = txtLozinka.Text
                };
                int numAffectedRows = RepozitorijSkyFlyReservation.AzurirajKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId, korisnik);

                if(numAffectedRows != 0)
                {
                    MessageBox.Show("Uspješna izmjena korisničkog računa.");
                    int ID = RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId;
                    UlogaKorisnika uloga = RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika;
                    Aviokompanija aviokompanija = RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija;

                    RepozitorijSkyFlyReservation.prijavljeniKorisnik = korisnik;
                    RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId = ID;
                    RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika = uloga;
                    RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija = aviokompanija;

                    PopuniPolja();
                }
                else
                {
                    MessageBox.Show("Neuspješna promjena! Molimo pokušajte ponovno.");
                }
            }
        }

        private void FormKorisnickiRacun_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();

                controler.OtvoriUserHelp(this, "KorisnickiRacun.htm");
            }
        }
    }
}
