## UVID U PROJEKT

## Uvod
* Čestitam vam na do sada odraženom poslu. Vidi se da ste posebnu pozornost posvetili dokumentaciji i da ste u nju uložili puno truda. Većina komentara ispod ne zahtjeva suštinske već najčešće strukturne promjene pa mislim da ih neće biti teško implementirati. Iskreno, za razliku od velikog broja drugih dokumentacija, vašu je bilo užitak čitait :)

## Projektna dokumentacija
* Vodopadno iterativni model razvoja -> OK. 
* Projektni plan: U potpunosti usklađeno s modelom razvoja -> OK.
* Izračun troškova -> OK.
* Ponuda naručitelju -> OK.
* Praćenje provedbe -> OK.

## Tehnička dokumentacija
* Poglavlja u 2.6. nisu ispravno imenovana. Slučaj korištenja nije isto što i uloga. Možda ste mislili na nešto tipa "Funkcionalnosti administratora" ili "Korištenje aplikacije - administrator". Sadržaj koji je u tim poglavljima je potpuno u redu.
* Poglavlje 2.7. i dalje - nemojte navoditi nazive dijagrama. To poglavlje ne bi smjelo biti tamo zbog dijagrama, već bi dijagram trebao biti tamo da na formalan način opiše neki funkcionalni/nefunkcionalni/strukturni/arhitekturalni zahtjev. Oslobodite se pritiska da se neki dijagram mora koristiti. Praksa je pokazala da su dijagrami klasa obvezni, a svi ostali nam služe da nam olakšaju definiranje specifikacije.
* Svako poglavlje (podpoglavlje) dokumentacije bi trebalo imati potpisanog autora (odgovornog studenta).
* Poglavlje 2.7. i dalje - pokušaj da smjestite sve relevantne podatke o specifikaciji jedne funkcionalnosti u isto poglavlje je za svaku pohvalu. Međutim, primijetim da ima puno teksta. Dokumentaciju koja ima jako puno teksta je teško držati ažurnom. Stoga, predlažem da tekst pretovorite u formalnije i vizualnije oblike: checkliste, tablice, flow chartove, rich slike ili što već. Naravno, nemojte tekst u potpunosti obrisati, jer on mora ostatati, ali samo kao ljepilo između svih formalnih specifikacija. 
* Poglavlje 2.7. i dalje - nemojte me krivo shvatiti. Vi ćete za ovaj dio dobiti max broj bodova, ali kad ste već uložili toliko truda, onda bi bilo dobro ovu dokumentaciju podići na još jednu višu razinu - profesionalnu. A znam da vi to možete.
* Pohvalno je što ste tražili i pokušali primijeniti predloške / primjere dobre prakse u raspisu dijela dokumentacije. Pri korištenju predložaka treba biti oprezan, jer ako poglavlja i teme koje se navode a nisu važne za vaš projekt možete ih izostaviti ili grupirati. Time bi se izbjegla rascjepkanost dokumenta u mnošvo poglavlja od po jednu-dvije rečenice. Isto tako postoje poglavlja koja se po svojoj prirodi mogu spojiti.
* UC: Sintaksički ispravni.
* AD: Sintaksički ispravni.
* SD: Stereotip sustava je obično prvi objekt s kojim korisnik vrši interakciju. Iza njega su controlni i granični objekti. Kod vas nema sustava.
* Zbog kompleksnosti cijele dokumentacije, molim vas dodajte u navigacijski izbornik (desno) i linkove na poglavlja prve i druge razine (ne treba dublje).
* Semantiku i usklađenost svih dijagama s kodom ćemo provjeravati na obrani.
* U dokumentaciju dodati poglavlje s uputama za podešavanje razvojne i produkcijske okoline te s podacima o testiranju programa (npr. korisnička imena i lozinke).

## Implementacija
* Verzioniranje - predlažem da sve što se radi s dokumentacijom radite u posebnoj grani koja bi se mogla zvati "Dokumentacija". Isto tako predlažem da se grane ne zovu po vama (jer svaki commit i ovako i onako ima autora) već grane imenujte po funkcionalnostima koje razvijate. Također, koristite Development granu u koju ćete spajati svaku funkcionalnost kada je gotova. Nakon što se integracija (na development grani) istestira i nakon što je sve u redu, tek onda se kod spaja na master (produkcijsku granu). Vezano za workflow razvoja (ne vezano za dokumentaciju) pokušajte primijeniti feature-branch workflow koji je opisan ovdje: https://www.atlassian.com/git/tutorials/comparing-workflows/feature-branch-workflow.
* Pojedine forme ne zauzimaju cjelokupno dostupno sučelje. Po promjeni veličine forme kontrole ostaju na mjestu. Potrebno je bolje iskoristiti prostor kvalitetnijim postavljanjem sidara za svaku kontrolu, kako bi se one kontrole koje su uz desni rub pomicale sa tim rubom, a onda druge kontrole popunjavale prazan prostor (kao npr. tablice).
* Nisam uspio rezervirati više mjesta od jednom. Nakon rezervacije jednog sjedala forma se zatvara. To je željeno ponašanje?
* Trenutno aplikacija ne razlikuje uloge
* .gitignore - ispravno definiran. 
* Implementirane funkcionalnosti - Tim za pohvalu.

## Ostalo
* U dokumentaciji bi bilo dobro složiti da se klikom na sliku ista slika otvori u full screen prikazu.
* Pazite na minimalne zahtjeve za programske proizvode prije nego što pristupite obrani (npr. izdvajanje jednog dijela projekta u dll, kontekstualna pomoć).

## Bodovi
P1: 15 bodova

---
---

## Opća povratna informacija
Projektna prijava se prihvaća uz elemente dopune koje navodim u nastavku. Projektna ideja je u skladu sa zahtjevima kolegija. Implementacijom konačnog seta funkcionalnosti (nadopunjeno) studenti će moći postići sve ishode učenja na kolegiju. Molim da temeljem ovih informacija sami dopunite vašu projektnu prijavu.

## Arhitektura u odnosu na bazu podataka
Molim da arhitektura sustava bude temeljena na centraliziranoj bazi podataka na koju će se spajati jedna ili više aplikacija istovremeno. Ovaj zahtjev treba uzeti u obzir kao aspekt kroz dizajn i implementaciju ostalih funkcionalnosti (npr. da se ne dogodi da dva korisnika iznajme isti ormar ako rade iznajmljivanje u isto vrijeme).

## Zahtijevane dopune
1. Molim da vaš projekt fokusirate samo na aviokarte, te da isključite hotelske sobe i kino ulaznice. 
2. Omogućiti sklapanje ugovora (suradnju) sa više poslovnih partnera (aviokompanije, putničke agencije itd) koje bi sustav punile podacima o letovima (stalnim, povremenim charter). Za vašu implementaciju to znači kreiranje novog admin računa za dotičnog partnera, koji se onda bavi kreiranjem drugih uloga u sustavu i dodjelom ovlasti njima. U ovu svrhu je potrebno osposobiti fleksibilan model ovlasti (da admin bilo kojem korisniku može dodijeliti bilo koji set ovlasti nad postojećim funkcionalnostima sustava).
3. Omogućiti izradu računa vašim partnerima (aviokompanijama i drugima) koji bi se spremao u PDF i slao na mail partnera. Izdavanje računa može biti implementirano ručno, ali i automatski.
4. Dodati izradu statističkih izvješća koja uključuju tablične i grafičke prikaze te pohranu u PDF i mogućnost ispisa.

Postojeće funkcionalnosti obrišite koje se ne odnose na aviokarte, te nove funkcionalnosti podijelite na način da ukupno opterećenje svih članova tima bude približno jednako.
