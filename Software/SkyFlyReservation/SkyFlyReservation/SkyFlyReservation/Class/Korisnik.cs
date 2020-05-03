using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public enum UlogaKorisnika
    {
        NeregistriraniKorisnik,
        RegistriraniKorisnik,
        Moderator,
        Administrator,
        Owner
    };

    public class Korisnik
    {
        public string ImePutnika { get; set; }
        public string PrezimePutnika { get; set; }
        public string OIBPutnika { get; set; }
        public string AdresaPutnika { get; set; }
        public string KontaktPutnika { get; set; }
        public string EmailPutnika { get; set; }
        public UlogaKorisnika UlogaKorisnika { get; set; }
        public Aviokompanija Aviokompanija { get; set; }
        public List<Rezervacija> RezervacijePutnika { get; set; }

        public Korisnik(string ime, string prezime, string oib, string adresa, string kontakt, string email, UlogaKorisnika uloga, Aviokompanija aviokompanija)
        {
            ImePutnika = ime;
            PrezimePutnika = prezime;
            OIBPutnika = oib;
            AdresaPutnika = adresa;
            KontaktPutnika = kontakt;
            EmailPutnika = email;
            UlogaKorisnika = uloga;
            Aviokompanija = aviokompanija;

            RezervacijePutnika = new List<Rezervacija>();

        }

        public void PromijeniUlogu(UlogaKorisnika uloga)
        {
            UlogaKorisnika = uloga;
        }
    }
}
