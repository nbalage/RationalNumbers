using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumbers
{
    public struct Rational : IComparable<Rational>, IEquatable<Rational>
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

        public bool Equals(Rational rational)
        {
            return (Numerator == rational.Numerator && Denominator == rational.Denominator) ? true : false;
        }

        public int CompareTo(Rational rational)
        {
            return this.CompareTo(rational);
        }

        public override string ToString()
        {
            return Denominator > 1 ? $"{Numerator}r{Denominator}" : $"{Numerator}";
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            int commonDenominator = r1.Denominator * r2.Denominator;
            return new Rational
            (
                (r1.Numerator * r2.Denominator) + (r2.Numerator * r1.Denominator),
                commonDenominator
            );
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            int commonDenominator = r1.Denominator * r2.Denominator;
            return new Rational
            (
                (r1.Numerator * r2.Denominator) - (r2.Numerator * r1.Denominator),
                commonDenominator
            );
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational
            (
                r1.Numerator * r2.Numerator,
                r1.Denominator * r2.Denominator
            );
        }

        public static Rational operator /(Rational r1, Rational r2)
        {
            return new Rational
            (
                r1.Numerator * r2.Denominator,
                r1.Denominator * r2.Numerator
            );
        }
    }
}
