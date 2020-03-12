# PI20-020 Izrada booking sustava

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Patrik Galina | pgalina@foi.hr | 0016133400 | pgalina1
Dario Alilović| dalilovic@foi.hr | 0016130019 | dalilovic1
Robert Gladoić | rgladoic@foi.hr | 0016130162 | rgladoic

## Opis domene
Ovaj projekt je orijentiran izradi aplikacije koja će njezinim korisnicima omogućiti kupnju ili rezervaciju kino ulaznica, hotelskih soba i avionskih karata. Aplikacija će imati različite poglede (obični korisnik, administrator), ovisno o ulozi koja je dodijeljena trenutno prijavljenom korisniku. Samo korisničko sučelje biti će user-friendly te će omogućiti korisnicima da na jednostavan način kupuju ili rezerviraju ulaznice za odabrani film, hotelske sobe ili avionske karte. Korisnici će moći pretraživati filmove prema kategorijama (žanrovima), ključnim riječima, formatima filmova (2D, 3D, Extreme 2D i slično) te danima projekcije filmova, hotele prema mjestima i ocjenama, a avionske karte prema popisu letova. Korisnik u ulozi administratora imati će mogućnost dodavanja novih filmova, ažuiranja postojećih filmova, dodavanja hotela i avionskih letova. 

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | **Registracija** | Za pristup samoj aplikaciji korisnik će morati registrirati svoje osobne podatke. | Dario Alilović
F02 | **Prijava u sustav** | Za pristup aplikaciji korisnik se mora autentificirati pomoću *username* i *password-a* koji su definirani pri registraciji korisnika. | Dario Alilović
F03 | **Uređivanje korisničkog računa** | Svaki od korisnika imati će pristup vlastitom korisničkom računu na kojem će se nalaziti osnovne informacije o korisniku kao što su *korisničko ime*, *ime i prezime*, *adresa* i slično . Navedene informacije korisnik će moći uređivati ovisno o vlastitim željama | Dario Alilović
F04 | **Forma za unos hotela**  | Jedna od uloga (*administrator*) u aplikaciji imati će mogućnost dodavanja novih hotela i soba u bazu, te ažuriranja informacija o postojećim smještajima i slično | Robert Gladoić
F05 | **Forma za pretragu hotela** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost pretrage slobodnih hotela i soba. |Dario Alilović
F06 | **Forma za rezervaciju soba**  | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost rezervacije željenih hotelskih soba. | Robert Gladoić
F07 | **Forma za unos filmova** | Jedna od uloga (*administrator*) u aplikaciji imati će mogućnost dodavanja novih filmova u bazu, postavljanja datuma njihovog emitiranja, ažuriranja informacija o postojećim filomovima i slično | Robert Gladoić
F08 | **Forma za dodavanje dvorana** | Jedna od uloga (*administrator*) u aplikaciji imati će mogućnost dodavanja novih dvorana u bazu te dodavanja inicijalnih informacija o dvorani (broj mjesta, tip dvorane, ...) | Robert Gladoić
F09 | **Forma za kupnju kino ulaznica** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost kupnje ulaznica za odabrani film. Na taj način korisnik kupuje i odmah plaća ulaznicu. Plaćanje će se izvršavati na način da korisnik ima određeni saldo na korisničkom računu te se prilikom kupnje provjerava da li je saldo veći ili jednak cijeni ulaznice. | Patrik Galina
F010 | **Forma za pretragu filmova** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost pretraživanja filmova prema kategorijama (žanrovima), ključnim riječima, formatima filmova (2D, 3D, Extreme 2D i slično) te danima projekcije filmova. | Patrik Galina
F011 | **Forma za dodavanje leta** | Jedna od uloga (*administrator*) u aplikaciji imati će mogućnost dodavanja informacija o letovima. |Patrik Galina
F012 | **Forma za rezervaciju leta** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost rezervacije letova (sjedala). |Patrik Galina
F012 | **Forma za pretragu letova** | Jedna od uloga (*obični korisnik*) u aplikaciji imati će mogućnost pretrage slobodnih letova (sjedala). |Patrik Galina

## Tehnologije i oprema
Visual Studio 2019 - licenca putem AAI@EduHr korisničkog računa.

C# (.NET, WAF)

MySQL 

MySQL Workbench 6.3 CE - za pristup i manipulaciju bazom podataka.

Flaticon.com - za preuzimanje ikona (*button-a*) koji će biti korišteni prilikom dizajniranja aplikacije.

Microsoft Office Word - za izradu dokumentacije projekta; licenca putem AAI@EduHr korisničkog računa.
