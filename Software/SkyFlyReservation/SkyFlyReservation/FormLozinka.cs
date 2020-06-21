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
using UserHelpControler;

namespace SkyFlyReservation
{
    public partial class FormLozinka : Form
    {
        private bool seePassword1 = false;
        private bool seePassword2 = false;
        public FormLozinka()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void btnNatrag_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrirajSe_Click(object sender, EventArgs e)
        {
            if(txtLozinka.Text != txtPonovljenaLozinka.Text)
            {
                MessageBox.Show("Lozinke se ne podudaraju!");
            }
            else if (txtLozinka.Text.Length < 8)
            {
                MessageBox.Show("Lozinka mora biti minimalno 8 znakova!");
            }
            else
            {
                RepozitorijSkyFlyReservation.prijavljeniKorisnik.LozinkaKorisnika = txtLozinka.Text;
                this.Close();
            }
        }

        private void FormLozinka_Load(object sender, EventArgs e)
        {
            txtLozinka.PasswordChar = '•';
            txtPonovljenaLozinka.PasswordChar = '•';
        }

        private void btnSeePassword1_Click(object sender, EventArgs e)
        {
            if (seePassword1)
            {
                txtLozinka.PasswordChar = '•';
                seePassword1 = false;
            }
            else
            {
                txtLozinka.PasswordChar = '\0';
                seePassword1 = true;
            }
        }

        private void btnSeePassword2_Click(object sender, EventArgs e)
        {
            if (seePassword2)
            {
                txtPonovljenaLozinka.PasswordChar = '•';
                seePassword2 = false;
            }
            else
            {
                txtPonovljenaLozinka.PasswordChar = '\0';
                seePassword2 = true;
            }

        }

        private void FormLozinka_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();

                controler.OtvoriUserHelp(this, "PromjenaLozinke.htm");
            }
        }
    }
}
