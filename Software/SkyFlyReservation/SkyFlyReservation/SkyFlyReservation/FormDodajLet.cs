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
    public partial class FormDodajLet : Form
    {
        public FormDodajLet()
        {
            InitializeComponent();
        }

        private void FormDodajLet_Load(object sender, EventArgs e)
        {
            OsvjeziComboBox();
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

            polazisniAerodromComboBox.DataSource = popisAerodroma.ToList();
            odredisniAerodromComboBox.DataSource = popisAerodroma.ToList();
            avionNaLetuComboBox.DataSource = popisaAviona;
            valutaComboBox.DataSource = popisValuta;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajLetButton_Click(object sender, EventArgs e)
        {

            string polazisniAerodrom = polazisniAerodromComboBox.SelectedItem as string;
            string odredisniAerodrom = odredisniAerodromComboBox.SelectedItem as string;
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

            bool ispravno = ProvjeriPodatke(polazisniAerodrom, odredisniAerodrom, datumVrijemePolaska, datumVrijemeDolaska);

            if (cijenaKarteTextBox.Text != "" && ispravno)
            {   
                Let noviLet = new Let(polazisni, odredisni, odabraniAvion, datumVrijemePolaska, datumVrijemeDolaska, cijenaKarte, RepozitorijSkyFlyReservation.DohvatiValutu(oznakaValute));
                polazisni.DodajLet(noviLet);
                odredisni.DodajLet(noviLet);
                MessageBox.Show($"Let {polazisni.NazivAerodroma}->{odredisni.NazivAerodroma} je uspješno dodan u sustav.");
                this.Close();
            }
            else if(cijenaKarteTextBox.Text == "")
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
