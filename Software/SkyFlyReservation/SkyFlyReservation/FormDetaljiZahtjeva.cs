using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using SkyFlyReservation.Class;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserHelpControler;
using Validation;

namespace SkyFlyReservation
{
    public partial class FormDetaljiZahtjeva : Form
    {
        private ZahtjevZaSuradnju selektiraniZahtjev;
        public FormDetaljiZahtjeva(ZahtjevZaSuradnju zahtjev)
        {
            this.KeyPreview = true;
            InitializeComponent();
            selektiraniZahtjev = zahtjev;
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetaljiZahtjeva_Load(object sender, EventArgs e)
        {
            OsvjeziDetalje();
        }

        private void OsvjeziDetalje()
        {
            string status = selektiraniZahtjev.StatusZahtjeva.ToString();

            if(status == "Odbijen")
            {
                txtIme.Text = selektiraniZahtjev.Korisnik.ImeKorisnika.ToString();
                txtPrezime.Text = selektiraniZahtjev.Korisnik.PrezimeKorisnika.ToString();
                txtEmail.Text = selektiraniZahtjev.Korisnik.EmailKorisnika.ToString();
                txtAdresa.Text = selektiraniZahtjev.Korisnik.AdresaKorisnika.ToString();
                txtKontakt.Text = selektiraniZahtjev.Korisnik.KontaktTelefonKorisnika.ToString();
                txtOib.Text = selektiraniZahtjev.Korisnik.OIBKorisnika.ToString();
                textBoxZahtjev.Text = selektiraniZahtjev.TekstZahtjeva.ToString();

                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                txtEmail.Enabled = false;
                txtAdresa.Enabled = false;
                txtKontakt.Enabled = false;
                txtOib.Enabled = false;
                textBoxZahtjev.Enabled = false;

                txtNazivAviokompanije.Visible = false;
                txtOIBaviokompanije.Visible = false;
                txtIBAN.Visible = false;
                txtAdresaAviokompanije.Visible = false;
                txtTelefonAviokompanije.Visible = false;
                txtEmailAviokompanije.Visible = false;
                label10.Visible = false;
                label9.Visible = false;
                label8.Visible = false;
                label7.Visible = false;
                label6.Visible = false;
                label5.Visible = false;
                label4.Visible = false;
                btnPrihvatiZahtjev.Visible = false;
                btnOdbijZahtjev.Visible = false;
            }
            else
            {
                txtIme.Text = selektiraniZahtjev.Korisnik.ImeKorisnika.ToString();
                txtPrezime.Text = selektiraniZahtjev.Korisnik.PrezimeKorisnika.ToString();
                txtEmail.Text = selektiraniZahtjev.Korisnik.EmailKorisnika.ToString();
                txtAdresa.Text = selektiraniZahtjev.Korisnik.AdresaKorisnika.ToString();
                txtKontakt.Text = selektiraniZahtjev.Korisnik.KontaktTelefonKorisnika.ToString();
                txtOib.Text = selektiraniZahtjev.Korisnik.OIBKorisnika.ToString();
                textBoxZahtjev.Text = selektiraniZahtjev.TekstZahtjeva.ToString();

                txtIme.Enabled = false;
                txtPrezime.Enabled = false;
                txtEmail.Enabled = false;
                txtAdresa.Enabled = false;
                txtKontakt.Enabled = false;
                txtOib.Enabled = false;
                textBoxZahtjev.Enabled = false;

                Aviokompanija aviokompanija = RepozitorijSkyFlyReservation.DohvatiAviokompaniju(selektiraniZahtjev.Korisnik.KorisnikId);

                txtNazivAviokompanije.Text = aviokompanija.NazivAviokompanije;
                txtOIBaviokompanije.Text = aviokompanija.OIBAviokompanije;
                txtIBAN.Text = aviokompanija.IBANAviokompanije;
                txtAdresaAviokompanije.Text = aviokompanija.AdresaAviokompanije;
                txtTelefonAviokompanije.Text = aviokompanija.KontaktAviokompanije;
                txtEmailAviokompanije.Text = aviokompanija.EmailAviokompanije;

                txtNazivAviokompanije.Enabled = false;
                txtOIBaviokompanije.Enabled = false;
                txtIBAN.Enabled = false;
                txtAdresaAviokompanije.Enabled = false;
                txtTelefonAviokompanije.Enabled = false;
                txtEmailAviokompanije.Enabled = false;
            }
           

        }

        private void btnPrihvatiZahtjev_Click(object sender, EventArgs e)
        {
            RepozitorijSkyFlyReservation.DodajUloguAdministratora(selektiraniZahtjev.Korisnik.KorisnikId);
            RepozitorijSkyFlyReservation.ZahtjevPrihvacen(selektiraniZahtjev.ZahtjevId);
            RepozitorijSkyFlyReservation.Obavijest(selektiraniZahtjev.Korisnik.EmailKorisnika);
            Close();
        }

        private void btnOdbijZahtjev_Click(object sender, EventArgs e)
        {
            Aviokompanija aviokompanija = RepozitorijSkyFlyReservation.DohvatiAviokompaniju(selektiraniZahtjev.Korisnik.KorisnikId);
            RepozitorijSkyFlyReservation.DodajUloguRegistriranogKorisnika(selektiraniZahtjev.Korisnik.KorisnikId);
            RepozitorijSkyFlyReservation.ZahtjevOdbijen(selektiraniZahtjev.ZahtjevId);
            RepozitorijSkyFlyReservation.ObrisiAviokompaniju(aviokompanija.AviokompanijaId); 
            Close();
        }

        private void FormDetaljiZahtjeva_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();
                controler.OtvoriUserHelp(this, "DetaljiZahtjeva.htm");
            }
        }
    }
}
