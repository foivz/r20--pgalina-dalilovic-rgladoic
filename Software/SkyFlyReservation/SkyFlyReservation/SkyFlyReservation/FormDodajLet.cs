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
            OsvjeziComboBox(RepozitorijSkyFlyReservation.DohvatiAerodrome());
        }

        private void OsvjeziComboBox(List<Aerodrom> aerodromi)
        {
            polazisniAerodromComboBox.DataSource = aerodromi.ToList();
            polazisniAerodromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            odredisniAerodromComboBox.DataSource = aerodromi.ToList();
            odredisniAerodromComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            avionNaLetuComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAvione().ToList();
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
            }
        }

        private bool ProvjeriPodatke(Aerodrom polazisniAerodrom, Aerodrom odredisniAerodrom, DateTime datumVrijemePolaska, DateTime datumVrijemeDolaska)
        {
            if(polazisniAerodrom.AerodromId == odredisniAerodrom.AerodromId)
            {
                MessageBox.Show("Polazišni i odredišni aerodrom ne smiju biti isti.");
                return false;
            }
            else if (datumVrijemeDolaska < datumVrijemePolaska)
            {
                MessageBox.Show("Datum dolaska ne smije biti manji od datuma polaska.");
                return false;
            }
            else if (datumVrijemePolaska < DateTime.Now)
            {
                MessageBox.Show($"Datum polaska ne može biti manji od datuma {DateTime.Now.Date.ToString("dd/MM/yyyy")}.");
                return false;
            }
            else if (datumVrijemeDolaska < DateTime.Now)
            {
                MessageBox.Show($"Datum dolaska ne može biti manji od datuma {DateTime.Now.Date.ToString("dd/MM/yyyy")}.");
                return false;
            }
            else if(cijenaKarteTextBox.Text == "")
            {
                MessageBox.Show("Cijena karte mora biti unesena.");
                return false;
            }
            return true;
        }

        private void FormDodajLet_KeyPress(object sender, KeyPressEventArgs e)
        {
            MessageBox.Show("Stisnut");
        }
    }
}
