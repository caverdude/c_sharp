using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public class DataTypes
    {
        static readonly int I = 5;
        public static void DataTypesFunction()
        {
            bool b1 = true;
            bool b2 = false;
            if (b1) Console.WriteLine("true");
            if (!b2) Console.WriteLine("false");
            char a = 'a';
            char b = 'b';
            char c = 'c';
            Console.WriteLine("{0}"+ b + c,a);
            Console.WriteLine(a+0);
            string sup = "Sup world? Suuuuuup?";
            Console.WriteLine(sup);

            string multi = "This ia multi"+
                "line"+
                "string.";

            string nullstring = "";
            char nullchar='\0';
            if(nullstring!=""+nullchar) Console.WriteLine("\\0 is not equal to \"\"");

            char c1 = 'a';
            char c2 = 'b';
            string s1 = "a";
            string s2 = "b";
            //if ((c1 + c2) == (s1 + s2)) Console.WriteLine("This code is in error as c1+c2 is a number");
            if ((""+c1 + c2) == (s1 + s2)) Console.WriteLine("The chars 'a' and 'b' made into a string are equal to the string \"ab\"");

            DateTime thisYear = new DateTime(2011, 1, 1);
            bool isLeapYear = DateTime.IsLeapYear(thisYear.Year);

            if (isLeapYear) Console.WriteLine("It's leap year!");
            else Console.WriteLine("It is not leap year :<");

            DateTime time = DateTime.Now;

            Console.WriteLine(time);

            DateTime today = DateTime.Today;
            Console.WriteLine(today);

            TimeSpan aTimeSpan = time.TimeOfDay;
            Console.WriteLine(aTimeSpan);
            TimeSpan duration = new TimeSpan(3, 0, 0, 0);
            DateTime threeDaysFromNow = time.Add(duration);

            Console.WriteLine(threeDaysFromNow);
            duration = new TimeSpan(1, 0, 0); // one hour
            Console.WriteLine(new DateTime().Add(duration).TimeOfDay);

            Console.WriteLine("I=" + I);

            long aLong = 200;
            int intFromLong = (int)aLong; 
            Console.WriteLine(intFromLong); // 200
            long l = (long)Math.Pow(10, 20);
            intFromLong = (int)l;
            Console.WriteLine(intFromLong); // 0

            


        }

       
    }
}
