using System;
using System.Text.RegularExpressions;

namespace Validation
{
    public class ValidacijaRegistracije
    {
        private string Poruka { get; set; }
        public string Validiraj(string[] korisnik)
        {
            Poruka = "";
            if (korisnik[0].Length == 0) Poruka += "Polje za ime je prazno!\n";
            if (korisnik[1].Length == 0) Poruka += "Polje za prezime je prazno!\n";
            if (!Regex.IsMatch(korisnik[2], "^.+@.+\\..+$")) Poruka += "Email mora biti oblika: example@example.example!\n";
            if (korisnik[3].Length == 0) Poruka += "Polje za adresu je prazno!\n";
            if (korisnik[4].Length == 0) Poruka += "Polje za kontakt je prazno!\n";
            if (korisnik[5].Length == 0) Poruka += "Polje za OIB je prazno!\n";
            if (korisnik[6].Length < 5) Poruka += "Korisničko ime mora biti najmanje 5 znakova!\n";
            if (korisnik[7].Length < 8) Poruka += "Lozinka mora biti najmanje 8 znakova!\n";
            if (korisnik[8] != korisnik[7]) Poruka += "Lozinka i ponovljena lozinka se ne podudaraju!\n";

            return Poruka;
        }
    }
}
