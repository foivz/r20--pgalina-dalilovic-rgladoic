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
    public partial class FormPregledKorisnickihRacuna : Form
    {
        public FormPregledKorisnickihRacuna()
        {
            this.KeyPreview = true;
            InitializeComponent();
        }

        private void FormPregledKorisnickihRacuna_Load(object sender, EventArgs e)
        {
            List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiKorisnickeRacune(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId);
            OsvjeziDGV(korisnici);
            prikazSvihRadio.Checked = true;
        }

        private void OsvjeziDGV(List<Korisnik> korisnici)
        {
            dgvKorisnickiRacuni.DataSource = null;
            dgvKorisnickiRacuni.DataSource = korisnici;

            dgvKorisnickiRacuni.Columns[1].HeaderText = "Ime korisnika";
            dgvKorisnickiRacuni.Columns[2].HeaderText = "Prezime korisnika";
            dgvKorisnickiRacuni.Columns[3].HeaderText = "OIB korisnika";
            dgvKorisnickiRacuni.Columns[4].HeaderText = "Adresa korisnika";
            dgvKorisnickiRacuni.Columns[5].HeaderText = "Kontakt telefon";
            dgvKorisnickiRacuni.Columns[6].HeaderText = "Email korisnika";
            dgvKorisnickiRacuni.Columns[9].HeaderText = "Uloga korisnika";


            dgvKorisnickiRacuni.Columns[0].Visible = false;
            dgvKorisnickiRacuni.Columns[7].Visible = false;
            dgvKorisnickiRacuni.Columns[8].Visible = false;
        }

        private void filtrirajPopisRacunaButton_Click(object sender, EventArgs e)
        {
            if (moderatorRadio.Checked == true)
            {
                List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiKorisnickeRacune(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId);

                OsvjeziDGV(korisnici.Where(r => r.UlogaKorisnika == UlogaKorisnika.Moderator).ToList());
            }
            else if (registriraniRadio.Checked == true)
            {
                List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiKorisnickeRacune(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId);

                OsvjeziDGV(korisnici.Where(r => r.UlogaKorisnika == UlogaKorisnika.RegistriraniKorisnik).ToList());
            }
            else if (prikazSvihRadio.Checked == true)
            {
                List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiKorisnickeRacune(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId);

                OsvjeziDGV(korisnici.ToList());
            }
        }

        private Korisnik DohvatiOdabraniKorisnickiRacun()
        {
            if (dgvKorisnickiRacuni.CurrentRow != null)
            {
                return dgvKorisnickiRacuni.CurrentRow.DataBoundItem as Korisnik;
            }

            return null;
        }

        private void dodijeliUloguModeratoraButton_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = DohvatiOdabraniKorisnickiRacun();

            if (odabraniKorisnik == null)
            {
                MessageBox.Show("Niste odabrali korisnika kojem želite dodijeliti ulogu moderatora.");
                return;
            }


            int numAffectedRows = RepozitorijSkyFlyReservation.DodajUloguModeratora(odabraniKorisnik.KorisnikId, RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija);

            if (numAffectedRows > 0)
            {
                MessageBox.Show("Korisniku je dodana uloga moderatora. ");

            }

            List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiKorisnickeRacune(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId);
            OsvjeziDGV(korisnici);
        }

        private void dodijeliUloguRegistriranogKorisnikaButton_Click(object sender, EventArgs e)
        {
            Korisnik odabraniKorisnik = DohvatiOdabraniKorisnickiRacun();

            if (odabraniKorisnik == null)
            {
                MessageBox.Show("Niste odabrali korisnika kojem želite dodijeliti ulogu registriranog korisnika.");
                return;
            }
         

            int numAffectedRows = RepozitorijSkyFlyReservation.DodajUloguRegistriranogKorisnika(odabraniKorisnik.KorisnikId);
            
            if (numAffectedRows > 0 )
            {
                MessageBox.Show("Korisniku je dodana uloga registriranog korisnika. ");
                
            }

            List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiKorisnickeRacune(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId);
            OsvjeziDGV(korisnici);  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            List<Korisnik> korisnici = RepozitorijSkyFlyReservation.DohvatiKorisnickeRacune(RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId);

                string text = txtPretrazi.Text;
                var query = from k in korisnici
                            where k.ImeKorisnika.Contains(text) || k.PrezimeKorisnika.Contains(text)
                            select k;

                dgvKorisnickiRacuni.DataSource = query.ToList();
            

        }

        private void FormPregledKorisnickihRacuna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();
                controler.OtvoriUserHelp(this, "PregledKorisnickihRacuna.htm");
            }
        }
    }
}
