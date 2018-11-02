using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class SimpelArray
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];

            for (int i = 0; i < 10; i++)
            {
                array[i] = i + 100;
            }

            foreach (int j in array)
            {
                int i= j - 100;
                Console.WriteLine("Element{0} - Wert {1}",i , j);
            }
            Console.ReadKey();
        }
    }
}
