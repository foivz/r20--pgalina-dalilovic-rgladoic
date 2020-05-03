using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class Avion
    {
        public string IdentifikatorAviona { get; set; }
        public string ProizvodacAviona { get; set; }
        public string TipAviona { get; set; }
        public int BrojMjesta { get; set; }
        public List<Sjedalo> SjedalaUAvionu { get; set; }
        public Aviokompanija Aviokompanija { get; set; }

        public Avion(string identifikator, string proizvodac, string tip, int brojMjesta, Aviokompanija aviokompanija)
        {
            IdentifikatorAviona = identifikator;
            ProizvodacAviona = proizvodac;
            TipAviona = tip;
            BrojMjesta = brojMjesta;

            SjedalaUAvionu = new List<Sjedalo>();
            /*
            Sjedalo initSjedalo1 = new Sjedalo("A1");
            Sjedalo initSjedalo2 = new Sjedalo("A2");
            Sjedalo initSjedalo3 = new Sjedalo("A3");
            Sjedalo initSjedalo4 = new Sjedalo("A4");
            Sjedalo initSjedalo5 = new Sjedalo("A5");
            Sjedalo initSjedalo6 = new Sjedalo("A6");
            Sjedalo initSjedalo7 = new Sjedalo("A7");
            Sjedalo initSjedalo8 = new Sjedalo("A8");
            Sjedalo initSjedalo9 = new Sjedalo("A9");
            Sjedalo initSjedalo10 = new Sjedalo("A10");

            SjedalaUAvionu.Add(initSjedalo1);
            SjedalaUAvionu.Add(initSjedalo2);
            SjedalaUAvionu.Add(initSjedalo3);
            SjedalaUAvionu.Add(initSjedalo4);
            SjedalaUAvionu.Add(initSjedalo5);
            SjedalaUAvionu.Add(initSjedalo6);
            SjedalaUAvionu.Add(initSjedalo7);
            SjedalaUAvionu.Add(initSjedalo8);
            SjedalaUAvionu.Add(initSjedalo9);
            SjedalaUAvionu.Add(initSjedalo10);
            */

            int brojacOznaka = 1;
            char oznaka = 'A';


            for (int i = 1; i <= brojMjesta; i++)
            {
                if(brojacOznaka <= 30)
                {
                    string oznakaSjedala = oznaka + brojacOznaka.ToString();
                    Sjedalo initSjedalo = new Sjedalo(oznakaSjedala);
                    SjedalaUAvionu.Add(initSjedalo);
                    brojacOznaka++;
                }
                else if(brojacOznaka > 30)
                {
                    brojacOznaka = 1;
                    oznaka += (char) 1;

                    //int asciiOznaka = int.Parse(oznaka.ToString()) + 1 ;
                }
            }

            Aviokompanija = aviokompanija;
        }
        public Sjedalo AzurirajSjedalo(string oznakaSjedala, StanjeSjedala status)
        {
            Sjedalo odabranoSjedalo = DohvatiSjedalo(oznakaSjedala);

            if(odabranoSjedalo.StatusSjedala == StanjeSjedala.Slobodno)
            {
                odabranoSjedalo.StatusSjedala = status;
            }

            return odabranoSjedalo;
        }

        public Sjedalo DohvatiSjedalo(string oznakaSjedala)
        {
            Sjedalo odabranoSjedalo = null;

            foreach (Sjedalo s in SjedalaUAvionu)
            {
                if(s.OznakaSjedala == oznakaSjedala)
                {
                    odabranoSjedalo = s;
                }
            }

            return odabranoSjedalo;
        }
    }
}
