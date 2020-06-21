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
    public partial class FormPregledAvionaAviokompanije : Form
    {
        public FormPregledAvionaAviokompanije()
        {
            InitializeComponent();
        }

        private void FormPregledAvionaAviokompanije_Load(object sender, EventArgs e)
        {
            if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika != UlogaKorisnika.Owner)
            {
                nazivAviokompanijeLabel.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.NazivAviokompanije;
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
            }
            if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Owner)
            {
                popisAvionaLabel.Text = "Popis aviona";
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiSveAvione());
            }
            
        }

        private void OsvjeziDGV(List<Avion> avioniAviokompanije)
        {
            popisAvionaDataGridView.DataSource = null;
            popisAvionaDataGridView.DataSource = avioniAviokompanije;

            popisAvionaDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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

            if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika != UlogaKorisnika.Owner)
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
            }
            else
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiSveAvione());
            }
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

            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika != UlogaKorisnika.Owner)
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
            }
            else
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiSveAvione());
            }
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

            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika != UlogaKorisnika.Owner)
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiAvione(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId));
            }
            else
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiSveAvione());
            }
        }

        private void FormPregledAvionaAviokompanije_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();

                controler.OtvoriUserHelp(this, "PregledAvionaAviokompanije.htm");
            }
        }
    }
}
