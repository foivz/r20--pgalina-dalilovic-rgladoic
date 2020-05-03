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
    public partial class FormPlatiKartu : Form
    {
        private Let odabraniLet;
        private Sjedalo odabranoSjedalo;
        private Korisnik odabraniPutnik;
        public FormPlatiKartu(Let let, Sjedalo sjedalo, Korisnik putnik)
        {
            odabraniLet = let;
            odabranoSjedalo = sjedalo;
            odabraniPutnik = putnik;

            InitializeComponent();
        }

        private void FormPlatiKartu_Load(object sender, EventArgs e)
        {
            oznakaLetaLabel.Text = odabraniLet.BrojLeta;
            oznakaOdabranogSjedalaLabel.Text = odabranoSjedalo.OznakaSjedala;

        }

        private void platiKartuButton_Click(object sender, EventArgs e)
        {
            string imePlatitelja = imeTextBox.Text;
            string prezimePlatitelja = prezimeTextBox.Text;
            string oibPlatitelja = oibTextBox.Text;
            string brojKarticePlatitelja = brojKarticeTextBox.Text;

            if (imePlatitelja == "" || prezimePlatitelja == "" || oibPlatitelja == "" || brojKarticePlatitelja == "")
            {
                MessageBox.Show("Unijeli ste pogrešne podatke za plaćanje.");
            }
            else
            {
                Rezervacija initRezervacija = new Rezervacija(odabraniPutnik, odabraniLet, odabranoSjedalo, StanjeRezervacije.Neplaćena);
                odabraniLet.BrojSlobodnihMjesta--;
                odabraniLet.PutniciNaLetu.Add(odabraniPutnik);
                odabraniPutnik.RezervacijePutnika.Add(initRezervacija);
                odabraniLet.DohvatiAvion().AzurirajSjedalo(odabranoSjedalo.OznakaSjedala, StanjeSjedala.Zauzeto);

                Kupnja initKupnja = new Kupnja(initRezervacija, brojKarticePlatitelja);

                MessageBox.Show($"Uspješno ste kupili kartu za sjedalo {odabranoSjedalo.OznakaSjedala} na letu {initRezervacija.DohvatiLet().NazivPolazisnogAerodroma} -> {initRezervacija.DohvatiLet().NazivOdredisnogAerodroma}.");

                this.Close();
            }

        }
    }
}
