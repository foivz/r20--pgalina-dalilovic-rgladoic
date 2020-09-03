using SkyFlyReservation.Class;
using System;
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
    public partial class FormPregledZahtjeva : Form
    {
        public FormPregledZahtjeva()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetaljiZahtjeva_Click(object sender, EventArgs e)
        {
            ZahtjevZaSuradnju selektiraniZahtjev = DohvatiSelektiraniZahtjev();

            if (selektiraniZahtjev == null)
            {
                MessageBox.Show("Niste odabrali zahtjev za koji želite vidjeti detalje.");
                return;
            }
            FormDetaljiZahtjeva form = new FormDetaljiZahtjeva(selektiraniZahtjev);
            form.ShowDialog();

            List<ZahtjevZaSuradnju> zahtjevi = RepozitorijSkyFlyReservation.DohvatiZahtjeve();
            OsvjeziDGV(zahtjevi);
        }
        private ZahtjevZaSuradnju DohvatiSelektiraniZahtjev()
        {
            if (dgvPregledZahtjeva.CurrentRow != null)
            {
                return dgvPregledZahtjeva.CurrentRow.DataBoundItem as ZahtjevZaSuradnju;
            }

            return null;
        }

        private void FormPregledZahtjeva_Load(object sender, EventArgs e)
        {
            List<ZahtjevZaSuradnju> zahtjevi = RepozitorijSkyFlyReservation.DohvatiZahtjeve();
            OsvjeziDGV(zahtjevi);
        }

        private void OsvjeziDGV(List<ZahtjevZaSuradnju> zahtjevi)
        {
            dgvPregledZahtjeva.DataSource = null;
            dgvPregledZahtjeva.DataSource = zahtjevi;

            dgvPregledZahtjeva.Columns[0].HeaderText = "ID zahtjeva";
            dgvPregledZahtjeva.Columns[1].HeaderText = "Ime i prezime korisnika";
            dgvPregledZahtjeva.Columns[2].HeaderText = "Datum i vrijeme kreiranja";
            dgvPregledZahtjeva.Columns[3].HeaderText = "Tekst zahtjeva";
            dgvPregledZahtjeva.Columns[4].HeaderText = "Status zahtjeva";
            
            dgvPregledZahtjeva.Columns[0].Width = 100;
            dgvPregledZahtjeva.Columns[1].Width = 150;
            dgvPregledZahtjeva.Columns[2].Width = 150;
            dgvPregledZahtjeva.Columns[3].Width = 207;
            dgvPregledZahtjeva.Columns[4].Width = 100;
        }

        private void FormPregledZahtjeva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();
                controler.OtvoriUserHelp(this, "PregledZahtjeva.htm");
            }
        }
    }
}
