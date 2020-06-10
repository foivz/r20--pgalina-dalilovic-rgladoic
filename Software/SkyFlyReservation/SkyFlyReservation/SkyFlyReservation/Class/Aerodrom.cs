using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Aerodrom
    {
        public int AerodromId { get; set; }
        public string NazivAerodroma { get; set; }
        public string OznakaAerodroma { get; set; }
        public string AdresaAerodorma { get; set; }
        public string OIBAerodroma { get; set; }
        public string KontaktAerodroma { get; set; }
        public string EmailAerodroma { get; set; }

        public override string ToString()
        {
            return NazivAerodroma;
        }
    }
}
