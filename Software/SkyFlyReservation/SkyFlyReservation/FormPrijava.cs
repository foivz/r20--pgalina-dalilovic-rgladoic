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
    public partial class FormPrijava : Form
    {
        bool SeePassword = false;
        bool Autentikacija = false;
        public FormPrijava()
        {
            this.KeyPreview = true;
            InitializeComponent();
            SetupPasswordTextbox();
        }

        private void SetupPasswordTextbox()
        {
            txtLozinka.PasswordChar = '•';
        }

        private void PrijaviSeButton_Click(object sender, EventArgs e)
        {
            string KorisnickoIme = txtKorIme.Text;
            string Lozinka = txtLozinka.Text;

            List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiSveKorisnike();
            Korisnik korisnik = new Korisnik();
            foreach (var item in korisnici)
            {
                if(KorisnickoIme == item.KorisnickoImeKorisnika && Lozinka == item.LozinkaKorisnika)
                {
                    Autentikacija = true;
                    korisnik = item;
                }
            }

            if(Autentikacija == true)
            {
                RepozitorijSkyFlyReservation.prijavljeniKorisnik = korisnik;
                this.Close();
            }
            else
            {
                MessageBox.Show("Korisnik sa navedenim podacima ne postoji!");
            }
        }

        private void btnSeePassword_Click(object sender, EventArgs e)
        {
            if (SeePassword)
            {
                txtLozinka.PasswordChar = '•';
                SeePassword = false;
            }
            else
            {
                txtLozinka.PasswordChar = '\0';
                SeePassword = true;
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ZaboravljenaLozinkaLabel_Click(object sender, EventArgs e)
        {
            FormZaboravljenaLozinka form = new FormZaboravljenaLozinka();
            form.ShowDialog();
        }

        private void FormPrijava_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();

                controler.OtvoriUserHelp(this, "Prijava.htm");
            }
        }
    }
}
