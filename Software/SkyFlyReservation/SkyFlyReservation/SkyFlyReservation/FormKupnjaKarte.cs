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
    public partial class FormKupnjaKarte : Form
    {
        private Let odabraniLet;
        private Korisnik odabraniPutnik;
        //private Control _focusedSjedalo;
        public FormKupnjaKarte(Let selektiraniLet, Korisnik putnik)
        {
            odabraniLet = selektiraniLet;
            odabraniPutnik = putnik;
            InitializeComponent();
        }

        private void FormKupnjaKarte_Load(object sender, EventArgs e)
        {
            OsvjeziDetalje();
        }

        private void OsvjeziDetalje()
        {
            oznakaOdabranogLetaLabel.Text = odabraniLet.BrojLeta;
            odabraniPolazisniTextBox.Text = odabraniLet.NazivPolazisnogAerodroma;
            odabraniOdredisniTextBox.Text = odabraniLet.NazivOdredisnogAerodroma;
            avionNaLetuTextBox.Text = odabraniLet.DohvatiAvion().ProizvodacAviona + " " + odabraniLet.DohvatiAvion().TipAviona;
            vrijemePolaskaTextBox.Text = odabraniLet.DatumPolaska.ToString();
            vrijemeDolaskaTextBox.Text = odabraniLet.DatumDolaska.ToString();
            cijenaKarteTextBox.Text = odabraniLet.CijenaKarte.ToString() + " " + odabraniLet.OznakaValute;

            Avion avion = odabraniLet.DohvatiAvion();

            foreach (Sjedalo sjedalo in avion.SjedalaUAvionu)
            {
                foreach (TextBox textBox in sjedalaUAvionuPanel.Controls)
                {
                    if (sjedalo.OznakaSjedala == textBox.Name)
                    {
                        if (sjedalo.StatusSjedala == StanjeSjedala.Slobodno)
                        {
                            textBox.BackColor = Color.Green;
                            textBox.Text = sjedalo.OznakaSjedala.ToString();
                        }
                        else if (sjedalo.StatusSjedala == StanjeSjedala.Zauzeto)
                        {
                            textBox.BackColor = Color.Red;
                            textBox.Text = sjedalo.OznakaSjedala.ToString();
                        }
                    }
                }
            }
        }

        private void kupiKartuButton_Click(object sender, EventArgs e)
        {
            //Koristi se za testiranje
            Sjedalo initSjedalo = odabraniLet.DohvatiAvion().DohvatiSjedalo("A5");


            Sjedalo sjedalo = DohvatiSjedalo();

            /* Koriste se za kupnju kada uspijemo dohvatiti odabrano sjedalo unutar panela
            if(sjedalo.StatusSjedala == StanjeSjedala.Zauzeto)
            {
                MessageBox.Show($"Sjedalo s oznakom {sjedalo.OznakaSjedala} je zauzeto.");
            }
            else
            {
                FormPlatiKartu form = new FormPlatiKartu(odabraniLet, initSjedalo, odabraniPutnik);
                form.ShowDialog();
                this.Close();   
            }*/

            //Maknuti kad se uspije dohvatiti sjedalo koje je odabrano unutar panela
            FormPlatiKartu form = new FormPlatiKartu(odabraniLet, initSjedalo, odabraniPutnik);
            form.ShowDialog();
            this.Close();
        }

        private Sjedalo DohvatiSjedalo()
        {
            Sjedalo sjedalo = null;

            foreach (Control textBox in sjedalaUAvionuPanel.Controls)
            {
                if (textBox.ContainsFocus) // dodati da dohvaća sjedalo koje je fokusirano
                {
                    Avion avion = odabraniLet.DohvatiAvion();

                    sjedalo = avion.DohvatiSjedalo(textBox.Text);
                }
            }

            return sjedalo;
        }
    }
}
