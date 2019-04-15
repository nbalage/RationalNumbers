using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    public struct Rational : IComparable<int>, IEquatable<int>
    {
        public int Numerator { get; set; }

        public int Denominator { get; set; }

        public Rational(int counter, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArithmeticException("Zero denominator allowed!");
            }

            int gcd = Gcd(counter, denominator);

            Numerator = counter / gcd;
            Denominator = denominator / gcd;
        }

        public static int Gcd(int x, int y) => y == 0 ? x : Gcd(y, x % y);

        public bool Equals(int other)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(int other)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Denominator > 1 ? $"{Numerator}r{Denominator}" : $"{Numerator}";
        }
    }
}
