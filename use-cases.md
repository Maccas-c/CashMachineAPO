 
Opis skrócony przypadków użycia
===============================

Aktorzy procesu i ich cele
--------------------------

Klient - wypłata pieniędzy, wykoananie przelewu, sprawdzenie stanu konta, zakup kodu do telefonii
Serwisant	 - uzupełnianie pieniędzy w bankomacie, sprawdzanie stanu techicznego
----------- -----------------------------

Słownik
-------
ATM - automated teller machine, bankomat
PIN - osobisty numer identyfikacyjny

Przypadki użycia
----------------

Use case 1: Wypłata pieniędzy
Po włożeniu karty przez użytkownika, wybraniu opcji WYPŁAĆ PIENIĄDZE i wpisaniu kodu PIN, system sprawdza jego poprawność. Jeśli PIN  jest poprawny to bankomat wyświetla możliwe kwoty do wypłacenia lub użytkownik podaje inną kwotę. Bankomat sprawdza czy podana kwota jest dostępna w przeciwnym wypadku podaje inne możliwości wypłacenia pieniędzy. Jeśli podana kwota jest możliwa do wydania, bankomat wydaje żądaną kwotę. 

Use case 2: Wyświetlenie stanu konta
Bankomat po wybraniu opcji "Pokaż saldo" wyświetla dostępne na karcie środki.

Use case 3: Robienie przelewu
System sprawdza czy użytkownik zgłosił chęć wykonywania przelewów przez bankomat. Jeśli tak, wyświetla opcję "Zrób przelew". Użytkownik musi podać numer konta bankowego i nazwisko użytkownika, któremu chce przesłać pieniądze oraz temat. System sprawdza dane po czym wysyła na telefon użytkownika krótki kod w celu weryfikacji. Po wpisaniu kodu przez użytkownika system wykonuje przelew.

Use case 4: Zakup kodu do telefonii pre-paidowej
Po kliknięciu opcji "Kup kod" bankomat wyświetla możliwe do zakupu doładowania.

Use case 5: Uzupełnienie pieniędzy
Serwisant otwiera bankomat. Bankomat wysyła komunikat do banku o tym działaniu. Bankomat prosi o podanie identyfikatora serwisanta razem z hasłem. Po weryfikacji serwisant uzupełnia rubryki z pieniędzmi.