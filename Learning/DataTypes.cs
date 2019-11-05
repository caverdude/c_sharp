using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public class DataTypes
    {
        public static void dataTypes()
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

            

        }

       
    }
}
