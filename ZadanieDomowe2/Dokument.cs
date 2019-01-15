using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe2 
{
  public  class Dokument: PodstawowyObiektBiznezowy
    {
        public string Naglowek { get; set; }
        public string Tresc { get; set; }
        public string Stopka { get; set; }
        public string NazwaTworcy { get; set; }


        //Dokument ma nagłówek(string), treść(string), stopkę(string), właściciela(string - imię twórcy, nie powiązane z pracownikami)

        public Dokument(Guid indentyfikator, string nazwa, string nazwaTworcy, string naglowek, string tresc, string stopka, bool instnieje=true)
        {
            Identyfikator = indentyfikator;
            Istnieje = instnieje;
            Nazwa = nazwa;
            Naglowek = naglowek;
            Tresc = tresc;
            Stopka = stopka;
            NazwaTworcy = nazwaTworcy;

        }
        public override string ToString()
        {
            return String.Format("Identyfikator: {0} \nNazwa: {1} \nIstnije: {2} \nNazwaTworcy: {3} \nNaglowek: {4} \nTresc: {5} \nStopka: {6}"
                , Identyfikator, Nazwa, Istnieje, NazwaTworcy, Naglowek, Tresc, Stopka);
        }

        public override void Usun()
        {
            Console.WriteLine("");
            Console.WriteLine("Dokument " + Identyfikator + " został usunięty");
            Istnieje = false;
            Nazwa = "";
            NazwaTworcy = "";
            Naglowek = "";
            Tresc = "";
            Stopka = "";
        }

        
    }
}
