using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Block5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task1");
            first_task();
            Console.WriteLine();
            Console.WriteLine("Task2");
            second_task();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Task3");
            third_task();
            Console.WriteLine();
            Console.WriteLine("Task4");
            fourth_task();
            
            Console.ReadKey();
            
        }
        public static void first_task()
        {
            int[] first_table = { 8, 3, 5, 9, 4, 3 };
            int[] second_table = { 9, 20, 45, 55, 12, 34, 65, 47, 6, 10, 75 };

            int[] table_short;
            int[] table_long;


            int max_length_of_tables = Math.Max(first_table.Length, second_table.Length);
            int[] sum_table = new int[max_length_of_tables];
            if (first_table.Length > second_table.Length)
            {
                table_short = second_table;
                table_long = first_table;

            }
            else
            {
                table_short = first_table;
                table_long = second_table;
            }

            int index_for_using = table_long.Length - 1;

            for (int i = 0; i < table_short.Length; i++)
            {
                sum_table[i] = first_table[i] + second_table[i];
            }
            for (int i = index_for_using; i >= table_short.Length; i--)

                sum_table[i] = table_long[i];

            foreach (int element in sum_table)
            {
                Console.WriteLine(element);
            }
        }
        public static void second_task()
        {
            int[] table_1 = { 1, 3, 4, 9, 5, 6, 8 };
            const int N = 3;
          
           for (int i =N+1; i < table_1.Length; i++)
            
            {
                table_1[i - 1] = table_1[i];
            }
            foreach (int element in table_1)
            {
                Console.Write(element + " ");
            }
        }
        public static void third_task()
        {
            int[] table_a = { 2, 6, 7 };
            int[] new_table = new int[table_a.Length + 1];
            for (int i = 0; i< table_a.Length; i++)
            {
                new_table[i] = table_a[i];
            }
           
            new_table[new_table.Length - 1] = 0;
           
            foreach (int element in new_table)
            {
                Console.WriteLine(element);
            }
        }
        public static void fourth_task ()
        {
            int[] table_b = { 4, 9, 6, 7, 7, 9, 6, 34 };
            int[] new_table = new int[table_b.Length + 1];
            int N = table_b.Length/2;

            for (int i = 0; i < N; i++)

            {
                new_table[i] = table_b[i];
            }
            new_table[N] = 25;

            for (int i = N; i < table_b.Length; i++)
            {
                new_table[i+1] = table_b[i];
            }

            foreach (int element in new_table)
            {
                Console.WriteLine(element);
            }
        }
      
    }
}
