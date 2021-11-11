using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_HW.RationalNumbers
{
    public class RationalNumber
    {
        /// <summary>
        /// Числитель
        /// </summary>
        private int _numerator;
        /// <summary>
        /// Знаменатель
        /// </summary>
        private int _denumerator;



        public RationalNumber(int n,int d)
        {
            var gcd = MathHelper.GCD(n, d);
            if ( gcd == 1)
            {
                Numerator = n;
                Denumerator = d;
            }
            else
            {
                Numerator = n / gcd;
                Denumerator = d / gcd;
            }
        }
        public RationalNumber(int n) : this(n, 1) { }

        public int Numerator
        {
            get { return _numerator; }
            private set { _numerator = value; }
        }
        public int Denumerator
        {
            get { return _denumerator; }
            private set {
                if (value == 0)
                { 
                    throw new NullReferenceException(); 
                }
                else if (value < 0)
                {
                    Numerator = Numerator * (-1);
                    _denumerator = value * (-1);
                }
                else
                {
                    _denumerator = value;
                }
            }
        }
        /// <summary>
        /// Returns greatest common divisor of numerator and denumerator
        /// </summary>
        public int Gcd
        {
            get
            {
                int d = Denumerator;
                int n = Numerator;
                if (n == 0)
                {
                    return d;
                }
                else
                {
                    while (d != 0)
                    {
                        if (n > d)
                        {
                            n -= d;
                        }
                        else
                        {
                            d -= n;
                        }
                    }
                    return n;
                }
            }
        }
        /// <summary>
        /// Returns least common multiple of numerator and denumerator
        /// </summary>
        public int Lcm
        {
            get
            {
                return Math.Abs(Numerator * Denumerator)/Gcd;
            }
        }
        /// <summary>
        /// Z means whole part of the number
        /// </summary>
        public int Z
        {
            get
            {
                return Numerator/Denumerator;
            }
        }





        public override string ToString()
        {
            if (Numerator % Denumerator == 0)
            {
                return $"{Z}";
            }
            else
            {
                return $"{Numerator}/{Denumerator}";
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return Equals(obj as RationalNumber);
        }
        public bool Equals(RationalNumber rn1)
        {
            return (rn1!= null &&
                this.Numerator == rn1.Numerator && 
                this.Denumerator == rn1.Denumerator);
        }

        public RationalNumber Reverse()
        {
            return new RationalNumber(Denumerator, Numerator);
        }




        public static bool operator ==(
            RationalNumber rn1, 
            RationalNumber rn2)
        {
            return (
                rn1.Numerator == rn2.Numerator &&
                rn1.Denumerator == rn2.Denumerator);
        }
        public static bool operator !=(
    RationalNumber rn1,
    RationalNumber rn2)
        {
            return (
                rn1.Numerator != rn2.Numerator ||
                rn1.Denumerator != rn2.Denumerator);
        }
        public static bool operator >(
    RationalNumber rn1,
    RationalNumber rn2)
        {
            var lcm = MathHelper.LCM(rn1.Denumerator, rn2.Denumerator);
            var f1 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            var f2 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            return f1.Numerator > f2.Numerator;
        }
        public static bool operator >=(
RationalNumber rn1,
RationalNumber rn2)
        {
            var lcm = MathHelper.LCM(rn1.Denumerator, rn2.Denumerator);
            var f1 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            var f2 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            return f1.Numerator >= f2.Numerator;
        }
        public static bool operator <(
RationalNumber rn1,
RationalNumber rn2)
        {
            var lcm = MathHelper.LCM(rn1.Denumerator, rn2.Denumerator);
            var f1 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            var f2 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            return f1.Numerator < f2.Numerator;
        }
        public static bool operator <=(
RationalNumber rn1,
RationalNumber rn2)
        {
            var lcm = MathHelper.LCM(rn1.Denumerator, rn2.Denumerator);
            var f1 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            var f2 = new RationalNumber((lcm / rn1.Denumerator) * rn1.Numerator, lcm);
            return f1.Numerator <= f2.Numerator;
        }



        public static RationalNumber operator +(
            RationalNumber rn1,
            RationalNumber rn2)
        {
            var lcm = MathHelper.LCM(rn1.Denumerator, rn2.Denumerator);
            return new RationalNumber(((lcm / rn1.Denumerator) * rn1.Numerator) + (lcm / rn2.Denumerator) * rn2.Numerator, lcm);
        }
        public static RationalNumber operator -(
            RationalNumber rn1, 
            RationalNumber rn2)
        {
            var lcm = MathHelper.LCM(rn1.Denumerator, rn2.Denumerator);
            return new RationalNumber(((lcm / rn1.Denumerator) * rn1.Numerator) - (lcm / rn2.Denumerator) * rn2.Numerator, lcm);
        }
        public static RationalNumber operator *(
            RationalNumber rn1,
            RationalNumber rn2)
        {
            return new RationalNumber(rn1.Numerator * rn2.Numerator, rn1.Denumerator * rn2.Denumerator);
        }
        public static RationalNumber operator /(
    RationalNumber rn1,
    RationalNumber rn2)
        {
            var rev = rn2.Reverse();
            return new RationalNumber(rn1.Numerator * rev.Numerator, rn1.Denumerator * rev.Denumerator);
        }
        //NOT SURE
        public static int operator %(
            RationalNumber rn1, 
            RationalNumber rn2)
        {
            var res = rn1 / rn2;
            if (res.Z == 0)
            {
                return res.Numerator;
            }
            else
            {
                var r = res.Numerator - (res.Z * res.Denumerator);
                return r;
            }
        }



        public static implicit operator int(RationalNumber rn1)
        {
            return rn1.Z;
        }
        public static implicit operator float(RationalNumber rn1)
        {
            return ((float)rn1.Numerator) / ((float)rn1.Denumerator);
        }


    }
}
