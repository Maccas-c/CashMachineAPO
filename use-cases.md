 
Opis skrócony przypadków użycia
===============================

Aktorzy procesu i ich cele
--------------------------

Klient - wypłata pieniędzy, wykoananie przelewu, sprawdzenie stanu konta, zakup kodu do telefonii
Serwisant - uzupełnianie pieniędzy w bankomacie, sprawdzanie stanu techicznego
----------- -----------------------------

Słownik
-------
ATM - automated teller machine, bankomat
PIN - osobisty numer identyfikacyjny

Przypadki użycia
----------------

###Use case 1: Wypłata pieniędzy
Użytkownik wkłada kartę do bankomatu. System wyświetla możliwe opcje. Użytkownik wybiera WYPŁAĆ PIENIĄDZE i podaje kod PIN. System sprawdza jego poprawność. Użytkownik podaje kwotę do wypłacenia. Bankomat sprawdza dostępne środki. Na koniec oddaje kartę użytkownikowi i wypłaca pieniądze.  

###Use case 2: Wyświetlenie stanu konta
Użytkownik wkłada kartę do bankomatu. System wyświetla możliwe opcje. Użytkownik wybiera opcję POKAŻ SALDO i podaje kod PIN. System sprawdza jego poprawność. Bankomat wyświetla dostępne na karcie środki. Na koniec użytkownik. Na koniec oddaje kartę użytkownikowi.   

###Use case 3: Robienie przelewu
Użytkownik wkłada kartę do bankomatu. System wyświetla możliwe opcje. System sprawdza czy użytkownik zgłosił chęć wykonywania przelewów przez bankomat. Użytkownik wybiera opcję ZRÓB PRZELEW i podaje kod PIN. System sprawdza jego poprawność. Użytkownik podaje numer konta bankowego i nazwisko użytkownika, któremu chce przesłać pieniądze oraz temat. System sprawdza dane i wysyła na telefon użytkownika krótki kod w celu weryfikacji. Użytkownik wpisuje kod sms. System weryfikuje go i wykonuje przelew. Na koniec oddaje kartę użytkownikowi.

###Use case 4: Zakup kodu do telefonii pre-paidowej
Użytkownik wkłada kartę do bankomatu. System wyświetla możliwe opcje. Użytkownik wybiera opcję KUP KOD i podaje kod PIN. System sprawdza jego poprawność. Bankomat wyświetla możliwe do zakupu doładowania. Użytkownik wybiera doładowanie. System generuje kod, do doładowania telefonu i go wyświetla. Na koniec oddaje kartę użytkownikowi.

###Use case 5: Uzupełnienie pieniędzy
Serwisant otwiera bankomat. Bankomat wysyła komunikat do banku o tym działaniu. Bankomat prosi o podanie identyfikatora serwisanta razem z hasłem. Po weryfikacji serwisant uzupełnia rubryki z pieniędzmi. Na koniec serwisant zamyka bankomat. System wysyła informację do banku o dokonanej operacji.
