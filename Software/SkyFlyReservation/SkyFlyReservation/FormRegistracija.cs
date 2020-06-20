﻿using SkyFlyReservation.Class;
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
using Validation;

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
            string[] validiraj = new string[9];
            validiraj[0] = txtIme.Text;
            validiraj[1] = txtPrezime.Text;
            validiraj[2] = txtEmail.Text;
            validiraj[3] = txtAdresa.Text;
            validiraj[4] = txtKontakt.Text;
            validiraj[5] = txtOib.Text;
            validiraj[6] = txtKorIme.Text;
            validiraj[7] = txtLozinka.Text;
            validiraj[8] = txtPonovljenaLozinka.Text;

            ValidacijaRegistracije validacija = new ValidacijaRegistracije();

            string poruka = validacija.Validiraj(validiraj);

            if (poruka != "")
            {
                MessageBox.Show(poruka);
            }
            else if(RepozitorijSkyFlyReservation.DohvatiKorisnika(txtKorIme.Text) != null)
            {
                MessageBox.Show("Korisničko ime je zauzeto!");
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

                int numAffectedRowsKorisnik = RepozitorijSkyFlyReservation.DodajKorisnika(korisnik);

                Korisnik dohvaceniKorisnik = RepozitorijSkyFlyReservation.DohvatiKorisnika(txtKorIme.Text);

                int numAffectedRowsRacun = RepozitorijSkyFlyReservation.DodajRacun(dohvaceniKorisnik.KorisnikId.ToString());

                if(numAffectedRowsKorisnik != 0 && numAffectedRowsRacun == 0)
                {
                    RepozitorijSkyFlyReservation.ObrisiKorisnika(dohvaceniKorisnik.KorisnikId.ToString());
                }

                if (numAffectedRowsKorisnik != 0 && numAffectedRowsRacun != 0)
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
