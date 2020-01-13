Use Case 4: Zakup kodu do telefonii pre-paidowej.
=====================

**Aktor podstawowy:** Klient


Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

Klient: oczekuje możliwości zakupu jednego z obecnie dostępnych kodów prepaidowych.

Bankomat: oczekuje, aby po połączeniu z kontem bankowym klient miał możliwość zakupu jednego z dostępnych kodów prepaidowych.

Warunki wstępne:
----------------

Klient posiada kartę bankomatową z możliwością zakupu doładowań.
Klient wybrał opcję zakupu kodu do telefonii pre-paidowej.

Warunki końcowe:
----------------

Klient banku otrzyma zwrot karty.
Bankomat umożliwił wykonanie zakupu kodu do telefonii pre-paidowej.
Bankomat jest gotowy do wykonania kolejnej transakcji.

Scenariusz główny (ścieżka podstawowa):
---------------------------------------

  1. Klient wkłada kartę.
  2. Bankomat wymaga podanie PINu.
  3. Klient wpisuje kod PIN przez klawiaturę.
  4. Jeżeli weryfikacja była pomyślna, klient może zakupić kod do telefonii pre-paidowej.
  5. Klient wybiera opcję zakupu kodu.
  6. Bankomat sprawdza ilość dostępnych środków na koncie klienta.
  7. Bankomat wyświetla ilość dostępnych środków na koncie klienta.
  8. Klient może wykonać inną operację na koncie, bądź zakończyć interakcję z bankomatem.
  9. Klient wybiera opcje zakończenia interakcji.
  10. Bankomat wysuwa kartę.
  11. Klient odbiera kartę.

Rozszerzenia (ścieżki alternatywne):
------------------------------------
 1a. Upłynął termin ważności karty. Karta jest wtedy wydana i wyświetla się komunikat "upłynął termin ważności karty". 	

 4a. Jeśli podany kod PIN jest błędny 1 lub 2-krotnie to Bankomat wyświetla komunikat o niepoprawnym kodzie PIN i prosi o ponowną próbę.

 8a. Klient wykonuje inną operację na koncie bankowym. Na przykład wypłata, bądź przelew.

 11a. Jeżeli klient pozostawi kartę w bankomacie przez dłuższy czas. Bankomat wciąga ją i zastrzega.

Wymagania specjalne:
--------------------

  - Ekran dotykowy musi znajdować się na dużym płaskim monitorze, tekst musi być podświetlany i widoczny z odległości metra.

  - Interfejs powinien być również dostępny w języku angielskim i niemieckim.

  - W przypadku klawiatury musi być wydrążone specjalne znaki w Alfabecie Braille’a dla osób niewidomych.


Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

 1a. Konieczny czytnik kart z podświetlonym miejscem do włożenia karty.

 3a. Kod PIN jest wprowadzony z klawiatury.

Kwestie otwarte:
----------------

Jaka minimalna kwota musi zostać wybrana aby wykonać transakcję?

Czy bankomat będzie pobierał opłatę za wykonanie transakcji?


