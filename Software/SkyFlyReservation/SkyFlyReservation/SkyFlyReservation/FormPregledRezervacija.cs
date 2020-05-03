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
        private Korisnik odabraniPutnik { get; set; }
        public FormPregledRezervacija(Korisnik putnik)
        {
            odabraniPutnik = putnik;
            InitializeComponent();
        }

        private void platiRezervacijuButton_Click(object sender, EventArgs e)
        {
            Rezervacija odabranaRezervacija = DohvatiOdabranuRezervaciju();

            FormPlatiRezervaciju form = new FormPlatiRezervaciju(odabranaRezervacija);
            form.ShowDialog();

            OsvjeziPopis();
        }

        private Rezervacija DohvatiOdabranuRezervaciju()
        {
            Rezervacija selektiranaRezervacija = null;

            if(popisRezervacijaDataGridView.CurrentRow.DataBoundItem != null)
            {
                selektiranaRezervacija = popisRezervacijaDataGridView.CurrentRow.DataBoundItem as Rezervacija;
            }

            return selektiranaRezervacija;
        }

        private void FormPregledRezervacija_Load(object sender, EventArgs e)
        {
            OsvjeziPopis();
        }

        private void OsvjeziPopis()
        {
            popisRezervacijaDataGridView.DataSource = null;
            popisRezervacijaDataGridView.DataSource = odabraniPutnik.RezervacijePutnika;

            popisRezervacijaDataGridView.Columns[0].HeaderText = "Broj leta";
            popisRezervacijaDataGridView.Columns[1].HeaderText = "Ime i prezime korisnika";
            popisRezervacijaDataGridView.Columns[2].HeaderText = "Oznaka rezerviranog sjedala";
            popisRezervacijaDataGridView.Columns[3].HeaderText = "Datum rezervacije";
            popisRezervacijaDataGridView.Columns[4].HeaderText = "Status rezervacije";
        }

        private void filtrirajPopisRezervacijaButton_Click(object sender, EventArgs e)
        {
            StanjeRezervacije odabranoStanje = StanjeRezervacije.Neplaćena;

            if (placeneRezervacijeRadio.Checked)
            {
                odabranoStanje = StanjeRezervacije.Plaćena;
            }
            else if (istekleRezervacijeRadio.Checked)
            {
                odabranoStanje = StanjeRezervacije.Istekla;
            }
            else if (nisuPlaceneRezervacijeRadio.Checked)
            {
                odabranoStanje = StanjeRezervacije.Neplaćena;
            }

            FiltrirajPopisRezervacija(odabranoStanje);
        }

        private void FiltrirajPopisRezervacija(StanjeRezervacije stanje)
        {
            List<Rezervacija> filtriraniPopis = new List<Rezervacija>();

            foreach (Rezervacija r in odabraniPutnik.RezervacijePutnika)
            {
                if(r.StatusRezervacije == stanje)
                {
                    filtriraniPopis.Add(r);
                }
            }

            popisRezervacijaDataGridView.DataSource = null;
            popisRezervacijaDataGridView.DataSource = filtriraniPopis;

            popisRezervacijaDataGridView.Columns[0].HeaderText = "Broj leta";
            popisRezervacijaDataGridView.Columns[1].HeaderText = "Ime i prezime korisnika";
            popisRezervacijaDataGridView.Columns[2].HeaderText = "Oznaka rezerviranog sjedala";
            popisRezervacijaDataGridView.Columns[3].HeaderText = "Datum rezervacije";
            popisRezervacijaDataGridView.Columns[4].HeaderText = "Status rezervacije";
        }

    }
}
