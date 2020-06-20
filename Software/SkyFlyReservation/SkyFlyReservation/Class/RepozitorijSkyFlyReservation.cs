using Database_Access;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyFlyReservation.Class
{
    public static class RepozitorijSkyFlyReservation
    {
        public static Korisnik prijavljeniKorisnik;

        public static List<Let> DohvatiLetove()
        {
            string sql = "SELECT LetId as letId, BrojLeta as brojLeta, DatumVrijemePolaska as datumVrijemePolaska, DatumVrijemeDolaska as datumVrijemeDolaska, CijenaKarte as cijenaKarte, BrojSlobodnihMjesta as brojSlobodnihMjesta , polazisni.AerodromId as idPolazisnogAerodroma, polazisni.NazivAerodroma as nazivPolazisnogAerodroma, polazisni.OznakaAerodroma as oznakaPolazisnogAerodroma, polazisni.AdresaAerodroma as adresaPolazisnogAerodroma, polazisni.OIBAerodroma as oibPolazisnogAerodroma, polazisni.KontaktTelefonAerodroma as kontaktPolazisnogAerodroma, polazisni.EmailAerodroma as emailPolazisnogAerodroma, odredisni.AerodromId as idOdredisnogAerodroma, odredisni.NazivAerodroma as nazivOdredisnoAerodroma, odredisni.OznakaAerodroma as oznakaOdredisnogAerodroma, odredisni.AdresaAerodroma as adresaOdredisnogAerodroma, odredisni.OIBAerodroma as oibOdredisnogAerodroma, odredisni.KontaktTelefonAerodroma as kontaktOdredisnogAerodroma, odredisni.EmailAerodroma as emailOdreisnogAerodroma, a.AvionId as idAviona, a.RegistarskaOznakaAviona as identifikatorAviona, a.ProizvodacAviona as proizvodacAviona, a.ModelAviona as modelAviona, a.BrojSjedalaAviona as brojMjesta, ak.AviokompanijaId as idAviokompanije, ak.NazivAviokompanije as nazivAviokompanije, ak.OIBAviokompanije as oibAviokompanijem, ak.AdresaAviokompanije as adresaAviokompanije, ak.KontaktTelefonAviokompanije as kontaktAviokompanije, ak.EmailAviokompanije as emailAviokompanije, ak.IBANAviokompanije as ibanAviokompanije FROM Let l " +
                "INNER JOIN Aerodrom polazisni ON l.PolazisniAerodrom = polazisni.AerodromId " +
                "INNER JOIN Aerodrom odredisni ON l.OdredisniAerodrom = odredisni.AerodromId " +
                "INNER JOIN Avion a ON l.IdAvion = a.AvionId " +
                "INNER JOIN Aviokompanija ak ON a.IdAviokompanije = ak.AviokompanijaId;";

            List<Let> letovi = DohvatiPodatkeLetova(sql);

            return letovi;
        }

        internal static int AzurirajKorisnika(string email, string lozinka)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Korisnik SET Lozinka = '{lozinka}' " +
                $"WHERE EmailAdresaKorisnika = '{email}';";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        internal static Korisnik ProvjeriEmail(string email)
        {
            string sql = "SELECT * FROM Korisnik k " +
                "INNER JOIN UlogaKorisnika u ON k.IdUlogaKorisnika = u.UlogaKorisnikaId " +
                $"LEFT JOIN Aviokompanija a ON k.AviokompanijaKorisnika = a.AviokompanijaId WHERE EmailAdresaKorisnika = '{email}';";

            Korisnik korisnik = DohvatiPodatkeOdabranogKorisnika(sql);
            
            return korisnik;
        }

        internal static List<Let> DohvatiNajpopularnijeLetove()
        {
            List<Let> dohvaceniLetovi = DohvatiLetove();

            string sql = "SELECT COUNT(RezervacijaId) as brojRezervacija, LetId FROM Let l " +
                "LEFT JOIN Rezervacija r ON r.IdLetaRezervacije = l.LetId " +
                "GROUP BY LetId ORDER BY brojRezervacija DESC; ";

            Dictionary<int, int> BrojRezervacijaLeta = new Dictionary<int, int>();
            BrojRezervacijaLeta = DohvatiPodatkeRezervacijaLeta(sql);

            Dictionary<int, int> RezervacijeLeta = new Dictionary<int, int>();

            foreach (var item in BrojRezervacijaLeta)
            {
                if(item.Value != 0)
                {
                    RezervacijeLeta.Add(item.Key, item.Value);
                }
            }

            List<Let> letovi = new List<Let>();

            foreach (var item in dohvaceniLetovi)
            {
                if (RezervacijeLeta.ContainsKey(item.LetId))
                {
                    letovi.Add(item);
                }
            }

            int range = letovi.Count();
            if(range > 10)
            {
                range = 10;
            }

            letovi = letovi.GetRange(0, range);

            return letovi;
        }

        internal static int AzurirajKorisnika(int Id, Korisnik korisnik)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Korisnik SET Ime = '{korisnik.ImeKorisnika}', Prezime = '{korisnik.PrezimeKorisnika}', AdresaKorisnika = '{korisnik.AdresaKorisnika}', KontaktTelefon = '{korisnik.KontaktTelefonKorisnika}', " +
                $"EmailAdresaKorisnika = '{korisnik.EmailKorisnika}', OIBKorisnika = '{korisnik.OIBKorisnika}', KorisnickoIme = '{korisnik.KorisnickoImeKorisnika}', Lozinka = '{korisnik.LozinkaKorisnika}' " +
                $"WHERE KorisnikId = {Id};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        private static Dictionary<int, int> DohvatiPodatkeRezervacijaLeta(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            Dictionary<int, int> brojRezervacijaLeta = new Dictionary<int, int>();

            while (dataReader.Read())
            {
                brojRezervacijaLeta.Add((int)dataReader["LetId"], (int)dataReader["brojRezervacija"]);
            }

            return brojRezervacijaLeta;
        }

        public static Korisnik DohvatiKorisnika(string korIme)
        {
            string sql = "SELECT * FROM Korisnik k " +
                "INNER JOIN UlogaKorisnika u ON k.IdUlogaKorisnika = u.UlogaKorisnikaId " +
                $"LEFT JOIN Aviokompanija a ON k.AviokompanijaKorisnika = a.AviokompanijaId WHERE KorisnickoIme = '{korIme}';";

            Korisnik korisnik = DohvatiPodatkeOdabranogKorisnika(sql);

            return korisnik;
        }

        private static Korisnik DohvatiPodatkeOdabranogKorisnika(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            bool recvData = dataReader.Read();
            if (recvData == false)
            {
                dataReader.Close();
                Database.Instance.Disconnect();
                return null;
            }
            else {
                UlogaKorisnika uloga = new UlogaKorisnika();
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Administrator")
                {
                    uloga = UlogaKorisnika.Administrator;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Moderator")
                {
                    uloga = UlogaKorisnika.Moderator;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Owner")
                {
                    uloga = UlogaKorisnika.Owner;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Registrirani korisnik")
                {
                    uloga = UlogaKorisnika.RegistriraniKorisnik;
                }
                Korisnik korisnik = new Korisnik()
                {
                    KorisnikId = (int)dataReader["KorisnikId"],
                    UlogaKorisnika = uloga,
                    Aviokompanija = null,
                    ImeKorisnika = dataReader["Ime"].ToString(),
                    PrezimeKorisnika = dataReader["Prezime"].ToString(),
                    AdresaKorisnika = dataReader["AdresaKorisnika"].ToString(),
                    KontaktTelefonKorisnika = dataReader["KontaktTelefon"].ToString(),
                    EmailKorisnika = dataReader["EmailAdresaKorisnika"].ToString(),
                    OIBKorisnika = dataReader["OIBKorisnika"].ToString(),
                    KorisnickoImeKorisnika = dataReader["KorisnickoIme"].ToString(),
                    LozinkaKorisnika = dataReader["Lozinka"].ToString()

                };
                dataReader.Close();
                Database.Instance.Disconnect();
                return korisnik;
            }
        }

        public static int DodajKorisnika(Korisnik korisnik)
        {
            Database.Instance.Connect();
            string sqlNULL = "NULL";
            string sql = "INSERT INTO Korisnik (IdUlogaKorisnika, AviokompanijaKorisnika, Ime, Prezime, AdresaKorisnika, KontaktTelefon, EmailAdresaKorisnika, OIBKorisnika, KorisnickoIme, Lozinka) " +
                $"VALUES('{1}', {sqlNULL}, '{korisnik.ImeKorisnika}', '{korisnik.PrezimeKorisnika}', '{korisnik.AdresaKorisnika}', '{korisnik.KontaktTelefonKorisnika}', '{korisnik.EmailKorisnika}', '{korisnik.OIBKorisnika}', '{korisnik.KorisnickoImeKorisnika}', '{korisnik.LozinkaKorisnika}');";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int DodajRacun(string id)
        {
            string brojRacuna = "";
            Random r = new Random();
            r.Next();

            for (int i = 0; i < 16; i++)
            {
                brojRacuna += r.Next(0,9);
            }

            Database.Instance.Connect();
            string sql = "INSERT INTO Racun (IdKorisnik, BrojRacuna, StanjeRacuna)" +
                $"VALUES('{id}','{brojRacuna}', '5000');";
            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static List<Korisnik> DohvatiSveKorisnike()
        {
            string sql = "SELECT * FROM Korisnik k " +
                "INNER JOIN UlogaKorisnika u ON k.IdUlogaKorisnika = u.UlogaKorisnikaId " +
                "LEFT JOIN Aviokompanija a ON k.AviokompanijaKorisnika = a.AviokompanijaId;";

            List<Korisnik> korisnik = DohvatiPodatkeKorisnika(sql);

            return korisnik;
        }

        private static List<Korisnik> DohvatiPodatkeKorisnika(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Korisnik> korisnici = new List<Korisnik>();
            while (dataReader.Read())
            {
                UlogaKorisnika uloga = new UlogaKorisnika();
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Administrator")
                {
                    uloga = UlogaKorisnika.Administrator;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Moderator")
                {
                    uloga = UlogaKorisnika.Moderator;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Owner")
                {
                    uloga = UlogaKorisnika.Owner;
                }
                if (dataReader["NazivUlogeKorisnika"].ToString() == "Registrirani korisnik")
                {
                    uloga = UlogaKorisnika.RegistriraniKorisnik;
                }
                bool aviokompanijaNull = dataReader.IsDBNull(dataReader.GetOrdinal("AviokompanijaKorisnika"));
                if (!aviokompanijaNull)
                {
                    Aviokompanija aviokompanija = new Aviokompanija()
                    {
                        AviokompanijaId = (int)dataReader["AviokompanijaId"],
                        NazivAviokompanije = dataReader["NazivAviokompanije"].ToString(),
                        OIBAviokompanije = dataReader["OIBAviokompanije"].ToString(),
                        IBANAviokompanije = dataReader["IBANAviokompanije"].ToString(),
                        AdresaAviokompanije = dataReader["AdresaAviokompanije"].ToString(),
                        KontaktAviokompanije = dataReader["KontaktTelefonAviokompanije"].ToString(),
                        EmailAviokompanije = dataReader["EmailAviokompanije"].ToString()
                    };

                    Korisnik korisnik = new Korisnik()
                    {
                        KorisnikId = (int)dataReader["KorisnikId"],
                        UlogaKorisnika = uloga,
                        Aviokompanija = aviokompanija,
                        ImeKorisnika = dataReader["Ime"].ToString(),
                        PrezimeKorisnika = dataReader["Prezime"].ToString(),
                        AdresaKorisnika = dataReader["AdresaKorisnika"].ToString(),
                        KontaktTelefonKorisnika = dataReader["KontaktTelefon"].ToString(),
                        EmailKorisnika = dataReader["EmailAdresaKorisnika"].ToString(),
                        OIBKorisnika = dataReader["OIBKorisnika"].ToString(),
                        KorisnickoImeKorisnika = dataReader["KorisnickoIme"].ToString(),
                        LozinkaKorisnika = dataReader["Lozinka"].ToString()

                    };
                    korisnici.Add(korisnik);
                }
                else
                {
                    Korisnik korisnik = new Korisnik()
                    {
                        KorisnikId = (int)dataReader["KorisnikId"],
                        UlogaKorisnika = uloga,
                        Aviokompanija = null,
                        ImeKorisnika = dataReader["Ime"].ToString(),
                        PrezimeKorisnika = dataReader["Prezime"].ToString(),
                        AdresaKorisnika = dataReader["AdresaKorisnika"].ToString(),
                        KontaktTelefonKorisnika = dataReader["KontaktTelefon"].ToString(),
                        EmailKorisnika = dataReader["EmailAdresaKorisnika"].ToString(),
                        OIBKorisnika = dataReader["OIBKorisnika"].ToString(),
                        KorisnickoImeKorisnika = dataReader["KorisnickoIme"].ToString(),
                        LozinkaKorisnika = dataReader["Lozinka"].ToString()

                    };
                    korisnici.Add(korisnik);
                }
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return korisnici;
        }

        public static List<Let> DohvatiLetove(Aerodrom polazisniAerodrom, Aerodrom odredisniAerodrom)
        {
            string sql = "SELECT LetId as letId, BrojLeta as brojLeta, DatumVrijemePolaska as datumVrijemePolaska, DatumVrijemeDolaska as datumVrijemeDolaska, CijenaKarte as cijenaKarte, BrojSlobodnihMjesta as brojSlobodnihMjesta, polazisni.AerodromId as idPolazisnogAerodroma, polazisni.NazivAerodroma as nazivPolazisnogAerodroma, polazisni.OznakaAerodroma as oznakaPolazisnogAerodroma, polazisni.AdresaAerodroma as adresaPolazisnogAerodroma, polazisni.OIBAerodroma as oibPolazisnogAerodroma, polazisni.KontaktTelefonAerodroma as kontaktPolazisnogAerodroma, polazisni.EmailAerodroma as emailPolazisnogAerodroma, odredisni.AerodromId as idOdredisnogAerodroma, odredisni.NazivAerodroma as nazivOdredisnoAerodroma, odredisni.OznakaAerodroma as oznakaOdredisnogAerodroma, odredisni.AdresaAerodroma as adresaOdredisnogAerodroma, odredisni.OIBAerodroma as oibOdredisnogAerodroma, odredisni.KontaktTelefonAerodroma as kontaktOdredisnogAerodroma, odredisni.EmailAerodroma as emailOdreisnogAerodroma, a.AvionId as idAviona, a.RegistarskaOznakaAviona as identifikatorAviona, a.ProizvodacAviona as proizvodacAviona, a.ModelAviona as modelAviona, a.BrojSjedalaAviona as brojMjesta, ak.AviokompanijaId as idAviokompanije, ak.NazivAviokompanije as nazivAviokompanije, ak.OIBAviokompanije as oibAviokompanijem, ak.AdresaAviokompanije as adresaAviokompanije, ak.KontaktTelefonAviokompanije as kontaktAviokompanije, ak.EmailAviokompanije as emailAviokompanije, ak.IBANAviokompanije as ibanAviokompanije FROM Let l " +
                "INNER JOIN Aerodrom polazisni ON l.PolazisniAerodrom = polazisni.AerodromId " +
                "INNER JOIN Aerodrom odredisni ON l.OdredisniAerodrom = odredisni.AerodromId " +
                "INNER JOIN Avion a ON l.IdAvion = a.AvionId " +
                "INNER JOIN Aviokompanija ak ON a.IdAviokompanije = ak.AviokompanijaId " +
                $"WHERE polazisni.AerodromId = {polazisniAerodrom.AerodromId} AND odredisni.AerodromId = {odredisniAerodrom.AerodromId};";

            List<Let> letovi = DohvatiPodatkeLetova(sql);

            return letovi;
        }

        public static List<Let> DohvatiLetove(Aerodrom polazisniAerodrom, Aerodrom odredisniAerodrom, string datumVrijemePolaska)
        {
            string sql = "SELECT LetId as letId, BrojLeta as brojLeta, DatumVrijemePolaska as datumVrijemePolaska, DatumVrijemeDolaska as datumVrijemeDolaska, CijenaKarte as cijenaKarte, BrojSlobodnihMjesta as brojSlobodnihMjesta, polazisni.AerodromId as idPolazisnogAerodroma, polazisni.NazivAerodroma as nazivPolazisnogAerodroma, polazisni.OznakaAerodroma as oznakaPolazisnogAerodroma, polazisni.AdresaAerodroma as adresaPolazisnogAerodroma, polazisni.OIBAerodroma as oibPolazisnogAerodroma, polazisni.KontaktTelefonAerodroma as kontaktPolazisnogAerodroma, polazisni.EmailAerodroma as emailPolazisnogAerodroma, odredisni.AerodromId as idOdredisnogAerodroma, odredisni.NazivAerodroma as nazivOdredisnoAerodroma, odredisni.OznakaAerodroma as oznakaOdredisnogAerodroma, odredisni.AdresaAerodroma as adresaOdredisnogAerodroma, odredisni.OIBAerodroma as oibOdredisnogAerodroma, odredisni.KontaktTelefonAerodroma as kontaktOdredisnogAerodroma, odredisni.EmailAerodroma as emailOdreisnogAerodroma, a.AvionId as idAviona, a.RegistarskaOznakaAviona as identifikatorAviona, a.ProizvodacAviona as proizvodacAviona, a.ModelAviona as modelAviona, a.BrojSjedalaAviona as brojMjesta, ak.AviokompanijaId as idAviokompanije, ak.NazivAviokompanije as nazivAviokompanije, ak.OIBAviokompanije as oibAviokompanijem, ak.AdresaAviokompanije as adresaAviokompanije, ak.KontaktTelefonAviokompanije as kontaktAviokompanije, ak.EmailAviokompanije as emailAviokompanije, ak.IBANAviokompanije as ibanAviokompanije FROM Let l " +
                "INNER JOIN Aerodrom polazisni ON l.PolazisniAerodrom = polazisni.AerodromId " +
                "INNER JOIN Aerodrom odredisni ON l.OdredisniAerodrom = odredisni.AerodromId " +
                "INNER JOIN Avion a ON l.IdAvion = a.AvionId " +
                "INNER JOIN Aviokompanija ak ON a.IdAviokompanije = ak.AviokompanijaId " +
                $"WHERE DatumVrijemePolaska LIKE '{datumVrijemePolaska}%' AND polazisni.AerodromId = {polazisniAerodrom.AerodromId} AND odredisni.AerodromId = {odredisniAerodrom.AerodromId};";

            List<Let> letovi = DohvatiPodatkeLetova(sql);

            return letovi;
        }

        public static List<Let> DohvatiLetove(int AviokompanijaId)
        {
            string sql = "SELECT LetId as letId, BrojLeta as brojLeta, DatumVrijemePolaska as datumVrijemePolaska, DatumVrijemeDolaska as datumVrijemeDolaska, CijenaKarte as cijenaKarte, BrojSlobodnihMjesta as brojSlobodnihMjesta , polazisni.AerodromId as idPolazisnogAerodroma, polazisni.NazivAerodroma as nazivPolazisnogAerodroma, polazisni.OznakaAerodroma as oznakaPolazisnogAerodroma, polazisni.AdresaAerodroma as adresaPolazisnogAerodroma, polazisni.OIBAerodroma as oibPolazisnogAerodroma, polazisni.KontaktTelefonAerodroma as kontaktPolazisnogAerodroma, polazisni.EmailAerodroma as emailPolazisnogAerodroma, odredisni.AerodromId as idOdredisnogAerodroma, odredisni.NazivAerodroma as nazivOdredisnoAerodroma, odredisni.OznakaAerodroma as oznakaOdredisnogAerodroma, odredisni.AdresaAerodroma as adresaOdredisnogAerodroma, odredisni.OIBAerodroma as oibOdredisnogAerodroma, odredisni.KontaktTelefonAerodroma as kontaktOdredisnogAerodroma, odredisni.EmailAerodroma as emailOdreisnogAerodroma, a.AvionId as idAviona, a.RegistarskaOznakaAviona as identifikatorAviona, a.ProizvodacAviona as proizvodacAviona, a.ModelAviona as modelAviona, a.BrojSjedalaAviona as brojMjesta, ak.AviokompanijaId as idAviokompanije, ak.NazivAviokompanije as nazivAviokompanije, ak.OIBAviokompanije as oibAviokompanijem, ak.AdresaAviokompanije as adresaAviokompanije, ak.KontaktTelefonAviokompanije as kontaktAviokompanije, ak.EmailAviokompanije as emailAviokompanije, ak.IBANAviokompanije as ibanAviokompanije FROM Let l " +
                "INNER JOIN Aerodrom polazisni ON l.PolazisniAerodrom = polazisni.AerodromId " +
                "INNER JOIN Aerodrom odredisni ON l.OdredisniAerodrom = odredisni.AerodromId " +
                "INNER JOIN Avion a ON l.IdAvion = a.AvionId " +
                "INNER JOIN Aviokompanija ak ON a.IdAviokompanije = ak.AviokompanijaId " +
                $"WHERE idAviokompanije = {AviokompanijaId};";

            List<Let> letovi = DohvatiPodatkeLetova(sql);

            return letovi;
        }

        public static List<Let> DohvatiSveLetove()
        {
            string sql = "SELECT LetId as letId, BrojLeta as brojLeta, DatumVrijemePolaska as datumVrijemePolaska, DatumVrijemeDolaska as datumVrijemeDolaska, CijenaKarte as cijenaKarte, BrojSlobodnihMjesta as brojSlobodnihMjesta , polazisni.AerodromId as idPolazisnogAerodroma, polazisni.NazivAerodroma as nazivPolazisnogAerodroma, polazisni.OznakaAerodroma as oznakaPolazisnogAerodroma, polazisni.AdresaAerodroma as adresaPolazisnogAerodroma, polazisni.OIBAerodroma as oibPolazisnogAerodroma, polazisni.KontaktTelefonAerodroma as kontaktPolazisnogAerodroma, polazisni.EmailAerodroma as emailPolazisnogAerodroma, odredisni.AerodromId as idOdredisnogAerodroma, odredisni.NazivAerodroma as nazivOdredisnoAerodroma, odredisni.OznakaAerodroma as oznakaOdredisnogAerodroma, odredisni.AdresaAerodroma as adresaOdredisnogAerodroma, odredisni.OIBAerodroma as oibOdredisnogAerodroma, odredisni.KontaktTelefonAerodroma as kontaktOdredisnogAerodroma, odredisni.EmailAerodroma as emailOdreisnogAerodroma, a.AvionId as idAviona, a.RegistarskaOznakaAviona as identifikatorAviona, a.ProizvodacAviona as proizvodacAviona, a.ModelAviona as modelAviona, a.BrojSjedalaAviona as brojMjesta, ak.AviokompanijaId as idAviokompanije, ak.NazivAviokompanije as nazivAviokompanije, ak.OIBAviokompanije as oibAviokompanijem, ak.AdresaAviokompanije as adresaAviokompanije, ak.KontaktTelefonAviokompanije as kontaktAviokompanije, ak.EmailAviokompanije as emailAviokompanije, ak.IBANAviokompanije as ibanAviokompanije FROM Let l " +
                "INNER JOIN Aerodrom polazisni ON l.PolazisniAerodrom = polazisni.AerodromId " +
                "INNER JOIN Aerodrom odredisni ON l.OdredisniAerodrom = odredisni.AerodromId " +
                "INNER JOIN Avion a ON l.IdAvion = a.AvionId " +
                "INNER JOIN Aviokompanija ak ON a.IdAviokompanije = ak.AviokompanijaId;";

            List<Let> letovi = DohvatiPodatkeLetova(sql);

            return letovi;
        }

        public static List<Aviokompanija> DohvatiAviokompanije()
        {
            string sql = "SELECT * FROM Aviokompanija;";

            List<Aviokompanija> aviokompanije = DohvatiPodatkeAviokompanija(sql);

            return aviokompanije;
        }

        public static int DodajLet(Let let)
        {
            Database.Instance.Connect();

            string sql = "INSERT INTO Let (BrojLeta, PolazisniAerodrom, OdredisniAerodrom, IdAvion, DatumVrijemePolaska, DatumVrijemeDolaska, CijenaKarte, BrojSlobodnihMjesta) " +
                $"VALUES('{let.BrojLeta}', {let.PolazisniAerodrom.AerodromId}, {let.OdredisniAerodrom.AerodromId}, {let.AvionNaLetu.AvionId}, '{let.DatumPolaska.ToString("yyyy-MM-dd HH:mm:ss")}', '{let.DatumDolaska.ToString("yyyy-MM-dd HH:mm:ss")}', {let.CijenaKarte}, {let.BrojSlobodnihMjesta});";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int AzurirajLet(Let let)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Let SET BrojLeta = '{let.BrojLeta}', PolazisniAerodrom = {let.PolazisniAerodrom.AerodromId}, OdredisniAerodrom = {let.OdredisniAerodrom.AerodromId}, IdAvion = {let.AvionNaLetu.AvionId}, DatumVrijemePolaska = '{let.DatumPolaska.ToString("yyyy-MM-dd HH:mm:ss")}', DatumVrijemeDolaska = '{let.DatumDolaska.ToString("yyyy-MM-dd HH:mm:ss")}', CijenaKarte = {let.CijenaKarte}, BrojSlobodnihMjesta = {let.BrojSlobodnihMjesta}" +
                $"WHERE LetId = {let.LetId};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static void ObrisiRezervacije(Let let)
        {
            Database.Instance.Connect();

            string sql = "DELETE FROM Rezervacija " +
                $"WHERE IdLetaRezervacije = '{let.LetId}';";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

        }

        public static void ObrisiKorisnika(string id)
        {
            string sql = "DELETE FROM Korisnik " +
                $"WHERE KorisnikId = '{id}';";
            Database.Instance.ExecuteCommand(sql);
        }

        public static int ObrisiLet(Let let)
        {
            Database.Instance.Connect();

            string sql = "DELETE FROM Let " +
                $"WHERE LetId = '{let.LetId}';";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static List<Aerodrom> DohvatiAerodrome()
        {
            string sql = "SELECT * FROM Aerodrom;";

            List<Aerodrom> aerodromi = DohvatiPodatkeAerodroma(sql);

            return aerodromi;
        }

        public static List<Avion> DohvatiAvione()
        {
            string sql = "SELECT * FROM Avion " +
                "INNER JOIN Aviokompanija ON IdAviokompanije = AviokompanijaId " +
                $"WHERE IdAviokompanije = {RepozitorijSkyFlyReservation.prijavljeniKorisnik.Aviokompanija.AviokompanijaId};";

            List<Avion> avioni = DohvatiPodatkeAviona(sql);

            return avioni;
        }

        public static List<Avion> DohvatiAvione(int aviokompanijaId)
        {
            string sql = "SELECT * FROM Avion " +
                "INNER JOIN Aviokompanija ON IdAviokompanije = AviokompanijaId " +
                $"WHERE IdAviokompanije = {aviokompanijaId};";

            List<Avion> avioni = DohvatiPodatkeAviona(sql);

            return avioni;
        }

        public static List<Avion> DohvatiSveAvione()
        {
            string sql = "SELECT * FROM Avion " +
                "INNER JOIN Aviokompanija ON IdAviokompanije = AviokompanijaId;";

            List<Avion> avioni = DohvatiPodatkeAviona(sql);

            return avioni;
        }

        public static List<Sjedalo> DohvatiRezerviranaSjedala(Let let)
        {
            string sql = "SELECT SjedaloId as sjedaloId, OznakaSjedala as oznakaSjedala, BrojSlobodnihMjesta as brojSlobodnihMjesta, BrojSjedalaAviona as brojSjedalaAviona FROM Rezervacija r " +
                "INNER JOIN SjedaloUAvionu sa ON r.IdSjedalo = sa.SjedaloId " +
                "INNER JOIN Let l ON r.IdLetaRezervacije = l.LetId " +
                "INNER JOIN Avion a ON l.IdAvion = a.AvionId " +
                $"WHERE IdLetaRezervacije = {let.LetId};";

            List<Sjedalo> rezerviranaSjedala = DohvatiPodatkeRezerviranihSjedala(sql);

            return rezerviranaSjedala;
        }

        public static Sjedalo DohvatiSjedalo(string oznakaSjedala)
        {
            string sql = "SELECT * FROM SjedaloUAvionu " +
                $"WHERE OznakaSjedala = '{oznakaSjedala}';";

            Sjedalo sjedalo = DohvatiPodatkeSjedala(sql);

            return sjedalo;
        }

        public static int DodajRezervacijuKarte(Rezervacija rezervacija)
        {
            Database.Instance.Connect();

            string sql = "INSERT INTO Rezervacija (IdKorisnik, IdLetaRezervacije, IdSjedalo, DatumVrijemeRezervacije, StatusRezervacije) " +
                $"VALUES({rezervacija.KorisnikRezervacije.KorisnikId}, {rezervacija.LetRezervacije.LetId}, {rezervacija.RezerviranoSjedalo.SjedaloId}, '{rezervacija.DatumVrijemeRezervacije.ToString("yyyy-MM-dd HH:mm:ss")}', 0);";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int AzurirajRezervaciju(Rezervacija rezervacija)
        {
            Database.Instance.Connect();

            string sql = "UPDATE Rezervacija SET StatusRezervacije = 1 " +
                $"WHERE RezervacijaId = {rezervacija.RezervacijaId};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int ObrisiRezervacijuKarte(Rezervacija rezervacija)
        {
            Database.Instance.Connect();

            string sql = "DELETE FROM Rezervacija " +
                $"WHERE RezervacijaId = {rezervacija.RezervacijaId};";

            string updateBrojMjesta = "UPDATE Let SET BrojSlobodnihMjesta = BrojSlobodnihMjesta + 1 " +
                $"WHERE LetId = {rezervacija.LetRezervacije.LetId};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);
            Database.Instance.ExecuteCommand(updateBrojMjesta);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }


        public static int DohvatiIdRezervacije(Let let, Sjedalo sjedalo)
        {
            Database.Instance.Connect();

            string sql = "SELECT RezervacijaId FROM Rezervacija " +
                $"WHERE IdLetaRezervacije = {let.LetId} AND IdSjedalo = {sjedalo.SjedaloId};";

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            int rezervacijaId = 0;

            while (dataReader.Read())
            {
                rezervacijaId = (int)dataReader["RezervacijaId"];
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return rezervacijaId;
        }

        public static int DodajKupnjuKarte(Let let, Sjedalo sjedalo, int korisnikId)
        {
            Database.Instance.Connect();

            string sql = "INSERT INTO Rezervacija (IdKorisnik, IdLetaRezervacije, IdSjedalo, DatumVrijemeRezervacije, StatusRezervacije) " +
                $"VALUES({korisnikId}, {let.LetId}, {sjedalo.SjedaloId}, '{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}', 1);";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int AzurirajBrojSlobodnihMjesta(Let let)
        {
            Database.Instance.Connect();

            string sql = "UPDATE Let SET BrojSlobodnihMjesta = BrojSlobodnihMjesta - 1 " +
                $"WHERE LetId = {let.LetId};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int DodajAvion(Avion avion)
        {
            Database.Instance.Connect();

            string sql = "INSERT INTO Avion (IdAviokompanije, RegistarskaOznakaAviona, ProizvodacAviona, ModelAviona, BrojSjedalaAviona) " +
                $"VALUES({avion.Aviokompanija.AviokompanijaId}, '{avion.IdentifikatorAviona}', '{avion.ProizvodacAviona}', '{avion.ModelAviona}', {avion.BrojMjesta});";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int AzurirajAvion(Avion avion)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Avion SET RegistarskaOznakaAviona = '{avion.IdentifikatorAviona}', ProizvodacAviona = '{avion.ProizvodacAviona}', ModelAviona = '{avion.ModelAviona}', BrojSjedalaAviona = {avion.BrojMjesta}, IdAviokompanije = {avion.Aviokompanija.AviokompanijaId} " +
                $"WHERE AvionId = {avion.AvionId};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int ObrisiAvion(Avion avion)
        {
            Database.Instance.Connect();

            string sql = $"DELETE FROM Avion WHERE AvionId = {avion.AvionId};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static Racun DohvatiRacunKorisnika(int korisnikId)
        {
            string sql = "SELECT * FROM Racun " +
                $"WHERE IdKorisnik = {korisnikId};";

            Racun racunKorisnika = DohvatiPodatkeRacuna(sql);

            return racunKorisnika;
        }

        public static int AzurirajStanjeRacunaPlatitelja(Racun racun, Let let)
        {
            Database.Instance.Connect();

            string sql = $"UPDATE Racun SET StanjeRacuna = StanjeRacuna - {let.CijenaKarte} " +
                $"WHERE BrojRacuna = {racun.BrojRacuna};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static int AzurirajStanjeRacunaPrimatelja(Let let)
        {
            string sqlKorisnikId = "SELECT KorisnikId FROM Korisnik " +
                $"WHERE AviokompanijaKorisnika = {let.AvionNaLetu.Aviokompanija.AviokompanijaId};";

            int korisnikId = DohvatiIdKorisnika(sqlKorisnikId);


            Database.Instance.Connect();

            string sql = $"UPDATE Racun SET StanjeRacuna = StanjeRacuna + {let.CijenaKarte} " +
                $"WHERE IdKorisnik = {korisnikId};";

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

            Database.Instance.Disconnect();

            return numAffectedRows;
        }

        public static List<Rezervacija> DohvatiRezervacijeKorisnika(int korisnikId)
        {
            string sql = "SELECT l.LetId as letId, l.BrojLeta as brojLeta, l.DatumVrijemePolaska as datumPolaska, l.DatumVrijemeDolaska as datumDolaska, l.CijenaKarte as cijenaKarte, l.BrojSlobodnihMjesta as brojSlobodnihMjesta, sa.SjedaloId as sjedaloId, sa.OznakaSjedala as oznakaSjedala, pa.AerodromId as polazisniAerodromId, pa.NazivAerodroma as polazisniNazivAerodroma, pa.OznakaAerodroma as polazisniOznakaAerodroma, pa.AdresaAerodroma as polazisniAdresaAerodroma, pa.OIBAerodroma as polazisniOibAerodroma, pa.KontaktTelefonAerodroma as polazisniAerodromKontakt, pa.EmailAerodroma as polazisniAerodromEmail, oa.AerodromId as odredisniAerodromId, oa.NazivAerodroma as odredisniNazivAerodroma, oa.OznakaAerodroma as odredisniOznakaAerodroma, oa.AdresaAerodroma as odredisniAdresaAerodroma, oa.OIBAerodroma as odredisniOibAerodroma, oa.KontaktTelefonAerodroma as odredisniAerodromKontakt, oa.EmailAerodroma as odredisniAerodromEmail, a.AvionId as avionId, a.RegistarskaOznakaAviona as identifikatorAviona, a.ProizvodacAviona as proizvodacAviona, a.ModelAviona as modelAviona, a.BrojSjedalaAviona as brojSjedalaAviona, ak.AviokompanijaId as aviokompanijaId, ak.NazivAviokompanije as nazivAviokompanije, ak.OIBAviokompanije as oibAviokomapnije, ak.IBANAviokompanije as ibanAviokompanije, ak.AdresaAviokompanije as adresaAviokompanije, ak.KontaktTelefonAviokompanije as kontaktTelefonAviokompanije, ak.EmailAviokompanije as emailAviokompanije, r.DatumVrijemeRezervacije as datumVrijemeRezervacije, r.RezervacijaId as rezervacijaId, r.StatusRezervacije as statusRezervacije FROM Rezervacija r " +
                "INNER JOIN Let l ON r.IdLetaRezervacije = l.LetId " +
                "INNER JOIN SjedaloUAvionu sa ON r.IdSjedalo = sa.SjedaloId " +
                "INNER JOIN Aerodrom pa ON l.PolazisniAerodrom = pa.AerodromId " +
                "INNER JOIN Aerodrom oa ON l.OdredisniAerodrom = oa.AerodromId " +
                "INNER JOIN Avion a ON l.IdAvion = a.AvionId " +
                "INNER JOIN Aviokompanija ak ON a.IdAviokompanije = ak.AviokompanijaId " +
                $"WHERE r.IdKorisnik = {RepozitorijSkyFlyReservation.prijavljeniKorisnik.KorisnikId};";

            List<Rezervacija> rezervacijeKorisnika = DohvatiPodatkeRezervacija(sql);

            return rezervacijeKorisnika;
        }

        private static List<Avion> DohvatiPodatkeAviona(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Avion> avioni = new List<Avion>();
            while (dataReader.Read())
            {
                Aviokompanija aviokompanija = new Aviokompanija()
                {
                    AviokompanijaId = (int)dataReader["AviokompanijaId"],
                    NazivAviokompanije = dataReader["NazivAviokompanije"].ToString(),
                    OIBAviokompanije = dataReader["OIBAviokompanije"].ToString(),
                    IBANAviokompanije = dataReader["IBANAviokompanije"].ToString(),
                    AdresaAviokompanije = dataReader["AdresaAviokompanije"].ToString(),
                    KontaktAviokompanije = dataReader["KontaktTelefonAviokompanije"].ToString(),
                    EmailAviokompanije = dataReader["EmailAviokompanije"].ToString()
                };

                Avion avion = new Avion()
                {
                    AvionId = (int)dataReader["AvionId"],
                    IdentifikatorAviona = dataReader["RegistarskaOznakaAviona"].ToString(),
                    ProizvodacAviona = dataReader["ProizvodacAviona"].ToString(),
                    ModelAviona = dataReader["ModelAviona"].ToString(),
                    BrojMjesta = (int)dataReader["BrojSjedalaAviona"],
                    Aviokompanija = aviokompanija
                };

                avioni.Add(avion);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return avioni;
        }

        private static List<Aerodrom> DohvatiPodatkeAerodroma(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Aerodrom> aerodromi = new List<Aerodrom>();

            while (dataReader.Read())
            {
                Aerodrom aerodrom = new Aerodrom()
                {
                    AerodromId = (int)dataReader["AerodromId"],
                    NazivAerodroma = dataReader["NazivAerodroma"].ToString(),
                    OznakaAerodroma = dataReader["OznakaAerodroma"].ToString(),
                    AdresaAerodorma = dataReader["AdresaAerodroma"].ToString(),
                    OIBAerodroma = dataReader["OIBAerodroma"].ToString(),
                    KontaktAerodroma = dataReader["KontaktTelefonAerodroma"].ToString(),
                    EmailAerodroma = dataReader["EmailAerodroma"].ToString()
                };

                aerodromi.Add(aerodrom);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return aerodromi;
        }

        private static List<Let> DohvatiPodatkeLetova(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Let> letovi = new List<Let>();

            while (dataReader.Read())
            {
                Aerodrom polazisniAerodrom = new Aerodrom()
                {
                    AerodromId = (int)dataReader["idPolazisnogAerodroma"],
                    NazivAerodroma = dataReader["nazivPolazisnogAerodroma"].ToString(),
                    OznakaAerodroma = dataReader["oznakaPolazisnogAerodroma"].ToString(),
                    AdresaAerodorma = dataReader["adresaPolazisnogAerodroma"].ToString(),
                    OIBAerodroma = dataReader["oibPolazisnogAerodroma"].ToString(),
                    KontaktAerodroma = dataReader["kontaktPolazisnogAerodroma"].ToString(),
                    EmailAerodroma = dataReader["emailPolazisnogAerodroma"].ToString()
                };

                Aerodrom odredisniAerodrom = new Aerodrom()
                {
                    AerodromId = (int)dataReader["idOdredisnogAerodroma"],
                    NazivAerodroma = dataReader["nazivOdredisnoAerodroma"].ToString(),
                    OznakaAerodroma = dataReader["oznakaOdredisnogAerodroma"].ToString(),
                    AdresaAerodorma = dataReader["adresaOdredisnogAerodroma"].ToString(),
                    OIBAerodroma = dataReader["oibOdredisnogAerodroma"].ToString(),
                    KontaktAerodroma = dataReader["kontaktOdredisnogAerodroma"].ToString(),
                    EmailAerodroma = dataReader["emailOdreisnogAerodroma"].ToString()
                };

                Aviokompanija aviokompanija = new Aviokompanija()
                {
                    AviokompanijaId = (int)dataReader["idAviokompanije"],
                    NazivAviokompanije = dataReader["nazivAviokompanije"].ToString(),
                    OIBAviokompanije = dataReader["oibAviokompanijem"].ToString(),
                    AdresaAviokompanije = dataReader["adresaAviokompanije"].ToString(),
                    KontaktAviokompanije = dataReader["kontaktAviokompanije"].ToString(),
                    EmailAviokompanije = dataReader["emailAviokompanije"].ToString(),
                    IBANAviokompanije = dataReader["ibanAviokompanije"].ToString()
                };

                Avion avion = new Avion()
                {
                    AvionId = (int)dataReader["idAviona"],
                    IdentifikatorAviona = dataReader["identifikatorAviona"].ToString(),
                    ProizvodacAviona = dataReader["proizvodacAviona"].ToString(),
                    ModelAviona = dataReader["modelAviona"].ToString(),
                    BrojMjesta = (int)dataReader["brojMjesta"],
                    Aviokompanija = aviokompanija
                };


                Let let = new Let()
                {
                    LetId = (int)dataReader["letId"],
                    BrojLeta = dataReader["brojLeta"].ToString(),
                    PolazisniAerodrom = polazisniAerodrom,
                    OdredisniAerodrom = odredisniAerodrom,
                    AvionNaLetu = avion,
                    DatumPolaska = (DateTime)dataReader["datumVrijemePolaska"],
                    DatumDolaska = (DateTime)dataReader["datumVrijemeDolaska"],
                    CijenaKarte = (double)dataReader["cijenaKarte"],
                    BrojSlobodnihMjesta = (int)dataReader["brojSlobodnihMjesta"]
                };

                if (let.DatumPolaska > DateTime.Now)
                {
                    letovi.Add(let);
                }

            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return letovi;
        }

        private static List<Sjedalo> DohvatiPodatkeRezerviranihSjedala(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Sjedalo> rezerviranaSjedala = new List<Sjedalo>();

            while (dataReader.Read())
            {
                Sjedalo sjedalo = new Sjedalo()
                {
                    SjedaloId = (int)dataReader["sjedaloId"],
                    OznakaSjedala = dataReader["oznakaSjedala"].ToString().Trim(),
                };

                rezerviranaSjedala.Add(sjedalo);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return rezerviranaSjedala;
        }

        private static Sjedalo DohvatiPodatkeSjedala(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            Sjedalo sjedalo = new Sjedalo();

            while (dataReader.Read())
            {
                sjedalo.SjedaloId = (int)dataReader["sjedaloId"];
                sjedalo.OznakaSjedala = dataReader["oznakaSjedala"].ToString().Trim();
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return sjedalo;
        }

        private static List<Rezervacija> DohvatiPodatkeRezervacija(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Rezervacija> rezervacijeKorisnika = new List<Rezervacija>();

            while (dataReader.Read())
            {
                Aviokompanija aviokompanija = new Aviokompanija()
                {
                    AviokompanijaId = (int)dataReader["aviokompanijaId"],
                    NazivAviokompanije = dataReader["nazivAviokompanije"].ToString(),
                    OIBAviokompanije = dataReader["oibAviokomapnije"].ToString(),
                    IBANAviokompanije = dataReader["ibanAviokompanije"].ToString(),
                    AdresaAviokompanije = dataReader["adresaAviokompanije"].ToString(),
                    KontaktAviokompanije = dataReader["kontaktTelefonAviokompanije"].ToString(),
                    EmailAviokompanije = dataReader["emailAviokompanije"].ToString()
                };

                Avion avion = new Avion()
                {
                    AvionId = (int)dataReader["avionId"],
                    IdentifikatorAviona = dataReader["identifikatorAviona"].ToString(),
                    ProizvodacAviona = dataReader["proizvodacAviona"].ToString(),
                    ModelAviona = dataReader["modelAviona"].ToString(),
                    BrojMjesta = (int)dataReader["brojSjedalaAviona"],
                    Aviokompanija = aviokompanija
                };

                Aerodrom polazisni = new Aerodrom()
                {
                    AerodromId = (int)dataReader["polazisniAerodromId"],
                    NazivAerodroma = dataReader["polazisniNazivAerodroma"].ToString(),
                    OznakaAerodroma = dataReader["polazisniOznakaAerodroma"].ToString(),
                    AdresaAerodorma = dataReader["polazisniAdresaAerodroma"].ToString(),
                    OIBAerodroma = dataReader["polazisniOibAerodroma"].ToString(),
                    KontaktAerodroma = dataReader["polazisniAerodromKontakt"].ToString(),
                    EmailAerodroma = dataReader["polazisniAerodromEmail"].ToString()
                };

                Aerodrom odredisni = new Aerodrom()
                {
                    AerodromId = (int)dataReader["odredisniAerodromId"],
                    NazivAerodroma = dataReader["odredisniNazivAerodroma"].ToString(),
                    OznakaAerodroma = dataReader["odredisniOznakaAerodroma"].ToString(),
                    AdresaAerodorma = dataReader["odredisniAdresaAerodroma"].ToString(),
                    OIBAerodroma = dataReader["odredisniOibAerodroma"].ToString(),
                    KontaktAerodroma = dataReader["odredisniAerodromKontakt"].ToString(),
                    EmailAerodroma = dataReader["odredisniAerodromEmail"].ToString()
                };

                Let let = new Let()
                {
                    LetId = (int)dataReader["letId"],
                    BrojLeta = dataReader["brojLeta"].ToString(),
                    PolazisniAerodrom = polazisni,
                    OdredisniAerodrom = odredisni,
                    AvionNaLetu = avion,
                    DatumPolaska = (DateTime)dataReader["datumPolaska"],
                    DatumDolaska = (DateTime)dataReader["datumDolaska"],
                    CijenaKarte = double.Parse(dataReader["cijenaKarte"].ToString()),
                    BrojSlobodnihMjesta = int.Parse(dataReader["brojSlobodnihMjesta"].ToString())
                };

                Sjedalo sjedalo = new Sjedalo()
                {
                    SjedaloId = (int)dataReader["sjedaloId"],
                    OznakaSjedala = dataReader["oznakaSjedala"].ToString().Trim()
                };


                StanjeRezervacije statusRezervacije = StanjeRezervacije.Plaćena;

                if (dataReader["statusRezervacije"].ToString() == "0")
                {
                    if (let.DatumPolaska.CompareTo((DateTime)dataReader["datumVrijemeRezervacije"]) < 0)
                    {
                        statusRezervacije = StanjeRezervacije.Istekla;
                    }
                    else
                    {
                        statusRezervacije = StanjeRezervacije.Neplaćena;
                    }
                }
                else
                {
                    statusRezervacije = StanjeRezervacije.Plaćena;
                }

                Rezervacija rezervacija = new Rezervacija()
                {
                    RezervacijaId = (int)dataReader["rezervacijaId"],
                    LetRezervacije = let,
                    KorisnikRezervacije = RepozitorijSkyFlyReservation.prijavljeniKorisnik,
                    RezerviranoSjedalo = sjedalo,
                    DatumVrijemeRezervacije = (DateTime)dataReader["datumVrijemeRezervacije"],
                    StatusRezervacije = statusRezervacije
                };

                rezervacijeKorisnika.Add(rezervacija);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return rezervacijeKorisnika;
        }

        private static List<Aviokompanija> DohvatiPodatkeAviokompanija(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);

            List<Aviokompanija> aviokompanije = new List<Aviokompanija>();

            while (dataReader.Read())
            {
                Aviokompanija aviokompanija = new Aviokompanija()
                {
                    AviokompanijaId = (int)dataReader["AviokompanijaId"],
                    NazivAviokompanije = dataReader["NazivAviokompanije"].ToString(),
                    OIBAviokompanije = dataReader["OIBAviokompanije"].ToString(),
                    IBANAviokompanije = dataReader["IBANAviokompanije"].ToString(),
                    AdresaAviokompanije = dataReader["AdresaAviokompanije"].ToString(),
                    KontaktAviokompanije = dataReader["KontaktTelefonAviokompanije"].ToString(),
                    EmailAviokompanije = dataReader["EmailAviokompanije"].ToString()
                };

                aviokompanije.Add(aviokompanija);
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return aviokompanije;
        }

        private static Racun DohvatiPodatkeRacuna(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            Racun racun = null;

            while (dataReader.Read())
            {
                racun = new Racun()
                {
                    RacunId = (int)dataReader["RacunId"],
                    BrojRacuna = dataReader["BrojRacuna"].ToString(),
                    StanjeRacuna = double.Parse(dataReader["StanjeRacuna"].ToString())
                };
            }

            return racun;
        }

        private static int DohvatiIdKorisnika(string sql)
        {
            Database.Instance.Connect();

            IDataReader dataReader = Database.Instance.GetDataReader(sql);
            int korisnikId = 0;

            while (dataReader.Read())
            {
                korisnikId = (int)dataReader["KorisnikId"];
            }

            dataReader.Close();
            Database.Instance.Disconnect();

            return korisnikId;
        }
    }
}