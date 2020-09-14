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
using UserHelpControler;
using ValidacijaZahtjeva;
using Validation;

namespace SkyFlyReservation
{
    public partial class FormSlanjeZahtjeva : Form
    {
        public FormSlanjeZahtjeva()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormSlanjeZahtjeva_Load(object sender, EventArgs e)
        {
            IspuniPolja();
        }

        private void IspuniPolja()
        {
            txtIme.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika;
            txtPrezime.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika;
            txtEmail.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.EmailKorisnika;
            txtAdresa.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.AdresaKorisnika;
            txtKontakt.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.KontaktTelefonKorisnika;
            txtOib.Text = RepozitorijSkyFlyReservation.prijavljeniKorisnik.OIBKorisnika;

            txtIme.Enabled = false;
            txtPrezime.Enabled = false;
            txtEmail.Enabled = false;
            txtAdresa.Enabled = false;
            txtKontakt.Enabled = false;
            txtOib.Enabled = false;
        }

        private void btnPosalji_Click(object sender, EventArgs e)
        {

            string[] validiraj = new string[9];
            
            validiraj[0] = txtNazivAviokompanije.Text;
            validiraj[1] = txtOIBaviokompanije.Text;
            validiraj[2] = txtIBAN.Text;
            validiraj[3] = txtAdresaAviokompanije.Text;
            validiraj[4] = txtTelefonAviokompanije.Text;
            validiraj[5] = txtEmailAviokompanije.Text;
            validiraj[6] = textBoxZahtjev.Text;


            Validacija validacija = new Validacija();
            string poruka = validacija.Validiraj(validiraj);
            
            if (poruka != "")
            {
                MessageBox.Show(poruka);
            }
            else
            {
                ZahtjevZaSuradnju zahtjev = new ZahtjevZaSuradnju()
                {
                    Korisnik = RepozitorijSkyFlyReservation.prijavljeniKorisnik,
                    DatumVrijemeKreiranja = DateTime.Now,
                    TekstZahtjeva = textBoxZahtjev.Text
                };

                Aviokompanija aviokompanija = new Aviokompanija()
                {
                    NazivAviokompanije = txtNazivAviokompanije.Text,
                    OIBAviokompanije = txtOIBaviokompanije.Text,
                    IBANAviokompanije = txtIBAN.Text,
                    AdresaAviokompanije = txtAdresaAviokompanije.Text,
                    KontaktAviokompanije = txtTelefonAviokompanije.Text,
                    EmailAviokompanije = txtEmailAviokompanije.Text
                };

                int numAffectedRowsZahtjev = RepozitorijSkyFlyReservation.DodajZahtjev(zahtjev);

                numAffectedRowsZahtjev += RepozitorijSkyFlyReservation.DodajAviokompaniju(aviokompanija);

                numAffectedRowsZahtjev += RepozitorijSkyFlyReservation.PridruziAviokompaniju(aviokompanija,zahtjev.Korisnik.KorisnikId);

                if (numAffectedRowsZahtjev != 0 )
                {
                    MessageBox.Show("Zahtjev za suradnju je uspješno poslan.");

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Došlo je do greške prilikom slanja zahtjeva! Molimo pokušajte ponovno.");
                }
            }
        }

        private void FormSlanjeZahtjeva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();
                controler.OtvoriUserHelp(this, "SlanjeZahtjeva.htm");
            }
        }
    }
}
