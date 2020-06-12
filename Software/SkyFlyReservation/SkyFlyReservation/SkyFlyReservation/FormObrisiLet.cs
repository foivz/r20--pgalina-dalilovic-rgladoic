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
    public partial class FormObrisiLet : Form
    {
        public FormObrisiLet()
        {
            InitializeComponent();
        }

        private void FormObrisiLet_Load(object sender, EventArgs e)
        {
            nazivAviokompanijeLabel.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.NazivAviokompanije;
            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
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

        private void popisLetovaDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            AzurirajDetalje(selektiraniLet);
        }

        private void AzurirajDetalje(Let selektiraniLet)
        {
            odabraniPolazisniTextBox.Text = selektiraniLet.PolazisniAerodrom.NazivAerodroma;
            odabraniOdredisniTextBox.Text = selektiraniLet.OdredisniAerodrom.NazivAerodroma;
            avionNaLetuTextBox.Text = selektiraniLet.AvionNaLetu.ProizvodacAviona + " " + selektiraniLet.AvionNaLetu.ModelAviona;
            vrijemePolaskaTextBox.Text = selektiraniLet.DatumPolaska.ToString();
            vrijemeDolaskaTextBox.Text = selektiraniLet.DatumDolaska.ToString();
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

        private void obrisiLetButton_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            if(selektiraniLet == null)
            {
                MessageBox.Show("Niste odabrali let koji želite obrisati.");
                return;
            }

            RepozitorijSkyFlyReservation.ObrisiRezervacije(selektiraniLet);
            int numAffectedRows = RepozitorijSkyFlyReservation.ObrisiLet(selektiraniLet);

            if (numAffectedRows > 0)
            {
                MessageBox.Show($"Uspješno ste obrisali let {selektiraniLet.BrojLeta} | {selektiraniLet.PolazisniAerodrom.NazivAerodroma}->{selektiraniLet.OdredisniAerodrom.NazivAerodroma}.");
                this.Close();
            }
        }

        private void FormObrisiLet_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, "ObrisiLet.htm");
            }
        }
    }
}
