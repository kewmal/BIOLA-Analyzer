# BIOLA-Analyzer
Aplikacja Biola Analyzer 
Aplikacja sluzy do zapisywania,
analizowania informacji o organizmach
i ich DNA. Aplikacja pozwala na przeksztalcenie
DNA w RNA lub od razu na aminokwasy.
Można wykorzystać do zapisywania fragmentow DNA organizmów i ich analiza
Można ją rozbudować dodając wiecej funkcji
analizy.
Dokumentacja programu

Program jest zaprojektowany tak,
aby organizmy mozna bylo podzielic
na grupy. Aby porównywać infromacje
z klas, wykorzytałem wywoływanie 
danej zmiennej na zewnątrz.
Organizmy są zapisywane w 
specjalnych listach, którymi typem jest
dana klasa

to jest menu
1. Wyswietl wszystkie organizmy 
2. Wyszukaj organizm majac nazwe 
3. Wyszukaj organizm majac fragment DNA
4. Dodaj organizm
5. Usun organizm 
6. Przeksztalc DNA organizmu w RNA
7. Pokaz bialka podczas ekspresji genu danego organizmu
8. Wyswietl budowe klas (dla programistow) 
9. KONIEC

Do wczytania danych z list używałem pętli, która
jednoczesnie analizowała każdy organizm.

Dodałem możliwość przekształcenia DNA w RNA
oraz w aminokwasy. 
Ponieważ aminokwasów jest dużo, użyłem
zwyczajnie wielu if-ów

Można dodać, usunąć organizm, oraz go wyszukać
mając tylko nazwę lub fragment DNA

Zabezpieczyłem czytanie DNA w aminokwasy, ponieważ
żeby takie DNA było dobre, musi być podzielne 
przez 3 (użyłem do tego modulo)

Użyłem równiez funkcji zapisywania do pliku,
aby zapisywać nazwę oraz DNA danego organizmu
w czasie rzeczywistym.
UWAGA: w dysku C musi istnieć folder 
C:\orgzywy\
W nim automatycznie zapisze się plik

Do wielu klas użyłem jednej wirtualnej funkcji,
która pozwalała na łatwe przedstawienie danych o 
organizmie

Organizmy:
1. Gad
2. Ssak
3. Ptak
4. Bakteria
5. Człowiek*

*Czlowiek jako dodatkowo ma imie, nazwisko, wiek
