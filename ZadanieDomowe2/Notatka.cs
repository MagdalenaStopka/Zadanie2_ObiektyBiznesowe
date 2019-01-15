using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe2
{
   public class Notatka :PodstawowyObiektBiznezowy
    {
        public string NazwaTworcy { get; set; }
        public string Tresc { get; set; }

        public Notatka(Guid identyfikator, string nazwa, string nazwaTworcy, string tresc, bool istnieje=true)
        {
            Identyfikator = identyfikator;
            Nazwa = nazwa;
            Istnieje = istnieje;
            NazwaTworcy = nazwaTworcy;
            Tresc = tresc;

        }

        public override string ToString()
        {
            return String.Format("Identyfikator: {0} \nNazwa: {1} \nIstnije: {2} \nNazwaTworcy: {3}  \nTresc: {4}", Identyfikator, Nazwa, Istnieje, NazwaTworcy, Tresc);
        }

        public override void Usun()
        {
            Console.WriteLine("");
            Console.WriteLine("Notatka " + Identyfikator + " została usunięta");
            Istnieje = null;
            Nazwa = "";
            NazwaTworcy = "";
            Tresc = "";
        }
    }
}
