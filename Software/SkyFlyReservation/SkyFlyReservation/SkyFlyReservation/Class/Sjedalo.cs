using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
   public class Sjedalo
    {
        public int SjedaloId { get; set; }
        public string OznakaSjedala { get; set; }

        public override string ToString()
        {
            return OznakaSjedala;
        }
    }
}
