using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numerator:");
            string x = Console.ReadLine();

            Console.WriteLine("Denominator:");
            string y = Console.ReadLine();

            Rational r = new Rational(int.Parse(x), int.Parse(y));
            Console.WriteLine(r.ToString());

            Console.ReadKey();
        }
    }
}
