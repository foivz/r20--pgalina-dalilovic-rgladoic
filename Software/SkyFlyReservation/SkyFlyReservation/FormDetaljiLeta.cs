﻿using System;
using SkyFlyReservation.Class;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserHelpControler;

namespace SkyFlyReservation
{
    public partial class FormDetaljiLeta : Form
    {
        private Let selektiraniLet;
        public FormDetaljiLeta(Let let)
        {
            InitializeComponent();
            selektiraniLet = let;
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
            odabraniPolazisniTextBox.Text = selektiraniLet.PolazisniAerodrom.NazivAerodroma;
            odabraniOdredisniTextBox.Text = selektiraniLet.OdredisniAerodrom.NazivAerodroma;
            avionNaLetuTextBox.Text = selektiraniLet.AvionNaLetu.ProizvodacAviona + " " + selektiraniLet.AvionNaLetu.ModelAviona;
            vrijemePolaskaTextBox.Text = selektiraniLet.DatumPolaska.ToString();
            vrijemeDolaskaTextBox.Text = selektiraniLet.DatumDolaska.ToString();
            cijenaKarteTextBox.Text = selektiraniLet.CijenaKarte.ToString();
            brojSlobodnihMjestaTextBox.Text = selektiraniLet.BrojSlobodnihMjesta.ToString();
        }

        private void FormDetaljiLeta_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();

                controler.OtvoriUserHelp(this, "DetaljiLeta.htm");
            }
        }
    }
}
