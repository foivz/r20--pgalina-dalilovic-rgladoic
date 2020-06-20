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

namespace SkyFlyReservation
{
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            InitializeComponent();
        }

        private void FormPocetna_Load(object sender, EventArgs e)
        {
            picMenu.BackColor = System.Drawing.Color.LightGray;
            OsvjeziGumbe();
            OsvjeziDGV();
        }

        private void OsvjeziDGV()
        {
            dgvNajpopularnijiLetovi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            List<Let> Letovi = RepozitorijSkyFlyReservation.DohvatiNajpopularnijeLetove();
            dgvNajpopularnijiLetovi.DataSource = null;
            dgvNajpopularnijiLetovi.DataSource = Letovi;
        }

        private void OsvjeziGumbe()
        {
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik == null)
            {
                btnRegistracija.Show();
                btnPrijava.Show();

                btnPregledAviona.Hide();
                btnPregledLetova.Hide();
                btnPregledRezervacija.Hide();
            }
            else if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.RegistriraniKorisnik)
            {
                btnRegistracija.Hide();
                btnPrijava.Text = "Korisnički račun";

                btnPregledAviona.Hide();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
            }
            else if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Moderator)
            {
                btnRegistracija.Hide();
                btnPrijava.Text = "Korisnički račun";

                btnPregledAviona.Show();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
            }
            else if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Administrator)
            {
                btnRegistracija.Hide();
                btnPrijava.Text = "Korisnički račun";

                btnPregledAviona.Show();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
            }
            else if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Owner)
            {
                btnRegistracija.Hide();
                btnPrijava.Text = "Korisnički račun";

                btnPregledAviona.Show();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
            }
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik == null)
            {
                FormPrijava form = new FormPrijava();
                form.ShowDialog();
                OsvjeziGumbe();
            }
            else
            {
                MessageBox.Show("Ovdje dolazi korisnički račun!");
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FormRegistracija form = new FormRegistracija();
            form.ShowDialog();
            OsvjeziGumbe();
        }

        private void btnPregledLetova_Click(object sender, EventArgs e)
        {
            FormPregledLetova form = new FormPregledLetova();
            form.ShowDialog();
        }

        private void btnPregledRezervacija_Click(object sender, EventArgs e)
        {
            FormPregledRezervacija form = new FormPregledRezervacija();
            form.ShowDialog();
        }

        private void btnPregledAviona_Click(object sender, EventArgs e)
        {
            FormPregledAvionaAviokompanije form = new FormPregledAvionaAviokompanije();
            form.ShowDialog();
        }

        private void btnRezerviraj_Click(object sender, EventArgs e)
        {
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik == null)
            {
                FormPrijava form = new FormPrijava();
                form.ShowDialog();
                OsvjeziGumbe();
            }
            else
            {
                Let selektiraniLet = DohvatiSelektiraniLet();

                if (selektiraniLet == null)
                {
                    MessageBox.Show("Niste odabrali let za koji želite rezervirati kartu.");
                    return;
                }

                FormRezervacijaKarte form = new FormRezervacijaKarte(selektiraniLet);
                form.ShowDialog();
            }
            OsvjeziDGV();
        }

        private void btnKupi_Click(object sender, EventArgs e)
        {
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik == null)
            {
                FormPrijava form = new FormPrijava();
                form.ShowDialog();
                OsvjeziGumbe();
            }
            else
            {
                Let selektiraniLet = DohvatiSelektiraniLet();

                if (selektiraniLet == null)
                {
                    MessageBox.Show("Niste odabrali let za koji želite kupiti kartu.");
                    return;
                }

                FormRezervacijaKarte form = new FormRezervacijaKarte(selektiraniLet);
                form.ShowDialog();

                OsvjeziDGV();
            }
        }

        private Let DohvatiSelektiraniLet()
        {
            if (dgvNajpopularnijiLetovi.CurrentRow != null)
            {
                return dgvNajpopularnijiLetovi.CurrentRow.DataBoundItem as Let;
            }

            return null;
        }
    }
}
