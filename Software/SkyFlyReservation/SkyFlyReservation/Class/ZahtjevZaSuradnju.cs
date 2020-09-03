using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public enum StanjeZahtjeva
    {
        Prihvaćen,
        Odbijen,
        Obrada
    }
    public class ZahtjevZaSuradnju
    {
        public int ZahtjevId { get; set; }
        public Korisnik Korisnik { get; set; }
        public DateTime DatumVrijemeKreiranja { get; set; }
        public string TekstZahtjeva { get; set; }
        public StanjeZahtjeva StatusZahtjeva { get; set; }
    }
}
