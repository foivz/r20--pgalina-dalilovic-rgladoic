using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Aviokompanija
    {
        public int AviokompanijaId { get; set; }
        public string NazivAviokompanije { get; set; }
        public string OIBAviokompanije { get; set; }
        public string AdresaAviokompanije { get; set; }
        public string KontaktAviokompanije { get; set; }
        public string EmailAviokompanije { get; set; }
        public string IBANAviokompanije { get; set; }

        public override string ToString()
        {
            return NazivAviokompanije;
        }
    }
}
