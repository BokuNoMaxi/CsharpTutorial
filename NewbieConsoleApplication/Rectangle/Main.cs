using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle;

namespace Rectangle
{
    class executeRectangle
    {
        static void Main(string[] args)
        {
            Rectangle R = new Rectangle();
            R.setDetails();
            R.displayValues();
            Console.ReadLine();
        }
    }
}
