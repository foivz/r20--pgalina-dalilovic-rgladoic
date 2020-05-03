using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    class Kupnja
    {
        public Rezervacija Rezervacija { get; set; }
        public Korisnik Platitelj { get; set; }
        public string IBANPlatitelja { get; set; }
        public Aviokompanija Primatelj { get; set; }
        public string IBANPrimatelja { get; set; }
        public DateTime DatumVrijemeKupnje { get; set; }

        public Kupnja(Rezervacija rezervacija, string ibanPlatitelja)
        {
            Rezervacija = rezervacija;
            Platitelj = rezervacija.DohvatiPutnika();
            IBANPlatitelja = ibanPlatitelja;
            Primatelj = rezervacija.DohvatiLet().DohvatiAvion().Aviokompanija;
            IBANPrimatelja = rezervacija.DohvatiLet().DohvatiAvion().Aviokompanija.IBANAviokompanije;

            rezervacija.AzurirajRezervaciju(StanjeRezervacije.Plaćena);

            DateTime datumVrijemeKupnje = DateTime.Now;
            DatumVrijemeKupnje = datumVrijemeKupnje;
        }
    }
}
