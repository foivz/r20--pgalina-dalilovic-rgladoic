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
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            this.KeyPreview = true;
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

            dgvNajpopularnijiLetovi.Columns[1].HeaderText = "Broj leta";
            dgvNajpopularnijiLetovi.Columns[2].HeaderText = "Polazišni aerodrom";
            dgvNajpopularnijiLetovi.Columns[3].HeaderText = "Odredišni aerodrom";
            dgvNajpopularnijiLetovi.Columns[4].HeaderText = "Datum polaska";
            dgvNajpopularnijiLetovi.Columns[5].HeaderText = "Datum dolaska";
            dgvNajpopularnijiLetovi.Columns[6].HeaderText = "Avion";
            dgvNajpopularnijiLetovi.Columns[7].HeaderText = "Cijena karte";
            dgvNajpopularnijiLetovi.Columns[8].HeaderText = "Broj slobodnih mjesta";

            dgvNajpopularnijiLetovi.Columns[0].Visible = false;
            dgvNajpopularnijiLetovi.Columns[6].Visible = false;
            dgvNajpopularnijiLetovi.Columns[7].Visible = false;
            dgvNajpopularnijiLetovi.Columns[8].Visible = false;
        }

        private void OsvjeziGumbe()
        {
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik == null)
            {
                btnRegistracija.Text = "Registracija";
                btnPrijava.Text = "Prijava";

                btnPregledAviona.Hide();
                btnPregledLetova.Hide();
                btnPregledRezervacija.Hide();
                btnPregledKorisnickihRacuna.Hide();
                btnPrikazIzvjesca.Hide();
            }
            else if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.RegistriraniKorisnik)
            {
                btnRegistracija.Text = "Odjava";
                btnPrijava.Text = "Korisnički račun";
                btnPregledAviona.Text = "Slanje zahtjeva za suradnju";

                btnPregledAviona.Show();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
                btnPrikazIzvjesca.Hide();
                btnPregledKorisnickihRacuna.Hide();
            }
            else if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Moderator)
            {
                btnRegistracija.Text = "Odjava";
                btnPrijava.Text = "Korisnički račun";
                btnPregledAviona.Text = "Pregled aviona";

                btnPregledAviona.Show();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
            }
            else if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Administrator)
            {
                btnRegistracija.Text = "Odjava";
                btnPrijava.Text = "Korisnički račun";
                btnPregledAviona.Text = "Pregled aviona";
                btnPregledKorisnickihRacuna.Text = "Pregled korisničkih računa";

                btnPregledAviona.Show();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
                btnPregledKorisnickihRacuna.Show();
                btnPrikazIzvjesca.Show();
            }
            else if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Owner)
            {
                btnRegistracija.Text = "Odjava";
                btnPrijava.Text = "Korisnički račun";
                btnPregledAviona.Text = "Pregled aviona";
                btnPregledKorisnickihRacuna.Text = "Pregled zahtjeva";

                btnPregledAviona.Show();
                btnPregledLetova.Show();
                btnPregledRezervacija.Show();
                btnPregledKorisnickihRacuna.Show();
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
                FormKorisnickiRacun form = new FormKorisnickiRacun();
                form.ShowDialog();
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik == null)
            {
                FormRegistracija form = new FormRegistracija();
                form.ShowDialog();
                OsvjeziGumbe();
            }
            else
            {
                RepozitorijSkyFlyReservation.prijavljeniKorisnik = null;
                OsvjeziGumbe();
            }
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
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.RegistriraniKorisnik)
            {
                FormSlanjeZahtjeva form = new FormSlanjeZahtjeva();
                form.ShowDialog();
            }
            else
            {
                FormPregledAvionaAviokompanije form = new FormPregledAvionaAviokompanije();
                form.ShowDialog();
            }
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

        private void btnPregledKorisnickihRacuna_Click(object sender, EventArgs e)
        {
            if (RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.Owner)
            {
                FormPregledZahtjeva form = new FormPregledZahtjeva();
                form.ShowDialog();
            }
            else
            {
                FormPregledKorisnickihRacuna form = new FormPregledKorisnickihRacuna();
                form.ShowDialog();
            }
        }

        private void btnPrikazIzvjesca_Click(object sender, EventArgs e)
        {
            FormPrikazIzvjesca form = new FormPrikazIzvjesca();
            form.ShowDialog();
        }

        private Let DohvatiSelektiraniLet()
        {
            if (dgvNajpopularnijiLetovi.CurrentRow != null)
            {
                return dgvNajpopularnijiLetovi.CurrentRow.DataBoundItem as Let;
            }

            return null;
        }

        private void FormPocetna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();
                controler.OtvoriUserHelp(this, "OAplikaciji.htm");
            }
        }

    }
}