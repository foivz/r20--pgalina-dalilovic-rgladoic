using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public enum StanjeRezervacije
    {
        Plaćena,
        Neplaćena,
        Istekla
    };

    public class Rezervacija
    {
        private Let LetRezervacije { get; set; }
        public string BrojLetaRezervacije { get; set; }
        private Korisnik KorisnikRezervacije { get; set; }
        public string ImePrezimeKorisnikaRezervacije { get; set; }
        private Sjedalo RezerviranoSjedalo { get; set; }
        public string OznakaRezerviranogSjedala { get; set; }
        public DateTime DatumVrijemeRezervacije { get; set; }
        public StanjeRezervacije StatusRezervacije { get; set; }

        public Rezervacija(Korisnik putnik, Let let, Sjedalo sjedalo,StanjeRezervacije status)
        {
            LetRezervacije = let;
            BrojLetaRezervacije = let.BrojLeta;

            KorisnikRezervacije = putnik;
            ImePrezimeKorisnikaRezervacije = putnik.ImePutnika + " " + putnik.PrezimePutnika;
            
            RezerviranoSjedalo = sjedalo;
            OznakaRezerviranogSjedala = sjedalo.OznakaSjedala;


            DateTime datumRezervacije = DateTime.Now;
            DatumVrijemeRezervacije = datumRezervacije;

            StatusRezervacije = status;
        }

        public void AzurirajRezervaciju(StanjeRezervacije status)
        {
            StatusRezervacije = status;
        }

        public Let DohvatiLet()
        {
            return LetRezervacije;
        }

        public Korisnik DohvatiPutnika()
        {
            return KorisnikRezervacije;
        }

        public Sjedalo DohvatiRezerviranoSjedalo()
        {
            return RezerviranoSjedalo;
        }
    }
}
