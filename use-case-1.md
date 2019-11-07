Use Case 1: Wypłata pieniędzy
=====================

**Aktor podstawowy:** 
Klient

Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Klient: oczekuje szybkiej i bezpiecznej wypłaty pieniędzy 

- Obsługa w banku: chce poprawnie realizować transkacje w bankomacie i zadowolenia Klienta, oczekuje bezpiecznego połączenia z kontem bankowym klienta  	

Warunki wstępne:
----------------

Karta klienta jest sprawdzona, potwierdzona jest zgodność kodu PIN.

Warunki końcowe:
----------------
Przeprowadzona została bezpiczena transakcja, pieniądze zostały pobrane z konta klienta. Klient otrzymał gotówkę. 


Scenariusz główny (ścieżka podstawowa):
---------------------------------------

  1. Klient wkłada kartę i wybiera opcję WYPŁAĆ PIENIĄDZE.
  2. Bankomat prosi o podanie kodu PIN.
  3. Po pomyślnej weryfikacji klientowi zostają wyświetlone możliwe do wypłacenia kwoty razem z opcją INNA KWOTA.
  4. Klient wybiera dowolną kwotę i akceptuje wybór.
  5. Bankomat sprawdza dostępność pieniędzy w bankomacie. 
  6. Bankomat wysuwa kartę i prosi o jej zabranie.
  7. Gdy klient zabierze kartę, bankomat wypłaca gotówkę.
  8. Bankomat pyta czy klient potrzebuje potwierdzenie. 

Rozszerzenia (ścieżki alternatywne):
------------------------------------

 2a. Podany kod PIN jest błędny:
	1. Bankomat wyświetla informację, że podany PIN jest niepoprawny i prosi o jego ponowne wpisanie.
	2. Klient podaje PIN.
		2a. Klient trzykrotnie podał błędny PIN:
			1. System zastrzega kartę i nie wydaje jej klientowi.

 3a. Klient wybrał opcję INNA KWOTA:
	1. Klient wpisuje kwotę, która go interesuje.
		1a. Bankomat wydaje żądaną kwotę klientowi.
		1b. Bankomat nie obsługuje nominałów podanych przez klienta:
			1. Bankomat wyświetla informację o możliwych do wydania nominałów.
			2. Klient wybiera jedną z podanych opcji lub kończy operację. 

 5a. Pieniędzy brakuje w bankomacie:
	1. System wyświetla informację o braku środków.
	2. Wysyłana jest informacja do serwisu.
	3. System wyświetla możliwe do wypłacenia kwoty, jeśli takie są.

 6a. Klient nie zabiera karty z bankomatu przez dłuższy czas:
	1. Bankomat zastrzega kartę i wsuwa ją do bankomatu.

 8a. Klient chce potwierdzenie:
	1. System uzupełnia danymi transakcji potwierdzenie i drukuje je.


Wymagania specjalne:
--------------------

  - Niezbędny ekran dotykowy na dużym płaskim monitorze, tekst musi być widoczny z odległości jednego metra

  - Autoryzacja powinna być wykonana szybko ( w czasie nie przekraczającym 30 sekund)

  - Interfejs powinien być również dostępny w języku angielskim i niemieckim

Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

 1a. Konieczny czytnik kart z podświetlonym miejscem do włożenia karty.

 2a. PIN jest wprowadzony z klawiatury.

 8a. Drukarka czarno-biała.

Kwestie otwarte:
----------------

  - Czy bankomat będzie pobierał opłatę za użycie?
  - Jakie nominały będzie obsługiwał bankomat?
