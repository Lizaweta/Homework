using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp4
{
    class Homework
    {
        static void Main(string[] args)
        {
            //Create method with 2 int variables. 
            //Method should display results of addition, subtraction, multiplication, division, remainder
            int variable1 = 15;
            int varible2 = 20;

            Console.WriteLine("Main_Task1");
            Console.WriteLine("sum = " + (varible2 + variable1));
            Console.WriteLine("sub = " + (varible2 - variable1));
            Console.WriteLine("mult = " + (varible2 * variable1));
            Console.WriteLine("div = " + (varible2 / variable1));
            Console.WriteLine("rem = " + (varible2 % variable1));
          
            Homework.Task2();
            Homework.Task3();
            new Homework().Task4();
            Homework h = new Homework();
            h.Task5();
            Console.ReadKey();

        }
        public static void Task2()
        {
            //Create method with 2 double variables. 
            //Method should display results of addition, subtraction, multiplication, division, remainder
            double variable3 = 2.5;
            double variable4 = 1.5;

            Console.WriteLine("\nTask2");
            Console.WriteLine("sum = " + (variable3 + variable4));
            Console.WriteLine("sub = " + (variable3 - variable4));
            Console.WriteLine("mult = " + (variable3 * variable4));
            Console.WriteLine("div = " + (variable3 / variable4));
            Console.WriteLine("rem = " + (variable3 % variable4));
            
        }
        public static void Task3()
        {
            //Create 3 int variables(a<b, b==c) and check all conditions to get true and false results.
            //To check equality use ==, Equals and CompareTo
            int a = 30;
            int b = 40;
            int c = 40;

            Console.WriteLine("\nTask3");
            Console.WriteLine(a == b);
            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a.CompareTo(b));

            Console.WriteLine(a == c);
            Console.WriteLine(a.Equals(c));
            Console.WriteLine(a.CompareTo(c));

            Console.WriteLine(c == b);
            Console.WriteLine(c.Equals(b));
            Console.WriteLine(c.CompareTo(b));
        }

        public void Task4()
        {
            //Create 3 double variables(a<b, b== c) and 
            // check all conditions to get true and false results.To check equality use ==, Equals and CompareTo
            double a2 = 0.25;
            double b2 = 0.50;
            double c2 = 0.50;

            Console.WriteLine("\nTask4");
            Console.WriteLine(a2 == b2);
            Console.WriteLine(a2.Equals(b2));
            Console.WriteLine(a2.CompareTo(b2));

            Console.WriteLine(a2 == c2);
            Console.WriteLine(a2.Equals(c2));
            Console.WriteLine(a2.CompareTo(c2));

            Console.WriteLine(c2 == b2);
            Console.WriteLine(c2.Equals(b2));
            Console.WriteLine(c2.CompareTo(b2));
           
        }
        public void Task5()
        {
            //Check logic operations (and/or/xor/conditional or/and),
            //to display value please directly enter true/false values. 
            //For conditional or/and use more than 2 values.

            bool t = true;
            bool f = false;
            bool k = true;
            bool? n = false;

            Console.WriteLine("\nTask5");
            Console.WriteLine("false=" + (t && f));
            Console.WriteLine("true=" + (t || f));
            Console.WriteLine("true=" + (t ^ f));
            Console.WriteLine("true=" + (t && f || k));
            Console.WriteLine("false=" + (t ? f : k));
            Console.WriteLine("false=" + (n ?? f));
            
        }
    }
}
