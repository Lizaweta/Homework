using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Dictionary
{
    class Program
    {
        //Create dictionary with pairs of products and prices. 
        // Specify shopping list with multiple products from #1
        //Calculate total price of items from your shopping list
        static void Main(string[] args)
        {
            Dictionary<string, double> shopping_helper = new Dictionary<string, double>();
            shopping_helper.Add("apple", 2.50);
            shopping_helper.Add("orange", 2.75);
            shopping_helper.Add("grape", 3.25);
            shopping_helper.Add("banana", 3.15);

            List<string> shopping_list = new List<string>();
            shopping_list.Add("apple");
            shopping_list.Add("apple");
            shopping_list.Add("banana");
            shopping_list.Add("orange");

            foreach (KeyValuePair<string, double> element in shopping_helper)
            {
                Console.WriteLine("Product: {0}, Price: {1}", element.Key, element.Value);

            }

            double sum_of_list = 0;
            foreach (string product in shopping_list)
            {

                double p;
                shopping_helper.TryGetValue(product, out p);
                sum_of_list = sum_of_list + p;
            }
            Console.WriteLine("Sum of list =" + sum_of_list);
            Console.ReadKey();
        }
    }
}
