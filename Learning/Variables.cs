using System;

namespace Learning
{
    class Variables
    {
        static void VariablesFunction()
        {
            Console.WriteLine("Hello World!");
            int n;
            int m = 2;
            n = m;

            var a = 5;
            sbyte sb = -128;
            byte b = 255;
            short s = 32767;
            ushort us = 65535;
            uint ui = 4000000000;
            long l = (long)Math.Pow(10, 20);
            ulong ul = (ulong)Math.Pow(10, 20) * 2;
            float f = (float)Math.Pow(10, -44) * -1.9f;
            double d = Math.Pow(10, -300) * -5.0;
            float f2 = 1.0f;
            double d2 = 2.342;
            float f3 = 3e-45f;
            double d3 = 5e-300;

            Console.WriteLine("a {0} \n sb {1} \n b {2} \n s {3} \n us {4} \n ui {5} \n l {6}" +
                "\n ul {7} \n f {8} \n d {9} \n f2 {10} \n d2 {11}",
                a, sb, b, s, us, ui, l, ul, f, d, f2, d2);
            Console.WriteLine("f3 {0} \n d3 {1} \n", f3, d3);
            //float f4 = (float)Math.Pow(10, -38) * 7.9f;
            //float f4 = 5.2f;
            decimal de = (decimal)Math.Pow(10, -28) * 7.9m;
            //Console.WriteLine("de {0} \n f4 {1}", de, f4);
        }
        static void Main(string[] args)
        {
            //VariablesFunction();

            //DataTypes.DataTypesFunction();

            //Strings.DoStrings();
            //Strings.DoStrings2();
            Strings.DoStrings3();

            Console.ReadLine();
        }
    }
}
