using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Aviokompanija
    {
        public string NazivAviokompanije { get; set; }
        public string OIBAviokompanije { get; set; }
        public string AdresaAviokompanije { get; set; }
        public string KontaktAviokompanije { get; set; }
        public string EmailAviokomanije { get; set; }
        public string IBANAviokompanije { get; set; }
        public List<Avion> AvioniAviokompanije { get; set; }
        public List<Let> LetoviAviokompanije { get; set; }

        public Aviokompanija(string naziv, string oib, string adresa, string kontakt, string email, string iban)
        {
            NazivAviokompanije = naziv;
            OIBAviokompanije = oib;
            AdresaAviokompanije = adresa;
            KontaktAviokompanije = kontakt;
            EmailAviokomanije = email;
            IBANAviokompanije = iban;

            AvioniAviokompanije = new List<Avion>();
            LetoviAviokompanije = new List<Let>();
        }

        public void DodajLet(Let let)
        {
            LetoviAviokompanije.Add(let);
        }

        public void ObrisiLet(Let let)
        {
            LetoviAviokompanije.Remove(let);
        }

        public void DodajNoviAvion(Avion avion)
        {
            AvioniAviokompanije.Add(avion);
        }
    }
}
