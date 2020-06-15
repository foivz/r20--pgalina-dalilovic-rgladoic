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
using System.IO;
using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Net.Mail;
using System.Net;

namespace SkyFlyReservation
{
    public partial class FormPlatiRezervaciju : Form
    {
        private Rezervacija selektiranaRezervacija;
        public FormPlatiRezervaciju(Rezervacija odabrana)
        {
            InitializeComponent();
            selektiranaRezervacija = odabrana;
        }

        private void FormPlatiRezervaciju_Load(object sender, EventArgs e)
        {
            OsvjeziDetalje();
        }

        private void OsvjeziDetalje()
        {
            oznakaLetaTextBox.Text = selektiranaRezervacija.LetRezervacije.BrojLeta;
            polazisniAerodromTextBox.Text = selektiranaRezervacija.LetRezervacije.PolazisniAerodrom.NazivAerodroma;
            odredisniAerodromTextBox.Text = selektiranaRezervacija.LetRezervacije.OdredisniAerodrom.NazivAerodroma;
            oznakaSjedalaTextBox.Text = selektiranaRezervacija.RezerviranoSjedalo.OznakaSjedala;
            cijenaKarteTextBox.Text = selektiranaRezervacija.LetRezervacije.CijenaKarte.ToString();
        }

        private void odustaniButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool ProvjeriPodatke(string ime, string prezime, string oib, string brojKartice)
        {
            if (ime == "")
            {
                MessageBox.Show("Niste unijeli ime.");
                return false;
            }
            if (prezime == "")
            {
                MessageBox.Show("Niste unijeli prezime.");
                return false;
            }
            if (oib == "")
            {
                MessageBox.Show("Niste unijeli OIB.");
                return false;
            }
            if (brojKartice == "")
            {
                MessageBox.Show("Niste unijeli broj kartice.");
                return false;
            }

            return true;
        }

        private void platiRezervacijuButton_Click(object sender, EventArgs e)
        {
            string ime = imeTextBox.Text;
            string prezime = prezimeTextBox.Text;
            string oib = oibTextBox.Text;
            string brojKartice = brojKarticeTextBox.Text.Replace(" ","");

            bool provjeraPodataka = ProvjeriPodatke(ime, prezime, oib, brojKartice);

            if (provjeraPodataka == true)
            {
                bool provjeraOIB = (RepozitorijSkyFlyReservation.prijavljeniKorisnik.OIBKorisnika == oib) ? true : false;
                bool provjeraKartice = ProvjerRacun(brojKartice);
                bool provjeraStanja = ProvjeriStanje();
                Racun racun = RepozitorijSkyFlyReservation.DohvatiRacunKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId);

                if (provjeraOIB == false)
                {
                    MessageBox.Show("Unijeli ste pogrešan OIB.");
                    return;
                }
                if (provjeraKartice == false)
                {
                    MessageBox.Show("Unijeli ste pogrešan broj kartice.");
                    return;
                }
                if (provjeraStanja == false)
                {
                    MessageBox.Show($"Nedovoljan iznos na računu za provođenje transakcije.\nStanje racuna: {racun.StanjeRacuna} HRK");
                    return;
                }
                else
                {
                    int numAffectedRows = RepozitorijSkyFlyReservation.AzurirajRezervaciju(selektiranaRezervacija);
                    int numAffectedRowsUpdateStanjeRacunaPlatitelja = RepozitorijSkyFlyReservation.AzurirajStanjeRacunaPlatitelja(racun, selektiranaRezervacija.LetRezervacije);
                    int numAffectedRowsUpdateStanjeRacunaPrimatelja = RepozitorijSkyFlyReservation.AzurirajStanjeRacunaPrimatelja(selektiranaRezervacija.LetRezervacije);

                    if (numAffectedRows > 0 && numAffectedRowsUpdateStanjeRacunaPlatitelja > 0 && numAffectedRowsUpdateStanjeRacunaPrimatelja > 0)
                    {
                        MessageBox.Show($"Uspješno ste platili rezervaciju za sjedalo {selektiranaRezervacija.RezerviranoSjedalo.OznakaSjedala} na letu {selektiranaRezervacija.LetRezervacije.PolazisniAerodrom.NazivAerodroma}->{selektiranaRezervacija.LetRezervacije.OdredisniAerodrom.NazivAerodroma}.");
                        PošaljiKartu(selektiranaRezervacija);
                        this.Close();
                    }
                }
            }
        }

        private bool ProvjeriStanje()
        {
            bool provjeraStanja = false;
            Racun racun = RepozitorijSkyFlyReservation.DohvatiRacunKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId);

            if (racun.StanjeRacuna >= selektiranaRezervacija.LetRezervacije.CijenaKarte)
            {
                provjeraStanja = true;
            }

            return provjeraStanja;
        }

        private bool ProvjerRacun(string brojKartice)
        {
            bool provjeraKartice = false;
            Racun racun = RepozitorijSkyFlyReservation.DohvatiRacunKorisnika(RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId);

            if (racun.BrojRacuna == brojKartice)
            {
                provjeraKartice = true;
            }

            return provjeraKartice;
        }

        private void PošaljiKartu(Rezervacija selektiranaRezervacija)
        {
            
            MemoryStream strmQR = new MemoryStream();
            MemoryStream strmTem = new MemoryStream();

            Zen.Barcode.CodeQrBarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            System.Drawing.Image QRCode = barcode.Draw(selektiranaRezervacija.RezervacijaId.ToString(), 50);
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

            graph.DrawString($"{selektiranaRezervacija.KorisnikRezervacije.ImeKorisnika} {selektiranaRezervacija.KorisnikRezervacije.PrezimeKorisnika}", font, XBrushes.Black, new XRect(25, 72, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.PolazisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(25, 110, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.OdredisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(25, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.AvionNaLetu.Aviokompanija.NazivAviokompanije}", font, XBrushes.Black, new XRect(182, 110, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.DatumPolaska.Date.ToString("dd. MMMM")}", font, XBrushes.Black, new XRect(182, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.DatumPolaska.ToString("HH:mm")}", font, XBrushes.Black, new XRect(282, 150, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            graph.DrawString($"{selektiranaRezervacija.KorisnikRezervacije.ImeKorisnika} {selektiranaRezervacija.KorisnikRezervacije.PrezimeKorisnika}", font, XBrushes.Black, new XRect(448, 72, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.PolazisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(448, 97, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.OdredisniAerodrom.NazivAerodroma}", font, XBrushes.Black, new XRect(448, 125, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.DatumPolaska.Date.ToString("dd.MM")}", font, XBrushes.Black, new XRect(448, 152, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.DatumPolaska.ToString("HH:mm")}", font, XBrushes.Black, new XRect(495, 152, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.BrojLeta}", font, XBrushes.Black, new XRect(25, 190, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.RezerviranoSjedalo.OznakaSjedala}", font, XBrushes.Black, new XRect(104, 190, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.DatumPolaska.Add(new TimeSpan(0, -45, 0)).ToString("HH:mm")}", font, XBrushes.Black, new XRect(282, 190, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.RezerviranoSjedalo.OznakaSjedala}", font, XBrushes.Black, new XRect(448, 182, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);
            graph.DrawString($"{selektiranaRezervacija.LetRezervacije.DatumPolaska.Add(new TimeSpan(0, -45, 0)).ToString("HH:mm")}", font, XBrushes.Black, new XRect(495, 182, pdfPage.Width.Point, pdfPage.Height.Point), XStringFormats.TopLeft);

            pdf.Save("karta.pdf");
            pdf.Dispose();

            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

            client.UseDefaultCredentials = false;
            NetworkCredential cred = new NetworkCredential("skyflyreservation@gmail.com", "sj6IWP3o");

            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress("skyflyreservation@gmail.com");

            Msg.To.Add($"{RepozitorijSkyFlyReservation.prijavljeniKorisnik.EmailKorisnika}");

            Msg.Subject = "Potvrda kupnje karte";

            Msg.Body = $"Poštovani {selektiranaRezervacija.KorisnikRezervacije.ImeKorisnika} {selektiranaRezervacija.KorisnikRezervacije.PrezimeKorisnika},\n\n" +
                $"Na osnovu provedene kupnje karte za sjedalo {selektiranaRezervacija.RezerviranoSjedalo.OznakaSjedala} na letu {selektiranaRezervacija.LetRezervacije.BrojLeta} | {selektiranaRezervacija.LetRezervacije.PolazisniAerodrom.NazivAerodroma}->{selektiranaRezervacija.LetRezervacije.OdredisniAerodrom.NazivAerodroma} šaljemo Vam kartu za let.\n" +
                "Karta se nalazi u pdf-u koji ste primili u ovoj poruci.\n" +
                "Kartu koju ste primili koristite prilikom prijave na aerodromu.\n" +
                "Molimo Vas da provjeru karte izvršite najkasnije 45 min prije polaska.\n\n" +
                "S poštovanjem,\n" +
                "SkyFlyReservation";

            Msg.Attachments.Add(new Attachment(@"karta.pdf"));

            client.Credentials = cred;

            client.EnableSsl = true;

            client.Send(Msg);
            client.Dispose();
        }

        private void FormPlatiRezervaciju_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                Help.ShowHelp(this, AppDomain.CurrentDomain.BaseDirectory + "\\SkyFlyReservationUserManual.chm", HelpNavigator.Topic, "PlatiRezervaciju.htm");
            }
        }
    }
}
