using System;
using System.Collections.Generic;
using System.Text;

namespace ZadanieDomowe2
{
  public  class PodstawowyObiektBiznezowy
    {
        public bool? Istnieje { get; set; }
        public string Nazwa { get; set; }
        public Guid Identyfikator = Guid.NewGuid();

        public virtual void Wyswietl()
        {
           // foreach 

        }
        public virtual void Modyfikuj()
        {
            Console.WriteLine("Obiekt został zmodyfikowany");


        }

        public virtual void Usun()
        {
            
            Console.WriteLine("Obiekt został usuniety");
            
        }
    }
     

}
