using System;
using System.Collections.Generic;
using System.Text;

namespace Learning
{
    public class Strings
    {
        public static bool IsAllDigits(string raw)
        {
            string s = raw.Trim();
            if (s.Length == 0) return false;
            for(int index=0; index < s.Length; index++)
            {
                if (Char.IsDigit(s[index]) == false) return false;
            }
            return true;
        }
        public static void DoStrings()
        {
            string s = "abc";
            string s2 = new String(""); // empty string.
            string s3 = s;
            string s4 = s2;
            String s5 = "abc"; // same as s definition
            Student st = new Student();
            Console.WriteLine("Length:" + s5.Length);
            // String object or string keyword is same thing.
            st.Name = "John";
            st.Name.ToUpper();
            Console.WriteLine("Student.Name=" + st.Name);

            Console.WriteLine();
            Console.WriteLine(String.Compare(st.Name, "Iohn"));
            Console.WriteLine(String.Compare(st.Name, "John"));
            Console.WriteLine(String.Compare(st.Name, "Kohn"));
            Console.WriteLine();
            Console.WriteLine(String.Compare("John", "john"));
            Console.WriteLine(String.Compare("John", "JOHN"));
            Console.WriteLine(String.Compare("John", "JOHN", true));
            Console.WriteLine();
            String name = "jOhn";
            String properName =
                char.ToUpper(name[0]).ToString() + name.Substring(1, name.Length - 1).ToLower();
            Console.WriteLine(name + ' ' + properName);
            Console.WriteLine(String.Compare("JOHN", "JOHN".ToUpper()));
            Console.WriteLine(String.Compare("JoHN", "JoHN".ToUpper()));
            Console.WriteLine();

            // treat a string like a character array
            foreach (char c in st.Name)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine();
            Console.WriteLine("Hello World!".IndexOf('W')); //6
            Console.WriteLine("Hello World!".LastIndexOf('o')); //7
            char[] nums = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.WriteLine("abl434alk981sdf234".IndexOfAny(nums));
            Console.WriteLine("abl434alk981sdf234".LastIndexOfAny(nums));
            Console.WriteLine(string.IsNullOrEmpty(""));

            Console.WriteLine("Hello".Contains("ll"));

            Console.WriteLine(" \nHello World!\r   \t".Trim());

        }

        public static void DoStrings2() {
            Console.WriteLine("\n Type a whole number or 'quit'");
            try
            {
                while (true)
                {
                    String input = Console.ReadLine();
                    if (input == "quit") break;
                    if (IsAllDigits(input))
                    {

                        int n = Convert.ToInt32(input);
                        Console.WriteLine("" + n + " x 2 = " + (n * 2));
                    }
                    else
                    {
                        Console.WriteLine("Please enter a whole number.");
                        continue;
                    }
                }
            } catch (Exception e)
            {
                Console.WriteLine("Error!" + e.ToString());
            }
            Console.WriteLine("\n Enter line coordinates (x,y,x2,y2,... etc) or 'quit'");
            try
            {
                while (true)
                {
                    String input = Console.ReadLine();
                    if (input == "quit") break;

                    String[] coordinates = input.Split(',');
                    //foreach (String coord in coordinates)
                    //    Console.WriteLine(coord);
                    int c = 0;
                    foreach (String coord in coordinates)
                    {
                        c++;
                        if (IsAllDigits(coord))
                        {
                            if (c % 2 == 0) Console.Write("y" + (c / 2) + "=");
                            else Console.Write("x" + (c / 2) + "=");
                            int n = Convert.ToInt32(coord);
                            Console.WriteLine(n);
                        }
                        else
                        {
                            Console.WriteLine("Please enter as (x,y,x2,y2,... etc).");
                            continue;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error!" + e.ToString());
            }

        }
        public static void DoStrings3()
        {

            String[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul" };
            String allMonths = string.Join(":", months);
            Console.WriteLine(allMonths);

            Console.WriteLine();

            Console.WriteLine("Supervisor".PadLeft(10) + ":Larry".PadRight(10) + ":");
            Console.WriteLine("Employee".PadLeft(10) + ":Tom".PadRight(10) + ":");
            Console.WriteLine("Gofor".PadLeft(10) + ":Alfred".PadRight(10) + ":");

            Console.WriteLine(string.Concat("Larry", "Gray"));

            string formatString = string.Format("{0} {1} {2}", 1, 2, 3);
            Console.WriteLine(formatString);
            Console.WriteLine("{0} {1} {2}", 4, 5, 6);

            Console.WriteLine("{0:C}", 25.19);
            Console.WriteLine("{0:C}", -5.2);
            Console.WriteLine("{0:D5}", 22);
            Console.WriteLine("{0:E}", 3923.23432);
            Console.WriteLine("{0:E}", 0.00002343);

            Console.WriteLine("{0:N}", 203023.09883);
            Console.WriteLine("{0:N1}", 203023.09883);
            Console.WriteLine("{0:N0}", 203023.09883);

            Console.WriteLine("{0:X}", 231);
            Console.WriteLine("{0:###.##}", 52.1);
            Console.WriteLine("{0:###.##}", 2.12);
            Console.WriteLine("{0:###.##}", 6352.32);

            Console.WriteLine("{0:#00.##%}", .2434);
            Console.WriteLine("{0:#00.##%}", .08938);

            StringBuilder build = new StringBuilder();
            build.Append("Lary");
            build.Append("Don");
            build.Append("Gray");
            Console.WriteLine(build);

            StringBuilder build2 = new StringBuilder();
            for (int i=0; i < months.Length; i++)
            {
                build2.Append(months[i]);
            }
            Console.WriteLine(build2.ToString());

            StringBuilder name = new StringBuilder("larry");
            name[0] = char.ToUpper(name[0]);
            Console.WriteLine(name.ToString());














        }
    }

    class Student
    {
        public String Name;
    }
}
