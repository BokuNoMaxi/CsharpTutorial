using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArray
{
    class StringArray
    {
        static void Main(string[] args)
        {
            string vorname = "Markus",nachname="Ketterer",vollername=vorname+" "+nachname;

            char[] letters = { 'H', 'E', 'L', 'L', 'O' };
            string[] sprecharray = { "Hallo", "von", "Dr. Wienzl Informationssysteme GmbH!" };

            DateTime aktuell = DateTime.Now;
            DateTime declared = new DateTime(2018, 11, 02, 10, 22, 00);

            string Chatverlauf = String.Format("{0} - Die nachricht wurde gesendet am {1:D} um {1:T}", aktuell, declared);


            Console.WriteLine(letters);
            Console.WriteLine(String.Join(" ",sprecharray));
            Console.WriteLine("Der name ist{0}", vollername);
            Console.WriteLine(Chatverlauf);
            Console.ReadKey();
        }
    }
}
