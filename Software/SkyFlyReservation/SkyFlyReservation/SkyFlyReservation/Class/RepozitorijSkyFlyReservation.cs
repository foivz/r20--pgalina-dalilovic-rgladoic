using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public static class RepozitorijSkyFlyReservation
    {
        public static List<Aerodrom> Aerodromi { get; set; }
        public static List<Korisnik> Korisnici { get; set; }
        public static List<Valuta> Valute { get; set; }
        public static List<Aviokompanija> Aviokompanije { get; set; }
        public static Korisnik initPutnik { get; set; }

        public static void Inicijaliziraj()
        {
            Aerodromi = new List<Aerodrom>();
            Korisnici = new List<Korisnik>();
            Aviokompanije = new List<Aviokompanija>();
            Valute = new List<Valuta>();

            Aerodrom initAerodrom1 = new Aerodrom("Zračna luka Split", "ST", "Splitska 1a", "12424231664321", "042/125-912", "split@zracna-luka.hr");
            Aerodrom initAerodrom2 = new Aerodrom("Zračna luka Zagreb", "ZG", "Zagrebačka 15d", "98124224215214", "01/112-124", "zagreb@zracna-luka.hr");
            Aviokompanija initAviokompanija = new Aviokompanija("Croatia Airlines", "41245584232125", "Buzin 14a", "031/312-112", "croatia-airlines@info.hr", "HR6424020067223592659");

            Avion initAvion1 = new Avion("RE124GF", "Boing", "747", 10, initAviokompanija);
            Avion initAvion2 = new Avion("HG387VU", "Airbus", "A-320", 50, initAviokompanija);

            Valuta valuta1 = new Valuta("HRK", "Hrvatska");
            Valuta valuta2 = new Valuta("USD", "Amerika");

            Valute.Add(valuta1);
            Valute.Add(valuta2);


            initAviokompanija.AvioniAviokompanije.Add(initAvion1);
            initAviokompanija.AvioniAviokompanije.Add(initAvion2);
            Aviokompanije.Add(initAviokompanija);


            DodajNoviLet(initAerodrom1, initAerodrom2, initAvion1, initAviokompanija, valuta1);


            Aerodromi.Add(initAerodrom1);
            Aerodromi.Add(initAerodrom2);
            
            initPutnik = new Korisnik("Pero", "Perić", "12415313353122", "Perovska 111b", "049/124-612", "pero.peric@gmail.com", UlogaKorisnika.Moderator, initAviokompanija);

            Korisnici.Add(initPutnik);
        }

        private static void DodajNoviLet(Aerodrom polazisni, Aerodrom odredisni, Avion avion, Aviokompanija aviokompanija, Valuta valuta)
        {
            DateTime datumPolaska = new DateTime(2020, 4, 28, 16, 15, 0);
            DateTime datumDolaska = new DateTime(2020, 4, 28, 17, 2, 0);
            double cijenaLeta = 923;

            Let initLet = new Let(polazisni, odredisni, avion, datumPolaska, datumDolaska, cijenaLeta, valuta);

            polazisni.DodajLet(initLet);
            odredisni.DodajLet(initLet);

            aviokompanija.DodajLet(initLet);
        }

        public static Aerodrom DohvatiSelektiraniAerodrom(string nazivAerodroma)
        {
            Aerodrom odabrani = Aerodromi.FirstOrDefault(a => a.NazivAerodroma == nazivAerodroma);

            return odabrani;
        }

        public static Valuta DohvatiValutu(string nazivValute)
        {
            Valuta valuta = Valute.FirstOrDefault(v => v.Oznaka == nazivValute);

            return valuta;
        }
    }
}
