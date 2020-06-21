using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public enum UlogaKorisnika
    {
        RegistriraniKorisnik,
        Moderator,
        Administrator,
        Owner
    };

    public class Korisnik
    {
        public int KorisnikId { get; set; }
        public string ImeKorisnika { get; set; }
        public string PrezimeKorisnika { get; set; }
        public string OIBKorisnika { get; set; }
        public string AdresaKorisnika { get; set; }
        public string KontaktTelefonKorisnika { get; set; }
        public string EmailKorisnika { get; set; }
        public string KorisnickoImeKorisnika { get; set; }
        public string LozinkaKorisnika { get; set; }
        public UlogaKorisnika UlogaKorisnika { get; set; }
        public Aviokompanija Aviokompanija { get; set; }

        public void PromijeniUlogu(UlogaKorisnika uloga)
        {
            UlogaKorisnika = uloga;
        }

        public override string ToString()
        {
            return ImeKorisnika + " " + PrezimeKorisnika;
        }
    }
}
