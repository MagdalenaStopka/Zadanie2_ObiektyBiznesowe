using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe2
{
    class TrescZadania
    {
        /*
         Załóżmy, że masz do stworzenia pewną część systemu informatycznego w której skład wchodzą PodstawoweObiekty biznesowe:

Część 1:


Pracownik, Dokument, Notatka
Każdy z obiektów można tworzyć (przez konstuktor), modyfikować, oraz usuwać.

Każdy z powyższych obiektów ma następujące właściwości : Identyfikator (Guid), Nazwa(String), Istnieje(bool)

Ponadto:
Pracownik ma imię i nazwisko,
Dokument ma nagłówek(string), treść(string), stopkę(string), właściciela(string - imię twórcy, nie powiązane z pracownikami)
Notatka ma treść(string), twórcę(string)

W systemach informatycznych usuwanie ma swoją specyficzną cechę - obiekt nie może po prostu wyparować, 
bo co to znaczy że usunęliśmy pracownika ? Umarł? Zwolniliśmy go? Czy możę po prostu nie chcemy mieć z nim nic wspólnego?

Dla pracownika i dokumentu usuwanie ma zmieniać stan właściwości "Istnieje" na false
Dla notatki usunięcie oznacza, że znika ona (staje się nullem, znika z naszych list na których działamy)



Tworzenie elementu ma być możliwe tylko przy pomocy konstruktora parametrowego - w nim uzupełniamy wszystkiego pola
GUID - to specyficzny identyfikator który tworzy się zawsze unikalny, żeby go utworzyć używamy w konstruktorze

Identyfikator = Guid.NewGuid();

Właściwość Istnieje, na starcie powinna otrzymywać wartość na TRUE


Modyfikiwanie elementu ma być możliwe tylko i wyłącznie przez metodę (wspólną)  Modyfikuj
twórcy dokumentu/notatki nie można modyfikować - musimy go ustalic przy tworzeniu obiektu



Część 2:

Stworz program, w którym tworzysz listę dokumentów (w niej 2 dokumenty), listę pracowników (2 pracowników),
listę notatek(2 notatki)

Stwórz metodę w programie która umożliwia usunięcie każdego obiektu biznesowego
Stwórz metodę w programie, która umożliwi wyświetlenie pełnych danych na temat każdego obiektu biznesowego

Stwórz metodę w programie, która umożliwia wyświetlenie listy każdego typu obiektu biznesowego
ta musi nie wyświetlać obiektów, które zostały usunięte ()



         */
    }
}
