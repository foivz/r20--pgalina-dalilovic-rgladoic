using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public class BrojLetaGenerator
    {
        public string GenerirajBrojLeta(Aerodrom polazisni, Aerodrom odredisni)
        {
            string brojLeta = "";
            brojLeta += polazisni.OznakaAerodroma.ToString();

            Random generatorOznake = new Random();

            string peteroznamenkastiBroj = generatorOznake.Next(10000, 99999).ToString();

            brojLeta += peteroznamenkastiBroj;
            brojLeta += odredisni.OznakaAerodroma.ToString();

            return brojLeta;
        }
    }
}
