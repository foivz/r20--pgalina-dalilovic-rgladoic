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
