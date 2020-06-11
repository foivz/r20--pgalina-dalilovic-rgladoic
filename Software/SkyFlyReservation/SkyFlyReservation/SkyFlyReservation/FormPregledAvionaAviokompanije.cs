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
    public partial class FormPregledAvionaAviokompanije : Form
    {
        public FormPregledAvionaAviokompanije()
        {
            InitializeComponent();
        }

        private void FormPregledAvionaAviokompanije_Load(object sender, EventArgs e)
        {
            nazivAviokompanijeLabel.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.NazivAviokompanije;
            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
        }

        private void OsvjeziDGV(List<Avion> avioniAviokompanije)
        {
            popisAvionaDataGridView.DataSource = null;
            popisAvionaDataGridView.DataSource = avioniAviokompanije;

            popisAvionaDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            popisAvionaDataGridView.ReadOnly = true;

            popisAvionaDataGridView.Columns[1].HeaderText = "Registarska oznaka";
            popisAvionaDataGridView.Columns[2].HeaderText = "Proizvođač";
            popisAvionaDataGridView.Columns[3].HeaderText = "Model";
            popisAvionaDataGridView.Columns[4].HeaderText = "Broj sjedala";


            popisAvionaDataGridView.Columns[0].Visible = false;
            popisAvionaDataGridView.Columns[5].Visible = false;
        }

        private void dodajAvionButton_Click(object sender, EventArgs e)
        {
            FormDodajAvion form = new FormDodajAvion();
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
        }

        private void azurirajAvionButton_Click(object sender, EventArgs e)
        {
            Avion selektiraniAvion = DohvatiSelektiraniAvion();

            if(selektiraniAvion == null)
            {
                MessageBox.Show("Niste odabrali avion koji želite ažurirati.");
                return;
            }

            FormAzurirajAvion form = new FormAzurirajAvion(selektiraniAvion);
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
        }

        private Avion DohvatiSelektiraniAvion()
        {
            Avion avion = null;

            if(popisAvionaDataGridView.CurrentRow != null)
            {
                avion = popisAvionaDataGridView.CurrentRow.DataBoundItem as Avion;
            }

            return avion;
        }

        private void obrisiAvionButton_Click(object sender, EventArgs e)
        {
            Avion selektiraniAvion = DohvatiSelektiraniAvion();

            if(selektiraniAvion == null)
            {
                MessageBox.Show("Niste odabrali avion koji želite obrisati.");
                return;
            }

            int numAffectedRows = RepozitorijSkyFlyReservation.ObrisiAvion(selektiraniAvion);

            if(numAffectedRows > 0)
            {
                MessageBox.Show($"Uspješno ste obrisali avion {selektiraniAvion.ProizvodacAviona} {selektiraniAvion.ModelAviona} | {selektiraniAvion.IdentifikatorAviona}.");
            }

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
        }

        private void FormPregledAvionaAviokompanije_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, "PregledAvionaAviokompanije.htm");
            }
        }
    }
}
