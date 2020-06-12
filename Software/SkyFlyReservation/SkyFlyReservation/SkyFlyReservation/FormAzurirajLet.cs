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
        public FormAzurirajLet()
        {
            InitializeComponent();
        }

        private void FormAzurirajLet_Load(object sender, EventArgs e)
        {
            nazivAviokompanijeLabel.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.NazivAviokompanije;
            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
            OsvjeziComboBox();
        }

        private void OsvjeziDGV(List<Let> letovi)
        {
            popisLetovaDataGridView.DataSource = null;
            popisLetovaDataGridView.DataSource = letovi;

            popisLetovaDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            popisLetovaDataGridView.ReadOnly = true;

            popisLetovaDataGridView.Columns[1].HeaderText = "Broj leta";
            popisLetovaDataGridView.Columns[2].HeaderText = "Polazišni aerodrom";
            popisLetovaDataGridView.Columns[3].HeaderText = "Odredišni aerodrom";
            popisLetovaDataGridView.Columns[4].HeaderText = "Datum polaska";
            popisLetovaDataGridView.Columns[5].HeaderText = "Datum dolaska";
            popisLetovaDataGridView.Columns[6].HeaderText = "Avion";
            popisLetovaDataGridView.Columns[7].HeaderText = "Cijena karte";
            popisLetovaDataGridView.Columns[8].HeaderText = "Broj slobodnih mjesta";

            popisLetovaDataGridView.Columns[0].Visible = false;
        }

        private void OsvjeziComboBox()
        {
            polazisniComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAerodrome().ToList();
            polazisniComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            odredisniComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAerodrome().ToList();
            odredisniComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            avionNaLetuComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAvione().ToList();
            avionNaLetuComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void azurirajLetButton_Click(object sender, EventArgs e)
        {
            Let odabraniLet = DohvatiSelektiraniLet();

            if(odabraniLet == null)
            {
                MessageBox.Show("Niste odabrali let koji želite ažurirati.");
                return;
            }

            Aerodrom polazisniAerodrom = polazisniComboBox.SelectedItem as Aerodrom;
            Aerodrom odredisniAerodrom = odredisniComboBox.SelectedItem as Aerodrom;
            Avion avionNaLetu = avionNaLetuComboBox.SelectedItem as Avion;
            DateTime datumPolaska = datumVrijemePolaskaDateTimePicker.Value;
            DateTime datumDolaska = datumVrijemeDolaskaDateTimePicker.Value;
            double cijenaKarte = double.Parse(cijenaKarteTextBox.Text);

            bool provjeraPodataka = ProvjeriPodatke(polazisniAerodrom, odredisniAerodrom, datumPolaska, datumDolaska);

            if(provjeraPodataka == true)
            {
                int brojRezervacija = odabraniLet.AvionNaLetu.BrojMjesta - odabraniLet.BrojSlobodnihMjesta;


                if (brojRezervacija > avionNaLetu.BrojMjesta)
                {
                    MessageBox.Show($"Na letu {odabraniLet.BrojLeta} je rezervirano {odabraniLet.AvionNaLetu.BrojMjesta - odabraniLet.BrojSlobodnihMjesta} sjedala.\nAvion {avionNaLetu.ProizvodacAviona} {avionNaLetu.ModelAviona} nema dovoljno sjedala.");
                    return;
                }

                string noviBrojLeta = odabraniLet.BrojLeta;

                if ((odabraniLet.PolazisniAerodrom.AerodromId != polazisniAerodrom.AerodromId) || (odabraniLet.OdredisniAerodrom.AerodromId != odredisniAerodrom.AerodromId))
                {
                    string brojLeta = odabraniLet.BrojLeta;

                    int broj = int.Parse(brojLeta.Substring(3, 5));

                    noviBrojLeta = polazisniAerodrom.OznakaAerodroma + broj + odredisniAerodrom.OznakaAerodroma;
                }

                odabraniLet.BrojLeta = noviBrojLeta;
                odabraniLet.PolazisniAerodrom = polazisniAerodrom;
                odabraniLet.OdredisniAerodrom = odredisniAerodrom;
                odabraniLet.AvionNaLetu = avionNaLetu;
                odabraniLet.DatumPolaska = datumPolaska;
                odabraniLet.DatumDolaska = datumDolaska;
                odabraniLet.CijenaKarte = cijenaKarte;
                odabraniLet.BrojSlobodnihMjesta = avionNaLetu.BrojMjesta - brojRezervacija;

                int numAffectedRows = RepozitorijSkyFlyReservation.AzurirajLet(odabraniLet);

                if (numAffectedRows > 0)
                {
                    MessageBox.Show($"Let {polazisniAerodrom.NazivAerodroma}->{odredisniAerodrom.NazivAerodroma} je uspješno ažuriran.");
                    this.Close();
                }
            }

        }

        private bool ProvjeriPodatke(Aerodrom polazisniAerodrom, Aerodrom odredisniAerodrom, DateTime datumVrijemePolaska, DateTime datumVrijemeDolaska)
        {
            if (polazisniAerodrom.AerodromId == odredisniAerodrom.AerodromId)
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
            else if (cijenaKarteTextBox.Text == "")
            {
                MessageBox.Show("Cijena karte mora biti unesena.");
                return false;
            }
            return true;
        }


        private void popisLetovaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            AzurirajDetalje(selektiraniLet);
        }

        private void AzurirajDetalje(Let let)
        {
            for (int i = 0; i < polazisniComboBox.Items.Count; i++)
            {
                if(((Aerodrom)polazisniComboBox.Items[i]).AerodromId == let.PolazisniAerodrom.AerodromId)
                {
                    polazisniComboBox.SelectedIndex = i;
                }
                if(((Aerodrom)odredisniComboBox.Items[i]).AerodromId == let.OdredisniAerodrom.AerodromId)
                {
                    odredisniComboBox.SelectedIndex = i;
                }
            }

            for (int i = 0; i < avionNaLetuComboBox.Items.Count; i++)
            {
                if (((Avion)avionNaLetuComboBox.Items[i]).AvionId == let.AvionNaLetu.AvionId)
                {
                    avionNaLetuComboBox.SelectedIndex = i;
                }
            }

            datumVrijemePolaskaDateTimePicker.Value = let.DatumPolaska;
            datumVrijemeDolaskaDateTimePicker.Value = let.DatumDolaska;
            cijenaKarteTextBox.Text = let.CijenaKarte.ToString();
        }

        private Let DohvatiSelektiraniLet()
        {
            Let selektiraniLet = null;

            if(popisLetovaDataGridView.CurrentRow != null)
            {
                selektiraniLet = popisLetovaDataGridView.CurrentRow.DataBoundItem as Let;
            }

            return selektiraniLet;
        }

        private void FormAzurirajLet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, "AzurirajLet.htm");
            }
        }
    }
}
