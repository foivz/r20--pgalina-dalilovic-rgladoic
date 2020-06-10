using Database_Access;
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
    public partial class FormPregledLetova : Form
    {
        public FormPregledLetova()
        {
            InitializeComponent();
        }

        
        private void FormPregledLetova_Load(object sender, EventArgs e)
        {
            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
            OsvjeziComboBox(RepozitorijSkyFlyReservation.DohvatiAerodrome());
            OsvjeziKomponente();
        }

        private void OsvjeziKomponente()
        {
            if(RepozitorijSkyFlyReservation.prijavljeniKorisnik.UlogaKorisnika == UlogaKorisnika.RegistriraniKorisnik)
            {
                dodajLetButton.Visible = false;
                azurirajLetButton.Visible = false;
                obrisiLetButton.Visible = false;
            }
        }

        private void OsvjeziDGV(List<Let> letovi)
        {
            popisLetovaDataGridView.DataSource = null;
            popisLetovaDataGridView.DataSource = letovi;

            popisLetovaDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            popisLetovaDataGridView.Columns[1].HeaderText = "Broj leta";
            popisLetovaDataGridView.Columns[2].HeaderText = "Polazišni aerodrom";
            popisLetovaDataGridView.Columns[3].HeaderText = "Odredišni aerodrom";
            popisLetovaDataGridView.Columns[4].HeaderText = "Datum polaska";
            popisLetovaDataGridView.Columns[5].HeaderText = "Datum dolaska";
            popisLetovaDataGridView.Columns[6].HeaderText = "Avion";
            popisLetovaDataGridView.Columns[7].HeaderText = "Cijena karte";
            popisLetovaDataGridView.Columns[8].HeaderText = "Broj slobodnih mjesta";

            popisLetovaDataGridView.Columns[0].Visible = false;
            popisLetovaDataGridView.Columns[6].Visible = false;
            popisLetovaDataGridView.Columns[7].Visible = false;
            popisLetovaDataGridView.Columns[8].Visible = false;
        }

        private void OsvjeziComboBox(List<Aerodrom> aerodromi)
        {
            polazisniAerodromComboBox.DataSource = aerodromi.ToList();
            odredisniAerodromComboBox.DataSource = aerodromi.ToList();
        }

        private void pretraziLetoveButton_Click(object sender, EventArgs e)
        {
            Aerodrom odabraniPolazisniAerodrom = polazisniAerodromComboBox.SelectedItem as Aerodrom;
            Aerodrom odabraniOdredisniAerodrom = odredisniAerodromComboBox.SelectedItem as Aerodrom;
            DateTime datumVrijemePolaska = datumPolaskaDateTimePicker.Value;

            if(odabraniPolazisniAerodrom.AerodromId == odabraniOdredisniAerodrom.AerodromId)
            {
                MessageBox.Show("Polazišni i odredišni aerodrom ne smiju biti isti.");
                return;
            }

            if(pretraziPremaDatumuCheckBox.Checked == true)
            {
                if (datumVrijemePolaska.Date < DateTime.Now.Date)
                {
                    DateTime datum = DateTime.Now;
                    MessageBox.Show($"Datum polaska ne može biti manji od datuma {datum.ToString("dd/MM/yyyy")}.");
                    return;
                }

                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove(odabraniPolazisniAerodrom, odabraniOdredisniAerodrom, datumVrijemePolaska.ToString("yyyy-MM-dd")));
            }
            else
            {
                OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove(odabraniPolazisniAerodrom, odabraniOdredisniAerodrom));
            }
            
        }

        private void detaljiLetaButton_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            if(selektiraniLet == null)
            {
                MessageBox.Show("Niste odabrali let za koji želite pogledati detalje.");
                return;
            }

            FormDetaljiLeta form = new FormDetaljiLeta(selektiraniLet);
            form.ShowDialog();
        }

        private void rezervirajKartuButton_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            if(selektiraniLet == null)
            {
                MessageBox.Show("Niste odabrali let za koji želite rezervirati kartu.");
                return;
            }

            FormRezervacijaKarte form = new FormRezervacijaKarte(selektiraniLet);
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
        }

        private Let DohvatiSelektiraniLet()
        {
            if(popisLetovaDataGridView.CurrentRow != null)
            {
                return popisLetovaDataGridView.CurrentRow.DataBoundItem as Let;
            }

            return null;
        }

        //SAMO ZA PRISTUP FORMU! MAKNUTI U KONAČNOJ IMPLEMENTACIJI
        private void pregledRezervacijaButton_Click(object sender, EventArgs e)
        {
            FormPregledRezervacija form = new FormPregledRezervacija();
            form.ShowDialog();
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            if (selektiraniLet == null)
            {
                MessageBox.Show("Niste odabrali let za koji želite kupiti kartu.");
                return;
            }

            FormRezervacijaKarte form = new FormRezervacijaKarte(selektiraniLet);
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
        }

        private void dodajLetButton_Click(object sender, EventArgs e)
        {
            FormDodajLet form = new FormDodajLet();
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
            OsvjeziComboBox(RepozitorijSkyFlyReservation.DohvatiAerodrome());
        }

        private void prikaziSveButton_Click(object sender, EventArgs e)
        {
            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
            OsvjeziComboBox(RepozitorijSkyFlyReservation.DohvatiAerodrome());
        }

        private void buttonAvioniAviokompanije_Click(object sender, EventArgs e)
        {
            FormPregledAvionaAviokompanije form = new FormPregledAvionaAviokompanije();
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
        }

        private void azurirajLetButton_Click(object sender, EventArgs e)
        {
            FormAzurirajLet form = new FormAzurirajLet();
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
        }

        private void obrisiLetButton_Click(object sender, EventArgs e)
        {
            FormObrisiLet form = new FormObrisiLet();
            form.ShowDialog();

            OsvjeziDGV(RepozitorijSkyFlyReservation.DohvatiLetove());
        }
    }
}
