using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Let
    {
        public string BrojLeta { get; set; }
        public string NazivPolazisnogAerodroma { get; set; }
        public string NazivOdredisnogAerodroma { get; set; }
        private Aerodrom PolazisniAerodrom { get; set; }
        private Aerodrom OdredisniAerodrom { get; set; }
        private Avion AvionNaLetu { get; set; }
        public DateTime DatumPolaska { get; set; }
        public DateTime DatumDolaska { get; set; }
        public double CijenaKarte { get; set; }
        public string OznakaValute { get; set; }
        public double BrojSlobodnihMjesta { get; set; }
        public List<Korisnik> PutniciNaLetu { get; set; }

        public Let(Aerodrom polazisni, Aerodrom odredisni, Avion avion, DateTime polazak, DateTime dolazak, double cijena, Valuta valuta)
        {
            BrojLetaGenerator generator = new BrojLetaGenerator();
            BrojLeta = generator.GenerirajBrojLeta(polazisni, odredisni);

            PolazisniAerodrom = polazisni;
            NazivPolazisnogAerodroma = polazisni.NazivAerodroma;
            NazivOdredisnogAerodroma = odredisni.NazivAerodroma;
            OdredisniAerodrom = odredisni;
            AvionNaLetu = avion;
            DatumPolaska = polazak;
            DatumDolaska = dolazak;
            CijenaKarte = cijena;
            BrojSlobodnihMjesta = avion.BrojMjesta;

            PutniciNaLetu = new List<Korisnik>();
            OznakaValute = valuta.Oznaka;
        }

        public Avion DohvatiAvion()
        {
            return this.AvionNaLetu;
        }
        public Aerodrom DohvatiPolazisniAerodrom()
        {
            return this.PolazisniAerodrom;
        }
        public Aerodrom DohvatiOdredisniAerodrom()
        {
            return this.OdredisniAerodrom;
        }
        public void AzurirajLet(Aerodrom polazisni, Aerodrom odredisni, Avion avion, double brojMjesta,DateTime polazak, DateTime dolazak, double cijena, Valuta valuta)
        {
            PolazisniAerodrom = polazisni;
            NazivPolazisnogAerodroma = polazisni.NazivAerodroma;
            NazivOdredisnogAerodroma = odredisni.NazivAerodroma;
            OdredisniAerodrom = odredisni;
            AvionNaLetu = avion;
            DatumPolaska = polazak;
            DatumDolaska = dolazak;
            CijenaKarte = cijena;
            BrojSlobodnihMjesta = brojMjesta;
            OznakaValute = valuta.Oznaka;
        }
    }
}
