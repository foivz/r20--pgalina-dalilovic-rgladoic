using PdfSharp.Drawing;
using PdfSharp.Pdf;
using SkyFlyReservation.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserHelpControler;

namespace SkyFlyReservation
{
    public partial class FormPrikazIzvjesca : Form
    {
        public FormPrikazIzvjesca()
        {
            this.KeyPreview = true;
            InitializeComponent();
            this.AutoScroll = true;
        }

        private void FormPrikazIzvjesca_Load(object sender, EventArgs e)
        {
            List<Let> letovi = RepozitorijSkyFlyReservation.DohvatiLetove();

            
            List<string> polazista = letovi.Select(l => l.PolazisniAerodrom.ToString()).Distinct().ToList();

            List<string> sva_polazista = letovi.Select(l => l.PolazisniAerodrom.ToString()).ToList();

            List<int> broj_polazaka = new List<int>();

            for (int i = 0; i < polazista.Count; i++)
            {
                int broj = 0;
                for (int j = 0; j < sva_polazista.Count; j++)
                {
                    if(polazista[i] == sva_polazista[j])
                    {
                        broj++;
                    }
                }
                broj_polazaka.Add(broj);
            }

            for (int i = 0; i < polazista.Count; i++)
            {
                chartPolaznisniAerodromi.Series[0].Points.AddXY(polazista[i], broj_polazaka[i]);
            }

            List<string> odredista = letovi.Select(l => l.OdredisniAerodrom.ToString()).Distinct().ToList();

            List<string> sva_odredista = letovi.Select(l => l.OdredisniAerodrom.ToString()).ToList();

            List<int> broj_dolazaka = new List<int>();
            
            for (int i = 0; i < odredista.Count; i++)
            {
                int broj = 0;
                for (int j = 0; j < sva_odredista.Count; j++)
                {
                    if (odredista[i] == sva_odredista[j])
                    {
                        broj++;
                    }
                }
                broj_dolazaka.Add(broj);
            }

            for (int i = 0; i < odredista.Count; i++)
            {
                chartOdredisniAerodromi.Series[0].Points.AddXY(odredista[i], broj_dolazaka[i]);
            }

        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormPrikazIzvjesca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                Controler controler = new Controler();
                controler.OtvoriUserHelp(this, "PrikazIzvjesca.htm");
            }
        }

        private void btnPreuzmi_Click(object sender, EventArgs e)
        {
            MemoryStream grafStream = new MemoryStream();

            chartPolaznisniAerodromi.SaveImage(grafStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);

            XImage grafSlika = XImage.FromStream(grafStream);

            PdfDocument pdfGraf = new PdfDocument();
            PdfPage stranica = pdfGraf.AddPage();
            XGraphics slika = XGraphics.FromPdfPage(stranica);

            slika.DrawImage(grafSlika, 90, 30);

            string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            pdfGraf.Save(putanja + "\\Grafovi\\Polazisni aerodromi.pdf");
            pdfGraf.Dispose();

            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

            client.UseDefaultCredentials = false;
            NetworkCredential cred = new NetworkCredential("skyflyreservation@gmail.com", "sj6IWP3o");

            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress("skyflyreservation@gmail.com");

            Msg.To.Add($"{RepozitorijSkyFlyReservation.prijavljeniKorisnik.EmailKorisnika}");

            Msg.Subject = "Izvješće o broju letova";

            Msg.Body = $"Poštovani {RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika} {RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika},\n\n" +
                $"U privitku vam dostavljamo izvješće o broju letova. \n" +
                "S poštovanjem,\n" +
                "SkyFlyReservation";

            Msg.Attachments.Add(new Attachment(putanja + "\\Grafovi\\Polazisni aerodromi.pdf"));

            client.Credentials = cred;

            client.EnableSsl = true;

            client.Send(Msg);
            client.Dispose();

            MessageBox.Show("Izvješće je poslano na email iz vašeg korisničkog računa.");

            this.Close();
        }

        private void btnPreuzmi2_Click(object sender, EventArgs e)
        {
            MemoryStream grafStream = new MemoryStream();

            chartOdredisniAerodromi.SaveImage(grafStream, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Jpeg);

            XImage grafSlika = XImage.FromStream(grafStream);

            PdfDocument pdfGraf = new PdfDocument();
            PdfPage stranica = pdfGraf.AddPage();
            XGraphics slika = XGraphics.FromPdfPage(stranica);

            slika.DrawImage(grafSlika, 90, 30);

            string putanja = AppDomain.CurrentDomain.BaseDirectory.Replace("\\bin\\Debug", "");

            pdfGraf.Save(putanja + "\\Grafovi\\Odredisni aerodromi.pdf");
            pdfGraf.Dispose();

            SmtpClient client = new SmtpClient("smtp.gmail.com", 25);

            client.UseDefaultCredentials = false;
            NetworkCredential cred = new NetworkCredential("skyflyreservation@gmail.com", "sj6IWP3o");

            MailMessage Msg = new MailMessage();

            Msg.From = new MailAddress("skyflyreservation@gmail.com");

            Msg.To.Add($"{RepozitorijSkyFlyReservation.prijavljeniKorisnik.EmailKorisnika}");

            Msg.Subject = "Izvješće o broju letova";

            Msg.Body = $"Poštovani {RepozitorijSkyFlyReservation.prijavljeniKorisnik.ImeKorisnika} {RepozitorijSkyFlyReservation.prijavljeniKorisnik.PrezimeKorisnika},\n\n" +
                $"U privitku vam dostavljamo izvješće o broju letova. \n" +
                "S poštovanjem,\n" +
                "SkyFlyReservation";

            Msg.Attachments.Add(new Attachment(putanja + "\\Grafovi\\Odredisni aerodromi.pdf"));

            client.Credentials = cred;

            client.EnableSsl = true;

            client.Send(Msg);
            client.Dispose();

            MessageBox.Show("Izvješće je poslano na email iz vašeg korisničkog računa.");

            this.Close();
        }
    }
}
