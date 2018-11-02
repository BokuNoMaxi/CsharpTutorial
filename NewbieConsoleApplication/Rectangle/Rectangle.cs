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

        public Rectangle()//Konstruktur
        {
            setDetails();
        }
        ~Rectangle()//Dekonstruktor
        {
            Console.WriteLine("Object zerstört");
        }

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
            Console.WriteLine("Länge{0}:", length);
            Console.WriteLine("Breite{0}:", width);
            Console.WriteLine("Fläche{0}:", getFlaeche());
        }
    }
}
