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
    public partial class FormPrijava : Form
    {
        bool SeePassword = false;
        bool Autentikacija = false;
        public FormPrijava()
        {
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
                FormPregledLetova form = new FormPregledLetova();
                form.ShowDialog();
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
    }
}
