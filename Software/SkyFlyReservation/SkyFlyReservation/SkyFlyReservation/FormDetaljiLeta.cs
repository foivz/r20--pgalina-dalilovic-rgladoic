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
    public partial class FormDetaljiLeta : Form
    {
        private Let selektiraniLet;
        public FormDetaljiLeta(Let odabraniLet)
        {
            InitializeComponent();
            selektiraniLet = odabraniLet;
        }

        private void zatvoriButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormDetaljiLeta_Load(object sender, EventArgs e)
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
            cijenaKarteTextBox.Text = selektiraniLet.CijenaKarte.ToString() + " " + selektiraniLet.OznakaValute;
        }
    }
}
