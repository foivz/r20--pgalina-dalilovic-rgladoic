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

namespace SkyFlyReservation
{
    public partial class FormPregledRezervacija : Form
    {
        public FormPregledRezervacija()
        {
            InitializeComponent();
        }

        private void platiRezervacijuButton_Click(object sender, EventArgs e)
        {
            Rezervacija selektiranaRezervacija = DohvatiOdabranuRezervaciju();

            if(selektiranaRezervacija == null)
            {
                MessageBox.Show("Niste odabrali rezervaciju koju želite platiti.");
                return;
            }
            else
            {
                if(selektiranaRezervacija.StatusRezervacije == StanjeRezervacije.Istekla)
                {
                    MessageBox.Show("Odabrana rezervacija je istekla.");
                    return;
                }
                else if(selektiranaRezervacija.StatusRezervacije == StanjeRezervacije.Plaćena)
                {
                    MessageBox.Show("Odabrana rezervacija je plaćena.");
                    return;
                }
                else
                {
                    FormPlatiRezervaciju form = new FormPlatiRezervaciju(selektiranaRezervacija);
                    form.ShowDialog();

                    OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiRezervacijeKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId));
                }   
            }
        }

        private Rezervacija DohvatiOdabranuRezervaciju()
        {
            if(popisRezervacijaDataGridView.CurrentRow != null)
            {
                return popisRezervacijaDataGridView.CurrentRow.DataBoundItem as Rezervacija;
            }

            return null;
        }

        private void FormPregledRezervacija_Load(object sender, EventArgs e)
        {
            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiRezervacijeKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId));
            prikaziSveRadio.Checked = true;
        }

        private void OsvjeziDGV(List<Rezervacija> rezervacijeKorisnika)
        {
            popisRezervacijaDataGridView.DataSource = null;
            popisRezervacijaDataGridView.DataSource = rezervacijeKorisnika;

            popisRezervacijaDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            popisRezervacijaDataGridView.ReadOnly = true;

            popisRezervacijaDataGridView.Columns[1].HeaderText = "Broj leta";
            popisRezervacijaDataGridView.Columns[2].HeaderText = "Polaziši aerodrom";
            popisRezervacijaDataGridView.Columns[3].HeaderText = "Odredišni aerodrom";
            popisRezervacijaDataGridView.Columns[5].HeaderText = "Rezervirano sjedalo";
            popisRezervacijaDataGridView.Columns[6].HeaderText = "Datum i vrijeme rezervacije";
            popisRezervacijaDataGridView.Columns[7].HeaderText = "Status rezervacije";

            popisRezervacijaDataGridView.Columns[0].Visible = false;
            popisRezervacijaDataGridView.Columns[4].Visible = false;

        }

        private void filtrirajPopisRezervacijaButton_Click(object sender, EventArgs e)
        {
            if(placeneRezervacijeRadio.Checked == true)
            {
                List<Rezervacija> rezervacije = RepozitorijSkyFlyReservation.DohvatiRezervacijeKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId);

                OsvjeziDGV(rezervacije.Where(r => r.StatusRezervacije == StanjeRezervacije.Plaćena).ToList());
            }
            else if(istekleRezervacijeRadio.Checked == true)
            {
                List<Rezervacija> rezervacije = RepozitorijSkyFlyReservation.DohvatiRezervacijeKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId);

                OsvjeziDGV(rezervacije.Where(r => r.StatusRezervacije == StanjeRezervacije.Istekla).ToList());
            }
            else if(nisuPlaceneRezervacijeRadio.Checked == true)
            {
                List<Rezervacija> rezervacije = RepozitorijSkyFlyReservation.DohvatiRezervacijeKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId);

                OsvjeziDGV(rezervacije.Where(r => r.StatusRezervacije == StanjeRezervacije.Neplaćena).ToList());
            }
            else if(prikaziSveRadio.Checked == true)
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiRezervacijeKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId));
            }
        }

        private void obrisiRezervacijuButton_Click(object sender, EventArgs e)
        {
            Rezervacija selektiranaRezervacija = DohvatiOdabranuRezervaciju();

            if(selektiranaRezervacija == null)
            {
                MessageBox.Show("Niste odabrali rezervaciju koju želite obrisati.");
                return;
            }
            else
            {
                int numAffectedRows = RepozitorijSkyFlyReservation.ObrisiRezervacijuKarte(selektiranaRezervacija);

                if(numAffectedRows > 0)
                {
                    MessageBox.Show($"Obrisali ste rezervaciju sjedala {selektiranaRezervacija.RezerviranoSjedalo.OznakaSjedala} na letu {selektiranaRezervacija.LetRezervacije.PolazisniAerodrom.NazivAerodroma}->{selektiranaRezervacija.LetRezervacije.OdredisniAerodrom.NazivAerodroma}.");
                    OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiRezervacijeKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId));
                }
            }
        }

        private void FormPregledRezervacija_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, "PregledRezervacija.htm");
            }
        }
    }
}
