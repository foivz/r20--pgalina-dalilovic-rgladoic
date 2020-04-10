# PI20-020 Izrada sustava za rezervaciju aviokarata

## Projektni tim

Ime i prezime | E-mail adresa (FOI) | JMBAG | Github korisničko ime
------------  | ------------------- | ----- | ---------------------
Patrik Galina | pgalina@foi.hr | 0016133400 | pgalina1
Dario Alilović| dalilovic@foi.hr | 0016130019 | dalilovic1
Robert Gladoić | rgladoic@foi.hr | 0016130162 | rgladoic

## Opis domene
Ovaj projekt je orijentiran izradi aplikacije koja će njezinim korisnicima omogućiti kupnju ili rezervaciju avionskih karata. Aplikacija će imati različite poglede (neregstrirani korisnik, obični korisnik, moderator, administrator ili owner), ovisno o ulozi koja je dodijeljena trenutno prijavljenom korisniku. Samo korisničko sučelje biti će user-friendly te će omogućiti korisnicima da na jednostavan način kupuju ili rezerviraju odabrane avionske karte. Neregistrirani korisnik imati će mogućnost pretrage avionskih karata dok će registrirani korisnik imati će mogućnost pretrage, rezervacije i kupnje avionskih karata te će moći pregledavati trenutne i prošle rezervacije kao i njihov status. Registrirani korisnik će također na e-mail račun dobiti kupljenu kartu te obavijesti o nadolazećim rezerviranim letovima. Korisnici će moći pretraživati avionske karte prema polazištu i odredištu, te zatim dostupne letove filtrirati prema cijeni, aviokompaniji, vremenu polaska ili vremenu trajanja leta. Korisnik u ulozi administratora imati će mogućnost dodavanja novih avionskih letova, dodavanje uloga (moderatora). Korisnik u ulozi moderatora ima iste mogućnosti kao i administrator osim mogućnosti dodavanja novih uloga. Owner je vrhovna uloga koja odobrava ili odbija poslane zahtjeve za suradnju. Ako je zahtjev odobren, korisniku se na e-mail račun šalje ugovor o suradnji. Poslovni partner na mjesečnoj razini dobiva automatski generirane račune za korištenje. 

## Specifikacija projekta
Oznaka | Naziv | Kratki opis | Odgovorni član tima
------ | ----- | ----------- | -------------------
F01 | **Početna** | Stranica koja se otvara prilikom pokretanja aplikacije koja prikazuje najpopularnije rute i aviokompanije. | Dario Alilović
F02 | **Registracija** | Za pristup samoj aplikaciji korisnik će morati registrirati svoje osobne podatke. | Dario Alilović
F03 | **Prijava u sustav** | Za pristup aplikaciji korisnik se mora autentificirati pomoću *username* i *password-a* koji su definirani pri registraciji korisnika. | Dario Alilović
F04 | **Pregled korisničkog računa** | Svaki od korisnika imati će pristup vlastitom korisničkom računu na kojem će se nalaziti osnovne informacije o korisniku kao što su *korisničko ime*, *ime i prezime*, *adresa* i slično . Navedene informacije korisnik će moći uređivati ovisno o vlastitim željama | Dario Alilović
F05 | **Forma za pregled svih korisničkih računa** | Forma na kojoj će biti prikazani svi korisnički računi te na kojoj će administratori imati mogućnost dodjele ovlasti moderatora korisnicima. |Robert Gladoić
F06 | **Forma za slanje zahtjeva** | Obrazac za sklapanje ugovora kojeg popunjavaju prijavljeni korisnici (koji žele biti partneri) te kojeg owner odobrava ili odbija nakon čega korisnik dobiva ovlasti administratora. |Robert Gladoić
F07 | **Forma za pregled zahtjeva** | Lista zahtjeva poslovnih partnera za suradnju na kojoj owner može prihvatiti ili odbiti određeni zahtjev. U slučaju da je zahtjev prihvaćen, korisnik koji je poslao zahtjev dobiva ulogu administratora. |Robert Gladoić
F08 | **Forma za prikaz izvješća** | Forma na kojoj administratori imaju uvid u statistiku letova te pregled u grafičkom obliku. |Robert Gladoić
F09 | **Forma za pretragu letova** | Dvije od uloga (*registrirani i neregistrirani korisnik*) u aplikaciji imati će mogućnost pretrage letova. |Patrik Galina
F010 | **Forma za rezervaciju leta** | Jedna od uloga (*registrirani obični korisnik*) u aplikaciji imati će mogućnost rezervacije letova (sjedala). |Patrik Galina
F011 | **Forma za pregled rezervacija** | Jedna od uloga (*registrirani korisnik*) u aplikaciji imati će mogućnost pregleda rezerviranih letova te stanje rezervacije (plaćena, istekla, čeka uplatu). |Patrik Galina
F012 | **Forma za plaćanje** | Forma na kojoj prijavljeni korisnik unosi podatke o plaćanju i/ili podatke o kreditnim karticama. Nakon uspješne uplate korisnik na e-mail račun dobiva kupljenu kartu. |Patrik Galina
F013 | **Forma za dodavanje leta** | Dvije od uloga (*administrator i moderator*) u aplikaciji imati će mogućnost dodavanja informacija o letovima. |Patrik Galina

## Tehnologije i oprema
Visual Studio 2019 - licenca putem AAI@EduHr korisničkog računa.

C# (.NET, WPF)

MySQL 

MySQL Workbench 6.3 CE - za pristup i manipulaciju bazom podataka.

Flaticon.com - za preuzimanje ikona (*button-a*) koji će biti korišteni prilikom dizajniranja aplikacije.

Microsoft Office Word - za izradu dokumentacije projekta; licenca putem AAI@EduHr korisničkog računa.
