using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Validation
{
    public class ValidacijaZahtjeva
    {
        private string Poruka { get; set; }
        public string Validiraj(string[] zahtjev)
        {
            Poruka = "";
            if (zahtjev[0].Length == 0) Poruka += "Tekst zahtjeva je prazan!\n";
           
            return Poruka;
        }
    }
}
