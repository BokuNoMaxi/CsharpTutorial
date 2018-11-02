using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    struct Buch
    {
        private string titel;
        private string author;
        private string bezeichnung;
        private int buch_id;

        public void SetValues(string t, string a, string b, int id)
        {
            titel = t;
            author = a;
            bezeichnung = b;
            buch_id = id;
        }

        public void DisplayValues()
        {
            Console.WriteLine("Das Buch mit dem Titel {0} von {1} handelt um {2}", titel, author,bezeichnung);
        }
    }

    class Buchverwaltung
    {
        static void Main(string[] args)
        {
            Buch Buch1 = new Buch();
            Buch Buch2 = new Buch();

            Buch1.SetValues("C# Programming", "Tutorialspoint", "C# Programming tutorial", 1);
            Buch2.SetValues("Kochen für Anfänger", "Meine Mama", "Hier lernt man Kochen!", 2);
         
            Console.WriteLine("Das Buch mit dem Titel {0} von {1} handelt um {2}", Buch2.titel, Buch2.author, Buch2.bezeichnung);

            Console.ReadKey();
        }
    }
}
