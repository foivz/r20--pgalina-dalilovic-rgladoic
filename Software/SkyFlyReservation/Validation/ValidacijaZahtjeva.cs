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
            if (zahtjev[0].Length == 0) Poruka += "Unesite naziv aviokompanije!\n";
            if (zahtjev[1].Length == 0) Poruka += "Unesite OIB aviokompanije!\n";
            if (zahtjev[2].Length == 0) Poruka += "Unesite IBAN aviokompanije!\n";
            if (zahtjev[3].Length == 0) Poruka += "Unesite adresu aviokompanije!\n";
            if (zahtjev[4].Length == 0) Poruka += "Unesite kontakt telefon aviokompanije!\n";
            if (zahtjev[5].Length == 0) Poruka += "Unesite email aviokompanije!\n";
            if (zahtjev[6].Length == 0) Poruka += "Tekst zahtjeva je prazan!\n";

            return Poruka;
        }
    }
}
