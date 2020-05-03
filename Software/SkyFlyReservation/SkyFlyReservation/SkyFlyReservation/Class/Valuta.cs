using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Valuta
    {
        public string Oznaka { get; set; }
        public string Drzava { get; set; }

        public Valuta(string oznaka, string drzava)
        {
            Oznaka = oznaka;
            Drzava = drzava;
        }
    }
}
