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
        //Služi za testiranje -> objekti klase Korisnik se instancira nakon autentikacije
        public static Aviokompanija aviokompanija = new Aviokompanija()
        {
            AviokompanijaId = 1,
            NazivAviokompanije = "Croatia Airlines",
            OIBAviokompanije = "24640993045",
            IBANAviokompanije = "HR9825000097121816575",
            AdresaAviokompanije = "Bani 75b, 10010, Zagreb",
            KontaktAviokompanije = "072 500 50",
            EmailAviokompanije = "contact@croatiaairlines.hr"
        };

        //Služi za testiranje -> objekti klase Korisnik se instancira nakon autentikacije
        public static Korisnik prijavljeniKorisnik = new Korisnik()
        {
            KorisnikId = 5,
            ImeKorisnika = "Patrik",
            PrezimeKorisnika = "Galina",
            OIBKorisnika = "123123123",
            AdresaKorisnika = "Madžarevo 212a",
            KontaktTelefonKorisnika = "124124124",
            EmailKorisnika = "pgalina@foi.hr",
            UlogaKorisnika = UlogaKorisnika.Administrator,
            Aviokompanija = aviokompanija
        };

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

            int numAffectedRows = Database.Instance.ExecuteCommand(sql);

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

            string sql = $"UPDATE Avion SET RegistarskaOznakaAviona = '{avion.IdentifikatorAviona}', ProizvodacAviona = '{avion.ProizvodacAviona}', ModelAviona = '{avion.ModelAviona}', BrojSjedalaAviona = {avion.BrojMjesta} " +
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

                if(let.DatumPolaska > DateTime.Now)
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

                if(dataReader["statusRezervacije"].ToString() == "0")
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
                    //PolazisniAerodrom = let.PolazisniAerodrom,
                    //OdredisniAerodrom = let.OdredisniAerodrom,
                    KorisnikRezervacije = RepozitorijSkyFlyReservation.prijavljeniKorisnik,
                    RezerviranoSjedalo = sjedalo,
                    DatumVrijemeRezervacije = (DateTime)dataReader["datumVrijemeRezervacije"],
                    StatusRezervacije = statusRezervacije
                };

                rezervacijeKorisnika.Add(rezervacija);
            }

            return rezervacijeKorisnika;
        }
    }
}
