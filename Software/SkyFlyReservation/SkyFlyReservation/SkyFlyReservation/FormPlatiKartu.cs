using System;
using System.Net;
using System.Net.Mail;
using SkyFlyReservation.Class;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;

namespace SkyFlyReservation
{
    public partial class FormPlatiKartu : Form
    {
        private Sjedalo selektiranoSjedalo;
        private Let selektiraniLet;
        public FormPlatiKartu(Let let, Sjedalo sjedalo)
        {
            selektiranoSjedalo = sjedalo;
            selektiraniLet = let;
            InitializeComponent();
        }

        private void FormPlatiKartu_Load(object sender, EventArgs e)
        {
            oznakaLetaLabel.Text = selektiraniLet.BrojLeta;
            oznakaOdabranogSjedalaLabel.Text = selektiranoSjedalo.OznakaSjedala;

        }

        private void platiKartuButton_Click(object sender, EventArgs e)
        {

            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;
            string oib = oibTextBox.Text;
            string brojKartice = brojKarticeTextBox.Text;

            bool provjeraPodataka = ProvjeriPodatke(ime, prezime, oib, brojKartice);

            if(provjeraPodataka == true)
            {
                int numAffectedRowsInsert = RepozitorijSkyFlyReservation.DodajKupnjuKarte(selektiraniLet, selektiranoSjedalo, RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId);
                int numAffectedRowsUpdate = RepozitorijSkyFlyReservation.AzurirajBrojSlobodnihMjesta(selektiraniLet);

                if (numAffectedRowsInsert > 0 && numAffectedRowsUpdate > 0)
                {
                    MessageBox.Show($"Uspješno ste kupili kartu za sjedalo {selektiranoSjedalo.OznakaSjedala} na letu {selektiraniLet.PolazisniAerodrom.NazivAerodroma}->{selektiraniLet.OdredisniAerodrom.NazivAerodroma}.\n\nNa Vašu e-mail adresu poslani su detalji o kupljenoj karti.");
                    PošaljiKartu(selektiraniLet, selektiranoSjedalo);
                    this.Close();
                }
            }
        }

        private bool ProvjeriPodatke(string ime, string prezime, string oib, string brojKartice)
        {
            if(ime == "")
            {
                MessageBox.Show("Niste unijeli ime.");
                return false;
            }
            if(prezime == "")
            {
                MessageBox.Show("Niste unijeli prezime.");
                return false;
            }
            if(oib == "")
            {
                MessageBox.Show("Niste unijeli OIB.");
                return false;
            }
            if(brojKartice == "")
            {
                MessageBox.Show("Niste unijeli broj kartice.");
                return false;
            }

            return true;
        }

        private void PošaljiKartu(Let let, Sjedalo sjedalo)
        {
            string rezervacijaId = RepozitorijSkyFlyReservation.DohvatiIdRezervacije(let, sjedalo).ToString();

            MemoryStream strmQR = new MemoryStream();
            MemoryStream strmTem = new MemoryStream();

            Zen.Barcode.CodeQrBarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            System.Drawing.Image QRCode = barcode.Draw(rezervacijaId, 50);
            QRCode.Save(strmQR, System.Drawing.Imaging.ImageFormat.Png);

            XImage QRImage = XImage.FromStream(strmQR);

            Image template = Image.FromFile("BoardingPassTemplate.png");
            template.Save(strmTem, System.Drawing.Imaging.ImageFormat.Png);

            XImage Template = XImage.FromStream(strmTem);

            PdfDocument pdf = new PdfDocument();
            PdfPage pdfPage = pdf.AddPage();
            XGraphics graph = XGraphics.FromPdfPage(pdfPage);
            graph.DrawImage(Template, 5, 5, 585, 225);
            graph.DrawImage(QRImage, 345, 50, 75, 75);

            XFont font = new XFont("Verdana", 8, XFontStyle.Bold);

            graph.DrawString($"{RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika} {RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika}", font, XBrushes.Black, new XRect(25, 72, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.PolazisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(25, 110, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.OdredisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(25, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.AvionNaLetu.Aviokompanija.NazivAviokompanije}", font, XBrushes.Black, new XRect(182, 110, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.DatumPolaska.Date.ToString("dd MMMM")}", font, XBrushes.Black, new XRect(182, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.DatumPolaska.ToString("HH:mm")}", font, XBrushes.Black, new XRect(282, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            graph.DrawString($"{RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika} {RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika}", font, XBrushes.Black, new XRect(448, 72, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.PolazisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(448, 97, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.OdredisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(448, 125, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.DatumPolaska.Date.ToString("dd MMMM")}", font, XBrushes.Black, new XRect(448, 152, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.DatumPolaska.ToString("HH:mm")}", font, XBrushes.Black, new XRect(495, 152, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            graph.DrawString($"{let.BrojLeta}", font, XBrushes.Black, new XRect(25, 190, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{sjedalo.OznakaSjedala}", font, XBrushes.Black, new XRect(104, 190, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.DatumPolaska.Add(new TimeSpan(0,-45,0)).ToString("HH:mm")}", font, XBrushes.Black, new XRect(282, 190, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{sjedalo.OznakaSjedala}", font, XBrushes.Black, new XRect(448, 182, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{let.DatumPolaska.Add(new TimeSpan(0, -45, 0)).ToString("HH:mm")}", font, XBrushes.Black, new XRect(495, 182, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            pdf.Save("karta.pdf");


            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

            client.UseDefaultCredentials = false;
            NetworkCredential cred = new NetworkCredential("skyflyreservation@gmail.com", "sj6IWP3o");

            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress("skyflyreservation@gmail.com");

            Msg.To.Add($"{RepozitorijSkyFlyReservation.prijavljeniKorisnik.EmailKorisnika}");

            Msg.Subject = "Potvrda kupnje karte";

            Msg.Body = $"Poštovani {RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika} {RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika},\n\n" +
                $"Na osnovu provedene kupnje karte za sjedalo {sjedalo.OznakaSjedala} na letu {let.BrojLeta} | {let.PolazisniAerodrom.NazivAerodroma}->{let.OdredisniAerodrom.NazivAerodroma} šaljemo Vam kartu za let.\n" +
                "Karta se nalazi u pdf-u koji ste primili u ovoj poruci.\n" +
                "Kartu koju ste primili koristite prilikom prijave na aerodromu.\n" +
                "Molimo Vas da provjeru karte izvršite najkasnije 45 min prije polaska.\n\n" +
                "S poštovanjem,\n" +
                "SkyFlyReservation";

            Msg.Attachments.Add(new Attachment(@"karta.pdf"));

            client.Credentials = cred;

            client.EnableSsl = true;

            client.Send(Msg);
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
