using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    /* task 1: Create string variable with text “Hello”, read text from console, assign to next variable and write both strings use concatation. To read text use Console.ReadLine();

    task 2: Create string variable with text “Hello”, read text from console, assign to next variable and write both strings use string formatting. To read text use Console.WriteLine();
    
    task 3:Read text from console and write index of letter ‘a’ or ‘A’ in text.To read text use Console.WriteLine();
    task 4:Read text from console and if it contains substring “TU” then convert string to uppercase. To read text use Console.WriteLine();
    task 5:Create two constants - no of days in year and no of week.Second value should be calculated using first. Next try to modify constant(assign new value).
    task 6: Read text from console and convert to bool. Use Convert, Parse and TryParse.To read text use Console.WriteLine();
    task 7: Read text from console and convert to int. Use Convert, Parse and TryParse.To read text use Console.WriteLine();*/
    class Program
    {
        static void Main(string[] args)
        {
            task1();
            task2();
            task3();
            task4();
            task5();
            task6();
            task7();
            Console.ReadKey();
        }

        private static void task1()
        {
            string v = "Hello";
            string m = Console.ReadLine();

            Console.WriteLine(v + m);
        }

        private static void task2()
        {
            string v = "Hello";
            string m = Console.ReadLine();

            Console.WriteLine("{0}{1}",v,m);
        }

        private static void task3()
        { 

         string text = Console.ReadLine();
         int index_of_a = text.IndexOf("a");

         Console.WriteLine("index of a = {0}", index_of_a);

        }
        private static void task4()
        {
            string text = Console.ReadLine();

            if (text.Contains("TU"))
            {
                text = text.ToUpper();
            }

            Console.WriteLine(text);

        }
        private static void task5()
        {
            const int no_of_days_in_year = 365;
            const int no_of_week = no_of_days_in_year / 7;
           //no_of_days_in_year = 3; //cannot be because it's constant

        }
        private static void task6()
        {
            string text = Console.ReadLine();
            bool text_convert = Convert.ToBoolean(text);
            bool text_parse = Boolean.Parse(text);
            bool text_try_parse;
           bool result= Boolean.TryParse(text, out text_try_parse);
            Console.WriteLine("text_convert={0}\n text_parse={1}\n text_try_parse={2} result={3}", text_convert, text_parse, text_try_parse, result);
        }
        private static void task7()
        {
            string text = Console.ReadLine();
            int text_convert = Convert.ToInt32(text);
            int text_parse = Int32.Parse(text);
            int text_try_parse;
            bool result = Int32.TryParse(text, out text_try_parse);
            Console.WriteLine("text_convert={0}\n text_parse={1}\n text_try_parse={2} result={3}", text_convert, text_parse, text_try_parse, result);
        }
    }
}
