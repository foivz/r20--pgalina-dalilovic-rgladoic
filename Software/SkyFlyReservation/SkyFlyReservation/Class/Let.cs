using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Let
    {
        public int LetId { get; set; }
        public string BrojLeta { get; set; }
        public Aerodrom PolazisniAerodrom { get; set; }
        public Aerodrom OdredisniAerodrom { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumDolaska { get; set; }
        public Avion AvionNaLetu { get; set; }
        public double CijenaKarte { get; set; }
        public int BrojSlobodnihMjesta { get; set; }


        public override string ToString()
        {
            return BrojLeta;
        }
    }
}
