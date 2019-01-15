using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe2
{
  public  class Pracownik : PodstawowyObiektBiznezowy
    {
        public string Nazwisko { get; set; }
        public string Imie { get; set; }

        public Pracownik(Guid identyfikator, string nazwa, string nazwisko, string imie, bool istnieje=true)
        {
            Identyfikator = identyfikator;
            Nazwa = nazwa;
            Istnieje = istnieje;
            Nazwisko = nazwisko;
            Imie = imie;
        }

        public override string ToString()
        {
            return String.Format("Identyfikator: {0} \nNazwa: {1} \nIstnije: {2} \nNazwisko: {3}  \nImię: {4}", Identyfikator, Nazwa, Istnieje, Nazwisko, Imie);
        }

        public override void Usun()
        {
            Console.WriteLine("");
            Console.WriteLine("Pracownik " + Identyfikator + " został usunięty");
            Istnieje = false;
            Nazwa = "";
            Nazwisko = "";
            Imie = "";
        }
    }
}
