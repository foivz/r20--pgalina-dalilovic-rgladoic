using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Avion
    {
        public int AvionId { get; set; }
        public string IdentifikatorAviona { get; set; }
        public string ProizvodacAviona { get; set; }
        public string ModelAviona { get; set; }
        public int BrojMjesta { get; set; }
        public Aviokompanija Aviokompanija { get; set; }

        public override string ToString()
        {
            return ProizvodacAviona + " " + ModelAviona;
        }
    }
}
