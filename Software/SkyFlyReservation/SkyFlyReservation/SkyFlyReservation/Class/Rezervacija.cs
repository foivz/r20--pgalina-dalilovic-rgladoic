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
        public int RezervacijaId { get; set; }
        public Let LetRezervacije { get; set; }
        public Aerodrom PolazisniAerodrom { get; set; }
        public Aerodrom OdredisniAerodrom { get; set; }
        public Korisnik KorisnikRezervacije { get; set; }
        public Sjedalo RezerviranoSjedalo { get; set; }
        public DateTime DatumVrijemeRezervacije { get; set; }
        public StanjeRezervacije StatusRezervacije { get; set; }
    }
}
