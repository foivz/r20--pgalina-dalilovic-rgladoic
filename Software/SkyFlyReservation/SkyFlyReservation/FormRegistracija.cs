using SkyFlyReservation.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SkyFlyReservation
{
    public partial class FormRegistracija : Form
    {
        private bool seePassword1 = false;
        private bool seePassword2 = false;
        public FormRegistracija()
        {
            InitializeComponent();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            if (txtLozinka.Text.Length < 8)
            {
                MessageBox.Show("Lozinka mora biti najmanje 8 znakova!");
            }
            else if(RepozitorijSkyFlyReservation.DohvatiKorisnika(txtKorIme.Text) != null)
            {
                MessageBox.Show("Korisničko ime je zauzeto!");
            }
            else if (txtIme.Text.Length == 0)
            {
                MessageBox.Show("Polje za ime je prazno!");
            }
            else if (txtPrezime.Text.Length == 0)
            {
                MessageBox.Show("Polje za prezime je prazno!");
            }
            else if (!Regex.IsMatch(txtEmail.Text, "^.+@.+\\..+$"))
            {
                MessageBox.Show("Email mora izgledati: Example@example.example");
            }
            else if (txtAdresa.Text.Length == 0)
            {
                MessageBox.Show("Polje za adresu je prazno!");
            }
            else if (txtKontakt.Text.Length == 0)
            {
                MessageBox.Show("Polje za kontakt je prazno!");
            }
            else if (txtOib.Text.Length == 0)
            {
                MessageBox.Show("Polje za OIB je prazno!");
            }
            else if (txtLozinka.Text != txtPonovljenaLozinka.Text)
            {
                MessageBox.Show("Lozinka i ponovljena lozinka se ne podudaraju!");
            }
            else
            {
                Korisnik korisnik = new Korisnik()
                {
                    ImeKorisnika = txtIme.Text,
                    PrezimeKorisnika = txtPrezime.Text,
                    AdresaKorisnika = txtAdresa.Text,
                    KontaktTelefonKorisnika = txtKontakt.Text,
                    EmailKorisnika = txtEmail.Text,
                    OIBKorisnika = txtOib.Text,
                    KorisnickoImeKorisnika = txtKorIme.Text,
                    LozinkaKorisnika = txtLozinka.Text
                };

                int numAffectedRows = RepozitorijSkyFlyReservation.DodajKorisnika(korisnik);

                if(numAffectedRows == 1)
                {
                    MessageBox.Show("Uspješna registracija!");
                    FormPregledLetova form = new FormPregledLetova();
                    form.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom registracije! Molimo pokušajte ponovno.");
                }
            }
        }

        private void FormRegistracija_Load(object sender, EventArgs e)
        {
            SetupPasswordTextbox();
        }

        private void SetupPasswordTextbox()
        {
            txtLozinka.PasswordChar = '•';
            txtPonovljenaLozinka.PasswordChar = '•';
        }

        private void btnSeePassword1_Click(object sender, EventArgs e)
        {
            if (seePassword1)
            {
                txtLozinka.PasswordChar = '•';
                seePassword1 = false;
            }
            else
            {
                txtLozinka.PasswordChar = '\0';
                seePassword1 = true;
            }
        }

        private void btnSeePassword2_Click(object sender, EventArgs e)
        {
            if (seePassword2)
            {
                txtPonovljenaLozinka.PasswordChar = '•';
                seePassword2 = false;
            }
            else
            {
                txtPonovljenaLozinka.PasswordChar = '\0';
                seePassword2 = true;
            }
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
