using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Aerodrom
    {
        public string NazivAerodroma { get; set; }
        public string OznakaAerodroma { get; set; }
        public string AdresaAerodorma { get; set; }
        public string OIBAerodroma { get; set; }
        public string KontaktAerodroma { get; set; }
        public string EmailAerodroma { get; set; }
        public List<Let> LetoviAerodroma { get; set; }

        public Aerodrom(string naziv, string oznaka, string adresa, string oib, string kontakt, string email)
        {
            NazivAerodroma = naziv;
            OznakaAerodroma = oznaka;
            AdresaAerodorma = adresa;
            OIBAerodroma = oib;
            KontaktAerodroma = kontakt;
            EmailAerodroma = email;

            LetoviAerodroma = new List<Let>();
        }

        public void DodajLet(Let let)
        {
            LetoviAerodroma.Add(let);
        }
        public void ObrisiLet(Let let)
        {
            LetoviAerodroma.Remove(let);
        }
    }
}
