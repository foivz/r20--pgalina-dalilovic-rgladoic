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
            RepozitorijSkyFlyReservation.Inicijaliziraj();
            OsvjeziComboBox();
            OsvjeziPopisLetova();
        }

        private void OsvjeziComboBox()
        {
            List<string> popisAerodroma = new List<string>();

            foreach (Aerodrom aerodrom in RepozitorijSkyFlyReservation.Aerodromi)
            {
                popisAerodroma.Add(aerodrom.NazivAerodroma);
            }

            polazisniAerodromComboBox.DataSource = popisAerodroma.ToList();
            odredisniAerodromComboBox.DataSource = popisAerodroma.ToList();
        }

        private void OsvjeziPopisLetova()
        {
            List<Let> popisLetova = new List<Let>();

            foreach (Aerodrom aerodrom in RepozitorijSkyFlyReservation.Aerodromi)
            {
                foreach (Let let in aerodrom.LetoviAerodroma)
                {
                    if(!popisLetova.Contains(let))
                    {
                        popisLetova.Add(let);
                    }
                }
            }

            popisLetovaDataGridView.DataSource = null;
            popisLetovaDataGridView.DataSource = popisLetova;

            popisLetovaDataGridView.Columns[0].HeaderText = "Broj leta";
            popisLetovaDataGridView.Columns[1].HeaderText = "Polazišni aerodrom";
            popisLetovaDataGridView.Columns[2].HeaderText = "Odredišni aerodrom";
            popisLetovaDataGridView.Columns[3].HeaderText = "Datum polaska";
            popisLetovaDataGridView.Columns[4].HeaderText = "Datum dolaska";
            popisLetovaDataGridView.Columns[5].HeaderText = "Cijena karte";
            popisLetovaDataGridView.Columns[6].HeaderText = "Valuta";
            popisLetovaDataGridView.Columns[7].HeaderText = "Broj slobodnih mjesta";
            
        }

        private void pretraziLetoveButton_Click(object sender, EventArgs e)
        {
            Aerodrom odabraniPolazisni = RepozitorijSkyFlyReservation.DohvatiSelektiraniAerodrom(polazisniAerodromComboBox.SelectedItem.ToString());
            Aerodrom odabraniOdredisni = RepozitorijSkyFlyReservation.DohvatiSelektiraniAerodrom(odredisniAerodromComboBox.SelectedItem.ToString());
            DateTime odabraniDatumPolaska = datumPolaskaDateTimePicker.Value;

            if(odabraniPolazisni == odabraniOdredisni)
            {
                MessageBox.Show("Polazišni i odredišni aerodrom ne smiju biti isti.");
                OsvjeziPopisLetova();
            }
            else if(odabraniDatumPolaska.Date < DateTime.Now.Date)
            {
                DateTime datum = DateTime.Now;
                MessageBox.Show($"Datum polaska ne može biti manji od datuma {datum.ToString("dd/MM/yyyy")}.");
                OsvjeziPopisLetova();
            }
            else
            {
                FiltirajPopisLetova(odabraniPolazisni, odabraniOdredisni, odabraniDatumPolaska);
            }
        }

        private void FiltirajPopisLetova(Aerodrom polazisni, Aerodrom odredisni, DateTime datum)
        {
            List<Let> filtriraniPopisLetova = new List<Let>();

            foreach (Aerodrom aerodrom in RepozitorijSkyFlyReservation.Aerodromi)
            {
                foreach (Let let in aerodrom.LetoviAerodroma)
                {
                    if (let.NazivPolazisnogAerodroma == polazisni.NazivAerodroma && let.NazivOdredisnogAerodroma == odredisni.NazivAerodroma && let.DatumPolaska.Date == datum.Date && !filtriraniPopisLetova.Contains(let))
                    {
                        filtriraniPopisLetova.Add(let);
                    }
                }
            }

            popisLetovaDataGridView.DataSource = null;
            popisLetovaDataGridView.DataSource = filtriraniPopisLetova;
            popisLetovaDataGridView.Columns[0].HeaderText = "Broj leta";
            popisLetovaDataGridView.Columns[1].HeaderText = "Polazišni aerodrom";
            popisLetovaDataGridView.Columns[2].HeaderText = "Odredišni aerodrom";
            popisLetovaDataGridView.Columns[3].HeaderText = "Datum polaska";
            popisLetovaDataGridView.Columns[4].HeaderText = "Datum dolaska";
            popisLetovaDataGridView.Columns[5].HeaderText = "Cijena karte";
            popisLetovaDataGridView.Columns[6].HeaderText = "Valuta";
            popisLetovaDataGridView.Columns[7].HeaderText = "Broj slobodnih mjesta";
        }

        private void detaljiLetaButton_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            FormDetaljiLeta form = new FormDetaljiLeta(selektiraniLet);
            form.ShowDialog();
        }

        private void rezervirajKartuButton_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            FormRezervacijaKarte form = new FormRezervacijaKarte(selektiraniLet, RepozitorijSkyFlyReservation.initPutnik);
            form.ShowDialog();
            OsvjeziComboBox();
            OsvjeziPopisLetova();
        }

        private Let DohvatiSelektiraniLet()
        {
            Let selektiraniLet = null;

            if (popisLetovaDataGridView.CurrentRow.DataBoundItem != null)
            {
                selektiraniLet = popisLetovaDataGridView.CurrentRow.DataBoundItem as Let;
            }

            return selektiraniLet;
        }

        //SAMO ZA PRISTUP FORMU! MAKNUTI U KONAČNOJ IMPLEMENTACIJI
        private void pregledRezervacijaButton_Click(object sender, EventArgs e)
        {
            FormPregledRezervacija form = new FormPregledRezervacija(RepozitorijSkyFlyReservation.initPutnik);
            form.ShowDialog();
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            FormKupnjaKarte form = new FormKupnjaKarte(selektiraniLet, RepozitorijSkyFlyReservation.initPutnik);
            form.ShowDialog();
            OsvjeziComboBox();
            OsvjeziPopisLetova();
        }

        private void dodajLetButton_Click(object sender, EventArgs e)
        {
            FormDodajLet form = new FormDodajLet();
            form.ShowDialog();
            OsvjeziComboBox();
            OsvjeziPopisLetova();
        }

        private void obrisiLet_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();

            if(selektiraniLet.DohvatiAvion().Aviokompanija == RepozitorijSkyFlyReservation.initPutnik.Aviokompanija)
            {
                FormObrisiLet form = new FormObrisiLet(selektiraniLet);
                form.ShowDialog();
                OsvjeziComboBox();
                OsvjeziPopisLetova();
            }
            else
            {
                MessageBox.Show("Ne možete obrisati let koji ne pripada vašoj aviokompaniji.");
            }

            OsvjeziPopisLetova();
        }

        private void azurirajLet_Click(object sender, EventArgs e)
        {
            Let selektiraniLet = DohvatiSelektiraniLet();
            Avion avion = selektiraniLet.DohvatiAvion();

            if (avion.Aviokompanija == RepozitorijSkyFlyReservation.initPutnik.Aviokompanija)
            {
                FormAzurirajLet form = new FormAzurirajLet(selektiraniLet);
                form.ShowDialog();
                OsvjeziComboBox();
                OsvjeziPopisLetova();
            }
            else
            {
                MessageBox.Show("Ne možete ažurirati let koji ne pripada vašoj aviokompaniji.");
            }

            OsvjeziPopisLetova();
        }
    }
}
