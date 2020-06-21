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
using UserHelpControler;

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
            List<Aerodrom> aerodromi = RepozitorijSkyFlyReservation.DohvatiAerodrome();
            OsvjeziComboBox(aerodromi);
        }

        private void OsvjeziComboBox(List<Aerodrom> aerodromi)
        {
            polazisniAerodromComboBox.DataSource = aerodromi.ToList();
            polazisniAerodromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            odredisniAerodromComboBox.DataSource = aerodromi.ToList();
            odredisniAerodromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika != UlogaKorisnika.Owner)
            {
                aviokompanijaLabel.Visible = false;
                aviokompanijeComboBox.Visible = false;

                avionNaLetuLabel.Location = new Point(50,235);
                avionNaLetuComboBox.Location = new Point(50, 250);

                cijenaKarteLabel.Location = new Point(50, 290);
                cijenaKarteTextBox.Location = new Point(50, 305);

                valutaTextBox.Location = new Point(150, 305);

                avionNaLetuComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAvione().ToList();
            }
            else
            {
                aviokompanijeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

                aviokompanijeComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAviokompanije();

                avionNaLetuComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiSveAvione();
            }

            avionNaLetuComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajLetButton_Click(object sender, EventArgs e)
        {
            Aerodrom polazisniAerodrom = polazisniAerodromComboBox.SelectedItem as Aerodrom;
            Aerodrom odredisniAerodrom = odredisniAerodromComboBox.SelectedItem as Aerodrom;
            DateTime datumVrijemePolaska = datumVrijemePolaskaDateTimePicker.Value;
            DateTime datumVrijemeDolaska = datumVrijemeDolaskaDateTimePicker.Value;
            Avion avion = avionNaLetuComboBox.SelectedItem as Avion;
            double cijenaKarte = int.Parse(cijenaKarteTextBox.Text);

            bool provjeraPodataka = ProvjeriPodatke(polazisniAerodrom, odredisniAerodrom, datumVrijemePolaska, datumVrijemeDolaska);

            if (provjeraPodataka)
            {
                BrojLetaGenerator generator = new BrojLetaGenerator();

                string brojLeta = generator.GenerirajBrojLeta(polazisniAerodrom, odredisniAerodrom);

                Let let = new Let()
                {
                    BrojLeta = brojLeta,
                    PolazisniAerodrom = polazisniAerodrom,
                    OdredisniAerodrom = odredisniAerodrom,
                    DatumPolaska = datumVrijemePolaska,
                    DatumDolaska = datumVrijemeDolaska,
                    AvionNaLetu = avion,
                    CijenaKarte = cijenaKarte,
                    BrojSlobodnihMjesta = avion.BrojMjesta
                };

                int numAffectedRows = RepozitorijSkyFlyReservation.DodajLet(let);

                if(numAffectedRows > 0)
                {
                    MessageBox.Show($"Let {polazisniAerodrom.NazivAerodroma}->{odredisniAerodrom.NazivAerodroma} je uspješno dodan u sustav.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Greška kod unosa u bazu podataka.");
                }
            }
        }

        private bool ProvjeriPodatke(Aerodrom polazisniAerodrom, Aerodrom odredisniAerodrom, DateTime datumVrijemePolaska, DateTime datumVrijemeDolaska)
        {
            bool ispravno = true;

            if(polazisniAerodrom.AerodromId == odredisniAerodrom.AerodromId)
            {
                MessageBox.Show("Polazišni i odredišni aerodrom ne smiju biti isti.");
                ispravno = false;
                return ispravno;
            }
            else if (datumVrijemeDolaska < datumVrijemePolaska)
            {
                MessageBox.Show("Datum dolaska ne smije biti manji od datuma polaska.");
                ispravno = false;
                return ispravno;
            }
            else if (datumVrijemePolaska < DateTime.Now)
            {
                MessageBox.Show($"Datum polaska ne može biti manji od datuma {DateTime.Now.Date.ToString("dd/MM/yyyy")}.");
                ispravno = false;
                return ispravno;
            }
            else if (datumVrijemeDolaska < DateTime.Now)
            {
                MessageBox.Show($"Datum dolaska ne može biti manji od datuma {DateTime.Now.Date.ToString("dd/MM/yyyy")}.");
                ispravno = false;
                return ispravno;
            }
            else if(cijenaKarteTextBox.Text == "")
            {
                MessageBox.Show("Cijena karte mora biti unesena.");
                ispravno = false;
                return ispravno;
            }
            else if(int.Parse(cijenaKarteTextBox.Text) < 0)
            {
                MessageBox.Show("Cijena karte ne može biti negativna.");
                ispravno = false;
                return ispravno;
            }

            return ispravno;
        }

        private void FormDodajLet_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();

                controler.OtvoriUserHelp(this, "DodajLet.htm");
            }
        }

        private void aviokompanijeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aviokompanija aviokompanija = DohvatiSelektiranuAviokompaniju();

            avionNaLetuComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAvione(aviokompanija.AviokompanijaId);
        }

        private Aviokompanija DohvatiSelektiranuAviokompaniju()
        {
            return aviokompanijeComboBox.SelectedItem as Aviokompanija;
        }
    }
}
