using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekursiveMethodCall
{
    class factorialBerechner
    {
        public int factorial(int Nr)
        {
            int result;
            if( Nr == 1)
            {
                return Nr;
            }
            else
            {
                result = factorial(Nr - 1) * Nr;
                return result;
            }
        }


        static void Main(string[] args)
        {
            factorialBerechner n = new factorialBerechner();
            
            Console.Write("Der Factorial von 7 ist:{0}\n", n.factorial(7));
            //Console.Write("Der Factorial von 8 ist:{0}\n", n.factorial(8));
            Console.ReadLine();
        }
    }
}
