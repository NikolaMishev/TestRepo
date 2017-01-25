using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            double r = double.Parse(Console.ReadLine());

            Console.WriteLine("The perimeter f circle is: {0:F2}", Math.PI * 2 * r);
            Console.WriteLine("The area of circle is: {0:F2}", Math.PI * r * r);

        }
    }
}
//double r = double.Parse(Console.ReadLine());


//Console.WriteLine("{0:f12}", 2 * Math.PI * r);

