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
    public partial class FormAzurirajAvion : Form
    {
        private Avion selektiraniAvion;
        public FormAzurirajAvion(Avion avion)
        {
            InitializeComponent();
            selektiraniAvion = avion;
        }

        private void FormAzurirajAvion_Load(object sender, EventArgs e)
        {
            OsvjeziDetalje();
        }

        private void OsvjeziDetalje()
        {
            identifikatorAvionaTextBox.Text = selektiraniAvion.IdentifikatorAviona;
            proizvodacAvionaTextBox.Text = selektiraniAvion.ProizvodacAviona;
            modelAvionaTextBox.Text = selektiraniAvion.ModelAviona;
            brojSjedalaTextBox.Text = selektiraniAvion.BrojMjesta.ToString();
            aviokompanijaLabel.Visible = false;
            aviokompanijaComboBox.Visible = false;

            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Owner)
            {
                aviokompanijaLabel.Visible = true;
                aviokompanijaComboBox.Visible = true;

                aviokompanijaComboBox.DataSource = RepozitorijSkyFlyReservation.DohvatiAviokompanije().ToList();

                for (int i = 0; i < aviokompanijaComboBox.Items.Count; i++)
                {
                    if (((Aviokompanija)aviokompanijaComboBox.Items[i]).AviokompanijaId == selektiraniAvion.Aviokompanija.AviokompanijaId)
                    {
                        aviokompanijaComboBox.SelectedIndex = i;
                    }
                }
            }
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void azurirajAvionButton_Click(object sender, EventArgs e)
        {
            string identifikatorAviona = identifikatorAvionaTextBox.Text;
            string proizvodacAviona = proizvodacAvionaTextBox.Text;
            string modelAviona = modelAvionaTextBox.Text;
            string brojSjedala = brojSjedalaTextBox.Text;
            Aviokompanija aviokompanija = (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika != UlogaKorisnika.Owner) ? RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija : DohvatiSelektiranuAviokompaniju();

            bool provjeraPodataka = ProvjeriPodatke(identifikatorAviona, proizvodacAviona, modelAviona, brojSjedala);

            Avion avion = selektiraniAvion;

            if (provjeraPodataka == true)
            {
                selektiraniAvion.IdentifikatorAviona = identifikatorAviona;
                selektiraniAvion.ProizvodacAviona = proizvodacAviona;
                selektiraniAvion.ModelAviona = modelAviona;
                selektiraniAvion.BrojMjesta = int.Parse(brojSjedala);
                selektiraniAvion.Aviokompanija = aviokompanija;

                int numAffectedRows = RepozitorijSkyFlyReservation.AzurirajAvion(selektiraniAvion);

                if (numAffectedRows > 0)
                {
                    MessageBox.Show($"Avion {avion.ProizvodacAviona} {avion.ModelAviona} | {avion.IdentifikatorAviona} je uspješno ažuriran.");
                    this.Close();
                }
            }
        }

        private Aviokompanija DohvatiSelektiranuAviokompaniju()
        {
            return aviokompanijaComboBox.SelectedItem as Aviokompanija;
        }

        private bool ProvjeriPodatke(string identifikatorAviona, string proizvodacAviona, string modelAviona, string brojSjedala)
        {
            if (identifikatorAviona.Length > 10)
            {
                MessageBox.Show("Registarska oznaka ne može imati više od 10 znakova.");
                return false;
            }
            if (identifikatorAviona == "")
            {
                MessageBox.Show("Niste unijeli registarsku oznaku aviona.");
                return false;
            }
            if (proizvodacAviona == "")
            {
                MessageBox.Show("Niste unijeli naziv proizvođača aviona.");
                return false;
            }
            if (modelAviona == "")
            {
                MessageBox.Show("Niste unijeli naziv modela aviona.");
                return false;
            }
            if (brojSjedala == "")
            {
                MessageBox.Show("Niste unijeli broj sjedala u avionu.");
                return false;
            }
            if (int.Parse(brojSjedala) > 174)
            {
                MessageBox.Show("Avion može imati maksimalno 174 sjedala.");
                return false;
            }
            if (int.Parse(brojSjedala) <= 0)
            {
                MessageBox.Show("Avion ne može imati 0 ili manje od 0 sjedala.");
                return false;
            }

            return true;
        }

        private void FormAzurirajAvion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, "AzurirajAvion.htm");
            }
        }
    }
}
