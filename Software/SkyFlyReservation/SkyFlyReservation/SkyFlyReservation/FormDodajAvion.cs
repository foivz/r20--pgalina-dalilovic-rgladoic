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
    public partial class FormDodajAvion : Form
    {
        public FormDodajAvion()
        {
            InitializeComponent();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dodajAvionButton_Click(object sender, EventArgs e)
        {
            string identifikatorAviona = identifikatorAvionaTextBox.Text;
            string proizvodacAviona = proizvodacAvionaTextBox.Text;
            string modelAviona = modelAvionaTextBox.Text;
            string brojSjedala = brojSjedalaTextBox.Text;
            Aviokompanija aviokompanija = RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija;

            bool provjeraPodataka = ProvjeriPodatke(identifikatorAviona, proizvodacAviona, modelAviona, brojSjedala);

            if(provjeraPodataka == true)
            {
                Avion avion = new Avion()
                {
                    IdentifikatorAviona = identifikatorAviona,
                    ProizvodacAviona = proizvodacAviona,
                    ModelAviona = modelAviona,
                    BrojMjesta = int.Parse(brojSjedala),
                    Aviokompanija = aviokompanija
                    
                };

                int numAffectedRows = RepozitorijSkyFlyReservation.DodajAvion(avion);

                if(numAffectedRows > 0)
                {
                    MessageBox.Show($"Avion {avion.ProizvodacAviona} {avion.ModelAviona} | {avion.IdentifikatorAviona} je uspješno dodan u sustav.");
                    this.Close();
                }
            }
        }

        private bool ProvjeriPodatke(string identifikatorAviona, string proizvodacAviona, string modelAviona, string brojSjedala)
        {
            if(identifikatorAviona.Length > 10)
            {
                MessageBox.Show("Registarska oznaka ne može imati više od 10 znakova.");
                return false;
            }
            if(identifikatorAviona == "")
            {
                MessageBox.Show("Niste unijeli registarsku oznaku aviona.");
                return false;
            }
            if(proizvodacAviona == "")
            {
                MessageBox.Show("Niste unijeli naziv proizvođača aviona.");
                return false;
            }
            if(modelAviona == "")
            {
                MessageBox.Show("Niste unijeli naziv modela aviona.");
                return false;
            }
            if(brojSjedala == "")
            {
                MessageBox.Show("Niste unijeli broj sjedala u avionu.");
                return false;
            }
            if(int.Parse(brojSjedala) > 174)
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

        private void FormDodajAvion_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, "DodajAvion.htm");
            }
        }
    }
}
