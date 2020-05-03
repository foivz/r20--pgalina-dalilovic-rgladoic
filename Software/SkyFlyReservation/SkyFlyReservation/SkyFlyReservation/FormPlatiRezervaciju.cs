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
    public partial class FormPlatiRezervaciju : Form
    {
        private Rezervacija selektiranaRezervacija { get; set; }
        public FormPlatiRezervaciju(Rezervacija odabrana)
        {
            selektiranaRezervacija = odabrana;
            InitializeComponent();
        }

        private void FormPlatiRezervaciju_Load(object sender, EventArgs e)
        {
            oznakaLetaTextBox.Text = selektiranaRezervacija.BrojLetaRezervacije;
            odabraniPolazisniTextBox.Text = selektiranaRezervacija.DohvatiLet().NazivPolazisnogAerodroma;
            odabraniOdredisniTextBox.Text = selektiranaRezervacija.DohvatiLet().NazivOdredisnogAerodroma;
            vrijemePolaskaTextBox.Text = selektiranaRezervacija.DohvatiLet().DatumPolaska.ToString();
            cijenaKarteTextBox.Text = selektiranaRezervacija.DohvatiLet().CijenaKarte.ToString() + " " +selektiranaRezervacija.DohvatiLet().OznakaValute;
        }

        private void platiRezervacijuButton_Click(object sender, EventArgs e)
        {
            string imePlatitelja = imeTextBox.Text;
            string prezimePlatitelja = prezimeTextBox.Text;
            string oibPlatitelja = oibTextBox.Text;
            string brojKarticePlatitelja = brojKarticeTextBox.Text;
            bool provjeraRezervacije = ProvjeraRezervacije(selektiranaRezervacija);


            if(imePlatitelja == "" || prezimePlatitelja == "" || oibPlatitelja == "" || brojKarticePlatitelja == "" && provjeraRezervacije)
            {
                MessageBox.Show("Unijeli ste pogrešne podatke za plaćanje.");
            }
            else if(provjeraRezervacije)
            {
                Kupnja initKupnja = new Kupnja(selektiranaRezervacija, brojKarticePlatitelja);

                MessageBox.Show($"Uspješno ste platili rezervaciju za let {selektiranaRezervacija.DohvatiLet().NazivPolazisnogAerodroma} -> {selektiranaRezervacija.DohvatiLet().NazivOdredisnogAerodroma}.");
                this.Close();
            }
        }

        private bool ProvjeraRezervacije(Rezervacija selektiranaRezervacija)
        {
            bool provjeraRezervacije = false;

            if (selektiranaRezervacija.StatusRezervacije == StanjeRezervacije.Plaćena)
            {
                MessageBox.Show($"Rezervacija sjedala {selektiranaRezervacija.OznakaRezerviranogSjedala} na letu {selektiranaRezervacija.DohvatiLet().NazivPolazisnogAerodroma} -> {selektiranaRezervacija.DohvatiLet().NazivOdredisnogAerodroma} je plaćena.");
                this.Close();
            }
            else if (selektiranaRezervacija.StatusRezervacije == StanjeRezervacije.Istekla)
            {
                MessageBox.Show($"Rezervacija sjedala {selektiranaRezervacija.OznakaRezerviranogSjedala} na letu {selektiranaRezervacija.DohvatiLet().NazivPolazisnogAerodroma} -> {selektiranaRezervacija.DohvatiLet().NazivOdredisnogAerodroma} je istekla.");
                this.Close();
            }
            else
            {
                provjeraRezervacije = true;
            }

            return provjeraRezervacije;
        }
    }
}
