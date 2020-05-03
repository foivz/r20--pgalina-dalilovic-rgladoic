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
    public partial class FormObrisiLet : Form
    {
        private Let selektiraniLet;
        public FormObrisiLet(Let selektirani)
        {
            selektiraniLet = selektirani;
            InitializeComponent();
        }

        private void obrisiLetButton_Click(object sender, EventArgs e)
        {
            Aerodrom polazisni = selektiraniLet.DohvatiPolazisniAerodrom();
            Aerodrom odredisni = selektiraniLet.DohvatiOdredisniAerodrom();
            Aviokompanija aviokompanija = selektiraniLet.DohvatiAvion().Aviokompanija;

            polazisni.ObrisiLet(selektiraniLet);
            odredisni.ObrisiLet(selektiraniLet);
            aviokompanija.ObrisiLet(selektiraniLet);

            MessageBox.Show($"Uspješno ste obrisali let {selektiraniLet.NazivPolazisnogAerodroma}->{selektiraniLet.NazivOdredisnogAerodroma}.");
            this.Close();
        }

        private void FormObrisiLet_Load(object sender, EventArgs e)
        {
            OsvjeziDetalje();

        }

        private void OsvjeziDetalje()
        {
            oznakaOdabranogLetaLabel.Text = selektiraniLet.BrojLeta;
            odabraniPolazisniTextBox.Text = selektiraniLet.NazivPolazisnogAerodroma;
            odabraniOdredisniTextBox.Text = selektiraniLet.NazivOdredisnogAerodroma;
            avionNaLetuTextBox.Text = selektiraniLet.DohvatiAvion().ProizvodacAviona + " " + selektiraniLet.DohvatiAvion().TipAviona;
            vrijemePolaskaTextBox.Text = selektiraniLet.DatumPolaska.ToString();
            vrijemeDolaskaTextBox.Text = selektiraniLet.DatumDolaska.ToString();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
