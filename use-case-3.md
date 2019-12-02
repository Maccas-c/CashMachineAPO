Use Case 3: Wykonanie przelewu
=====================

Aktor podstawowy: Klient

Główni odbiorcy i oczekiwania względem systemu:
-----------------------------------------------

- Klient: oczekuje szybkiego i bezpiecznego przelewu na konto innej ososby 

- Obsługa w banku: chce poprawnie realizować przelewy w bankomacie. oczekuje bezpiecznego połączenia z kontem bankowym klienta

Warunki wstępne:
----------------
Klient banku ma kartę Klient banku musi mieć kartę bankową, aby rozpocząć tę transkację rozpocząć.

Bankomat musi być w stanie, w którym jest gotowy do przetworzenia żądania klienta: jest gotowy do przyjęcia karty bankomatowej w celu rozpoczęcia transakcji i wyświetla powitanie klienta na wyświetlaczu bankomatu.

Warunki końcowe:
----------------
Klient banku otrzyma zwrot karty bankowej, albo karta bankowa zostanie zachowana, a klient banku zostanie powiadomiony o tym, gdzie zostanie wysłana.

Przeprowadzona została bezpiczena transakcja, pieniądze zostały pobrane z konta klienta. Klient przelał daną kwotę do innego klienta i ta kwota została pomyślnie pobrana z jego konta i dostarczona do drugiego klienta.

System powinien być gotowy do wykonania kolejnej transakcji.

Scenariusz główny (ścieżka podstawowa):
---------------------------------------
1. Klient wkłada kartę .
2. Wprowadź kod PIN Bankomat prosi o kod PIN klienta. Klient banku wprowadza kod PIN. Bankomat weryfikuje PIN.
3. Wybierz „Przelew środków” Bankomat wyświetla różne alternatywy dostępne w tym urządzeniu. Klient banku wybiera „Przelew środków” .
4. Wpisz „Z konta”, „Na konto” i kwotę. Bankomat prosi o konto do wypłaty, konto do wpłaty i kwotę do przelewu. Klient banku wprowadza rachunki i kwotę 
5. Przelewanie środków Bankomat wysyła identyfikator karty, PIN, kwotę i konto do banku. Bank odpowiada, że ​​przelew został zaakceptowany. 
6. Odbierz kartę i pokwitowanie bankomat zwraca kartę bankową klientowi banku i drukuje pokwitowanie. 

Rozszerzenia (ścieżki alternatywne):
------------------------------------

 1a. Karta nie jest ważna .  Włóż kartę bankową podstawowego przepływu, jeśli karta nie jest ważna, zostaje wyrzucona do klienta banku z komunikatem „przepraszam, że karta nie jest ważna”.  

 2a. Błędny PIN , Wprowadź PIN , bankomat wskazuje, że PIN jest nieprawidłowy. Bankomat wyświetla komunikat „zły PIN” do klienta banku. Klient banku ma trzy próby, aby zrobić to dobrze. Jeśli klient banku poprawnie wprowadzi kod PIN, to przechodzimy do kroku 3. W przeciwnym razie karta jest przechowywana przez urządzenie.

 4a.Jeśli bankomat wskazuje ,że konto nie posiada wystarczających środków , bankomat odpowiada komunikatem "Nie masz wystarczających środków ".1a. Klient wprowadza nowe dane i inna ilość środków która pozwala mu dokonać dany przelew.

 5a. Jeśli bankomat wskazuje, że konto „xyz” nie istnieje, bankomat odpowiada komunikatem „nie istnieje konto na które chcesz przelać środki”. 1a. Bankomat wyświetla komunikat " Czy chcesz ponowić przelew  ? .
 
 5b. Przekaż środki, jeśli bank nie odpowie (limit czasu wynosi 25 sekund), bankomat nie może ustalić, czy transakcja została wykonana, czy utracona. Uzyskamy na ekranie wiadomość: „Twój przelew może został zrealizowany lub nie. Skontaktuj się z bankiem, aby się dowiedzieć”.

 6a. Po wydaniu karty bankowej klient czeka na pokwitowanie lecz bankomat przestaje działać.

 6b. Po transakcji przelewu , bankomat przestaje działać i nie wydaje ani karty ani nie drukuje potwierdzenia.

Wymagania specjalne:
--------------------

  - Niezbędny ekran dotykowy na dużym płaskim monitorze, tekst musi być wyraźny.
  
  - Cała transakcja powinna być nagrywana przez kamere dla większego bezpieczeństwa dla klienta.

  - Interfejs powinien być również dostępny w języku angielskim i niemieckim oraz rosyjskim.

  - W przypadku klawiatury musi być wydrążone specjalne znaki w Alfabecie Braille’a dla osób niewidomych.



Wymagania technologiczne oraz ograniczenia na wprowadzane dane:
---------------------------------------------------------------

 1a. Konieczny czytnik kart z podświetlonym miejscem do włożenia karty.

 2a. PIN jest wprowadzony z klawiatury lub z klawiatury na ekranie dotykowym.

 6a. Drukarka do potwierdzeń.

Kwestie otwarte:
----------------

  - Czy bankomat będzie pobierał opłatę za przelew środków na inne konto?

  - Jaka minimalna kwota musi zostać przelana aby została zaakceptowana transakcja?
 
  - Czy bankomat będzie w stanie przewalutować środki na konto zagraniczne ? 
