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
    public partial class FormAzurirajLet : Form
    {
        private Let selektiraniLet;
        private Avion avionNaLetu;
        public FormAzurirajLet(Let selektirani)
        {
            selektiraniLet = selektirani;
            avionNaLetu = selektiraniLet.DohvatiAvion();
            InitializeComponent();
        }

        private void FormAzurirajLet_Load(object sender, EventArgs e)
        {
            OsvjeziComboBox();
            OsvjeziDetalje();
        }

        private void OsvjeziComboBox()
        {
            List<string> popisAerodroma = new List<string>();
            List<string> popisaAviona = new List<string>();
            List<string> popisValuta = new List<string>();

            foreach (Aerodrom aerodrom in RepozitorijSkyFlyReservation.Aerodromi)
            {
                popisAerodroma.Add(aerodrom.NazivAerodroma);
            }

            //posložiti da radi prema aviokompaniji korisnika koji dodaje let
            foreach (Aviokompanija aviokompanija in RepozitorijSkyFlyReservation.Aviokompanije)
            {
                foreach (Avion avion in aviokompanija.AvioniAviokompanije)
                {
                    popisaAviona.Add(avion.ProizvodacAviona + " " + avion.TipAviona);
                }
            }

            foreach (Valuta valuta in RepozitorijSkyFlyReservation.Valute)
            {
                popisValuta.Add(valuta.Oznaka);
            }

            polazisniComboBox.DataSource = popisAerodroma.ToList();
            odredisniComboBox.DataSource = popisAerodroma.ToList();
            avionNaLetuComboBox.DataSource = popisaAviona;
            valutaComboBox.DataSource = popisValuta;
        }

        private void OsvjeziDetalje()
        {
            polazisniComboBox.SelectedItem = selektiraniLet.NazivPolazisnogAerodroma;
            odredisniComboBox.SelectedItem = selektiraniLet.NazivOdredisnogAerodroma;
            avionNaLetuComboBox.SelectedItem = selektiraniLet.DohvatiAvion().ProizvodacAviona + " " + selektiraniLet.DohvatiAvion().TipAviona;
            datumVrijemePolaskaDateTimePicker.Value = selektiraniLet.DatumPolaska;
            datumVrijemeDolaskaDateTimePicker.Value = selektiraniLet.DatumDolaska;
            cijenaKarteTextBox.Text = selektiraniLet.CijenaKarte.ToString();
            valutaComboBox.SelectedItem = selektiraniLet.OznakaValute;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void azurirajLetButton_Click(object sender, EventArgs e)
        {
            string polazisniAerodrom = polazisniComboBox.SelectedItem as string;
            string odredisniAerodrom = odredisniComboBox.SelectedItem as string;
            DateTime datumVrijemePolaska = datumVrijemePolaskaDateTimePicker.Value;
            DateTime datumVrijemeDolaska = datumVrijemeDolaskaDateTimePicker.Value;
            string avion = avionNaLetuComboBox.SelectedItem as string;
            double cijenaKarte = double.Parse(cijenaKarteTextBox.Text);
            string oznakaValute = valutaComboBox.SelectedItem as string;


            Aerodrom polazisni = RepozitorijSkyFlyReservation.DohvatiSelektiraniAerodrom(polazisniAerodrom);
            Aerodrom odredisni = RepozitorijSkyFlyReservation.DohvatiSelektiraniAerodrom(odredisniAerodrom);
            Avion odabraniAvion = null;

            foreach (Aviokompanija aviokompanija in RepozitorijSkyFlyReservation.Aviokompanije)
            {
                foreach (Avion a in aviokompanija.AvioniAviokompanije)
                {
                    if (a.ProizvodacAviona == avion.Split(' ')[0] && a.TipAviona == avion.Split(' ')[1])
                    {
                        odabraniAvion = a;
                    }
                }
            }

            double brojMjesta = odabraniAvion.BrojMjesta;

            if(avionNaLetu != odabraniAvion)
            {
                foreach (Sjedalo s in avionNaLetu.SjedalaUAvionu)
                {
                    if(s.StatusSjedala == StanjeSjedala.Zauzeto)
                    {
                        odabraniAvion.AzurirajSjedalo(s.OznakaSjedala, StanjeSjedala.Zauzeto);
                        brojMjesta--;
                    }
                }
            }

            bool ispravno = ProvjeriPodatke(polazisniAerodrom, odredisniAerodrom, datumVrijemePolaska, datumVrijemeDolaska);

            if (cijenaKarteTextBox.Text != "" && ispravno)
            {
                selektiraniLet.AzurirajLet(polazisni,odredisni, odabraniAvion, brojMjesta, datumVrijemePolaska, datumVrijemeDolaska, cijenaKarte, RepozitorijSkyFlyReservation.DohvatiValutu(oznakaValute));
                MessageBox.Show($"Let {polazisni.NazivAerodroma}->{odredisni.NazivAerodroma} je uspješno ažuriran.");
                this.Close();
            }
            else if (cijenaKarteTextBox.Text == "")
            {
                MessageBox.Show("Cijena karte mora biti unesena.");
            }
        }

        private bool ProvjeriPodatke(string polazisniAerodrom, string odredisniAerodrom, DateTime datumVrijemePolaska, DateTime datumVrijemeDolaska)
        {
            bool ispravno = true;

            if (polazisniAerodrom == odredisniAerodrom)
            {
                MessageBox.Show("Polazišni i odredišni aerodrom ne smiju biti isti.");
                ispravno = false;
            }
            else if (datumVrijemeDolaska < datumVrijemePolaska)
            {
                MessageBox.Show("Datum dolaska ne smije biti manji od datuma polaska.");
                ispravno = false;
            }
            else if (datumVrijemePolaska < DateTime.Now)
            {
                MessageBox.Show($"Datum polaska ne može biti manji od datuma {DateTime.Now.Date.ToString("dd/MM/yyyy")}.");
                ispravno = false;
            }
            else if (datumVrijemeDolaska < DateTime.Now)
            {
                MessageBox.Show($"Datum dolaska ne može biti manji od datuma {DateTime.Now.Date.ToString("dd/MM/yyyy")}.");
                ispravno = false;
            }

            return ispravno;
        }
    }
}
