# Intership-November-2021
(web app) ASP.Net Core MVC

Potrebna okrzenja za koristenje:
Visual Studio 2019/22 https://visualstudio.microsoft.com/downloads/

Za bazu podataka:
MS SQL Server https://www.microsoft.com/en-us/sql-server/sql-server-downloads

Nakon sto otvorite aplikaciju u Visual Studio-u ucinite sve potrebno opisano u nastavku!

Podaci se nalaze na SQL serveru, vec postoje migracije, tako da je potreno u 
Package Manager Console upisati komandu update-databae, i time bi na localhost serveru
bila dodana baza podataka sa odgovarajucim tabelama.

Nakon sto se izvrsi ubdate baze podataka, moguce je pokreniti aplikaciju.

Na pocetnom page-u nece biti podataka, te stoga je potrebno kliknuti dugme "Data", koje
se nalazi u navigacijskom dijelu. Nakon klika "Data" dugmeta, izvrsit ce se c# skripta koja ce
dodati potrene podatke za koristenje aplikacije.

Iako su dodani potrebni podaci, na pocetnom page-u nece nece biti artikala, potrebno se registrovati,
nakon sto se registrujete, na navigacijskom dijelu cete dobiti novo dugme "Admin", klikom na to dugme 
otvara vam se novi page gdje imate vise ponudjeni funkcijonalnosti. Vi odaberite dodavanje vozila,
i dodajte nekoliko vozila i tek nakon dodavanja ce artikli biti prikazani na pocetnom page-u, time ce
podaci ostati u bazi podataka i nakon sto se odjavite moci cete pregledati ponudjene artikle (vozila).
Naravno koristite i ostale funkcionalnosti :D!

Uz ovu MVC aplikaciju, postoji i Angular u kojem je razvijeno dodavanje brendova  vozila i modela za brand, 
i ostale Crud operacije za te podatake.


