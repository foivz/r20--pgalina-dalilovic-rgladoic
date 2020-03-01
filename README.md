# Inicijalne upute za prijavu projekta iz Programskog inženjerstva

Poštovane kolegice i kolege, 

čestitamo vam jer ste uspješno prijavili svoj projektni tim na kolegiju Programsko inženjerstvo, te je za vas automatski kreiran repozitorij koji ćete koristiti za verzioniranje vašega koda, ali i za pisanje dokumentacije.

Ovaj dokument (README.md) predstavlja **osobnu iskaznicu vašeg projekta**. Vaš prvi zadatak, ukoliko niste odabrali da želite raditi na projektu sa gospodarstvom je **prijaviti vlastiti projektni prijedlog** na način da ćete prijavu vašeg projekta, sukladno uputama danim u ovom tekstu, napisati upravo u ovaj dokument, umjesto ovoga teksta.

Za upute o sintaksi koju možete koristiti u ovom dokumentu i kod pisanje vaše projektne dokumentacije pogledajte [ovaj link](https://guides.github.com/features/mastering-markdown/).

Nakon vaše prijave bit će vam dodijeljen mentor s kojim ćete tijekom semestra raditi na ovom projektu. A sada, vrijeme je da prijavite vaš projekt. Za prijavu vašeg projektnog prijedloga molimo vas koristite **predložak** koji je naveden u nastavku, a započnite tako da kliknete na *olovku* u desnom gornjem kutu ovoga dokumenta :) 

# Izrada aplikacije za kupnju kino ulaznica

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Patrik Galina | pgalina@foi.hr | 0016133400 | pgalina1
Dario Alilović| dalilovic@foi.hr | 0016130019 | dalilovic1
Robert Gladoić | rgladoic@foi.hr | 0016130162 | rgladoic

## Opis domene
Ovaj projekt je orijentiran izradi aplikacije koja će njezinim korisnicima omogućiti kupnju ili rezervaciju kino ulaznica. Aplikacija će imati različite poglede (obični korisnik, administrator), ovisno o ulozi koja je dodijeljena trenutno prijavljenom korisniku. Samo korisničko sučelje biti će user-friendly te će omogućiti korisnicima da na jednostavan način kupuju ili rezerviraju ulaznice za odabrani film. Korisnici će moći pretraživati filmove prema kategorijama (žanrovima), ključnim riječima, formatima filmova (2D, 3D, Extreme 2D i slično) te danima projekcije filmova. Također u aplikaciju ćemo pokušati ugraditi "Loyalty program" na način da određeni korisnici (redoviti kupci, studenti, umirovljenici) imaju posebne pogodnosti u vidu popusta prilikom kupnje ulaznica. Također posebne pogodnosti moguće je ostvariti sakupljanjem bodova. Prilikom kupnje ulaznice korisniku će biti dodijeljen određen broj bodova, te nakon postizanja određenog broja bodova, pretpostavimo 20, korisnik će imati mogućnost "kupnje" ulaznice bez naplate. Korisnik u ulozi administratora imati će mogućnost dodavanja novih filmova, ažuiranja postojećih filmova. 

## Specifikacija projekta
Umjesto ovih uputa opišite zahtjeve za funkcionalnošću programskog proizvoda. Pobrojite osnovne funkcionalnosti i za svaku naznačite ime odgovornog člana tima. Opišite buduću arhitekturu programskog proizvoda. Obratite pozornost da bi arhitektura trebala biti višeslojna s odvojenom (dislociranom) bazom podatka. Također uzmite u obzir da bi svaki član tima treba biti odgovorana za otprilike 3 funkcionalnosti, te da bi opterećenje članova tima trebalo biti ujednačeno. Priložite odgovarajuće dijagrame i skice gdje je to prikladno. Funkcionalnosti sustava bobrojite u tablici ispod koristeći predložak koji slijedi:

Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | **Registracija** | Za pristup samoj aplikaciji korisnik će morati registrirati svoje osobne podatke. | Dario Alilović
F02 | **Prijava u sustav** | Za pristup aplikaciji korisnik se mora autentificirati pomoću *username* i *password-a* koji su definirani pri registraciji korisnika. | Dario Alilović
F03 | **Uređivanje korisničkog računa** | Svaki od korisnika imati će pristup vlastitom korisničkom računu na kojem će se nalaziti osnovne informacije o korisniku kao što su *korisničko ime*, *ime i prezime*, *adresa* i slično . Navedene informacije korisnik će moći uređivati ovisno o vlastitim željama | Dario Alilović
F04 | **Loyalty sustav nagrađivanja**  | Prilikom kupnje ulaznice, korisnik će ostavriti određeni broj bodova koji će se akulumulirati. Nakon sakupljanja određenog broja bodova, primjerice 20, korisnik će imati mogućnost "kupnje" ulaznice bez naplate. | Robert Gladoić
F05 | **Forma za unos filmova** | Jedna od uloga (*administrator*) u aplikaciji imati će mogućnost dodavanja novih filmova u bazu, postavljanja datuma njihovog emitiranja, ažuriranja informacija o postojećim filomovima i slično | Robert Gladoić
F06 | **Forma za dodavanje dvorana** | Jedna od uloga (*administrator*) u aplikaciji imati će mogućnost dodavanja novih dvorana u bazu te dodavanja inicijalnih informacija o dvorani (broj mjesta, tip dvorane, ...) | Robert Gladoić
F07 | **Forma za rezervaciju ulaznica** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost rezervacije ulaznica za odabrani film. Na taj način korisnik **SAMO** rezervira ulaznicu, dok je istu potrebnu preuzeti na blagajni. |Patrik Galina
F08 | **Forma za kupnju ulaznica** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost kupnje ulaznica za odabrani film. Na taj način korisnik kupuje i odmah plaća ulaznicu. Plaćanje će se izvršavati na način da korisnik ima određeni saldo na korisničkom računu te se prilikom kupnje provjerava da li je saldo veći ili jednak cijeni ulaznice. | Patrik Galina
F09 | **Forma za pretragu filmova** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost pretraživanja filmova prema kategorijama (žanrovima), ključnim riječima, formatima filmova (2D, 3D, Extreme 2D i slično) te danima projekcije filmova. | Patrik Galina


## Tehnologije i oprema
Visual Studio 2019 - licenca putem AAI@EduHr korisničkog računa

C# (.NET)

MySQL 

MySQL Workbench 6.3 CE - za pristup i manipulaciju bazom poadataka

Flaticon.com - za preuzimanje ikona (*button-a*) koji će biti korišteni prilikom dizajniranja aplikacije

Microsoft Office Word - za izradu dokumentacije projekta; licenca putem AAI@EduHr korisničkog računa
