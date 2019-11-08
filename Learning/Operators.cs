using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    class Operators
    {
        public static void DoOperators()
        {
            int a = 5 + 6;
            int b = 253 - 123;
            int c = -(3 * 4);
            int d = 12 / 4;
            int remainder = 13 % 4;

            int aa = a * b + c; // * is first
            aa = (a * b) + c; // same as above
            aa = a * (b + c); // changes addition first

            int n;
            int m;
            n = m = 2; // shouldn't usually use this which sets both n and m to 2 called chaining assignments

            a += 20;
            b -= 2;
            c *= 13;
            d /= 3;
            remainder %= 2;

            a++;
            ++a;

            b &= 3; //bitwise and
            c |= 55; //bitwise or
            d ^= 12; //bitwise xor

            bool t = true;
            bool f = false;

            if (a == b) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (a != b) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (a > b) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (a < b) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (a >= b) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (a <= b) Console.WriteLine("Yes"); else Console.WriteLine("No");

            if ( 4 < 5) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (4.0 > 5.3) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if ('a' < 'B') Console.WriteLine("Yes"); else Console.WriteLine("No");
            if ('C' < 'z') Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (12M < 8M) Console.WriteLine("Yes"); else Console.WriteLine("No");
            if (9.2f < 9.53f) Console.WriteLine("Yes"); else Console.WriteLine("No");
            
            float f1 = 3.333333f;
            float f2 = 2.998734f;

            // use somehow for comparing real numbers for equality
            bool comp = Math.Abs(f1 - 3.0 * f2) < .00001; // Use whatever level of accuracy you want

            bool aBool = false;
            bool bBool = true;
            if (!aBool) ;
            if (aBool & bBool) ; // and
            if (aBool | bBool) ; // or
            if (aBool ^ bBool) ; // xor
            if (aBool && bBool) ; // and short circuit
            if (aBool || bBool) ; // or short circuit

            double d1 = 3.2;
            int i1 = 8;
            double d2 = d1 / i1; // implicit type conversion
            int i2 = (int)(i1 / d1); // casting


            AddOne foo = new AddOne();
            foo.x = 2;

            AddOne bar = new AddOne();
            bar.x = 3;
            // operator overloading in AddOne constructor
            Console.WriteLine((foo + bar).x.ToString());
            Console.Read();



            //if ("Hello" < "World") Console.WriteLine("Yes"); else Console.WriteLine("No"); Error


        }

        public class AddOne
        {
            public int x;

            public static AddOne operator +(AddOne a, AddOne b)
            {
                AddOne addone = new AddOne();
                addone.x = a.x + b.x + 1;
                return addone;
            }

        }

    }
}
