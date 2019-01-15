using System;

namespace ZadanieDomowe2
{
   public class Program
    {
        static void Main(string[] args)
        {
            Dokument doc = new Dokument(new Guid(), "gggg", "Ja", "fcdssfdcs", "sdsd", "scsc");
            Notatka notka = new Notatka(new Guid(), "Notatka1", "Misiowy", "Trzeba kupic papier");

            Console.WriteLine(doc);
            doc.Usun();
            Console.WriteLine(doc);
            Console.WriteLine(notka);
            notka.Usun();
            Console.WriteLine(notka);
            Console.ReadKey();
        }
    }
}
