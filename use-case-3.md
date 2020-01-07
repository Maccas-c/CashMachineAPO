Use Case 3: Wykonanie przelewu
=====================

Aktor podstawowy: Klient

Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Klient: oczekuje szybkiego i bezpiecznego przelewu pieniędzy na konto innej ososby 

- Obsługa w banku: chce poprawnie realizować przelewy w bankomacie. oczekuje bezpiecznego połączenia z kontem bankowym klienta

Warunki wstępne:
----------------
Klient posiada aktualną kartę bankową, chce wykonać przelew przez bankomat.


Warunki końcowe:
----------------

Przeprowadzona została bezpiczena transakcja, pieniądze zostały pobrane z konta klienta i przesłane na konto innego klienta.


Scenariusz główny (ścieżka podstawowa):
---------------------------------------
1. Klient wkłada kartę i wybiera opcję „Przelew środków”.
2. Bankomat prosi o podanie kodu PIN.
3. Klient wprowadza kod PIN.
4. Bankomat dokonuje weryfikacji.
5. Bankomat wyświetla formularz do wypełnienia.
6. Klient wpisuje numer rachunku (na który chce zrobić przelew), kwotę oraz tytuł przelewu.
7. Bankomat weryfikuje dostępne na karcie środki i wysyła identyfikator karty, kwotę oraz numer konta do banku.
8. Bankomat otrzymuje informację zwrotną z banku o pomyślności transakcji i wyświetla komunikat "Przelew wysłany".
9. Bankomat wysuwa kartę i prosi o jej zabranie.
10. Klient odbiera kartę.
11. Bankomat pyta czy klient potrzebuje potwierdzenie dokonania transakcji.
12. Klient wybiera wydruk potwierdzenia tranksakcji.


Rozszerzenia (ścieżki alternatywne):
------------------------------------

 3a. Błędny PIN:
		1. Bankomat wyświetla komunikat "Podany PIN jest błędny. Podaj ponownie PIN.".
		2. Klient wpisuje PIN:
		2a. Klient podaje trzy razy błędny PIN:
			1. System blokuje kartę.

 6a. Podany przez klienta numer rachunku nie istnieje:
		1. Bankomat wyświetle komunikat "Nieprawidłowy numer rachunku. Podaj ponownie numer rachunku.":
		2. Klient wpisuje numer rachunku.

 7a. Na karcie nie ma wystarczających środków: 
		1. Bankomat wyświetla komunikat "Nie masz wystarczających środków. Podaj nową kwotę.":
		1a. Klient ponownie podaje kwotę do przelewu.

 8a. Bank nie potwierdza wykonania przelewu:
		1. Bankomat wyświetla komunikat "Przelew nie został wysłany. Skontaktuj się z bankiem".
		
 10a. Klient nie odebrał karty z bankomatu.
 		1.Bankomat wyświetla komunikat "Karta nie została odebrana. Skontaktuj się z bankiem".
		2.Bankomat blokuję możliwość wyciągnięcia karty.


Wymagania specjalne:
--------------------

  - Niezbędny ekran dotykowy na dużym płaskim monitorze, tekst musi być wyraźny.
  
  - Cała transakcja powinna być nagrywana przez kamere dla większego bezpieczeństwa dla klienta.

  - Interfejs powinien być również dostępny w języku angielskim i niemieckim oraz rosyjskim.

  - W przypadku klawiatury musi być wydrążone specjalne znaki w Alfabecie Braille’a dla osób niewidomych.



Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

 1a. Konieczny czytnik kart z podświetlonym miejscem do włożenia karty.

 3a. PIN jest wprowadzony z klawiatury lub z klawiatury na ekranie dotykowym.

 12a. Drukarka do potwierdzeń.

Kwestie otwarte:
----------------

  - Czy bankomat będzie pobierał opłatę za przelew środków na inne konto?

  - Jaka minimalna kwota musi zostać przelana aby została zaakceptowana transakcja?
 
  - Czy bankomat będzie w stanie przewalutować środki na konto zagraniczne ? 
