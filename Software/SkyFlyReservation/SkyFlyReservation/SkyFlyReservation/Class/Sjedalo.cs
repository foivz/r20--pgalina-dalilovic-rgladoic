using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public enum StanjeSjedala
    {
        Slobodno, 
        Zauzeto
    };

   public class Sjedalo
    {
        public string OznakaSjedala { get; set; }
        public StanjeSjedala StatusSjedala { get; set; }

        public Sjedalo(string oznaka)
        {
            OznakaSjedala = oznaka;
            StatusSjedala = StanjeSjedala.Slobodno;
        }
    }
}
