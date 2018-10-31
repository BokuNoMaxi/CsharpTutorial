using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        //Variablen:
        private double length;
        private double width;

        public void setDetails()
        {
            Console.WriteLine("Enter Length: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Width: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public double getFlaeche()
        {
            return length * width;
        }

        public void displayValues()
        {
            Console.Write("Länge{0}:", length);
            Console.Write("Breite{0}:", width);
            Console.Write("Fläche{0}:", getFlaeche());
        }
    }
}
