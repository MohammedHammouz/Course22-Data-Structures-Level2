using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>();
            fruitBasket.Add("Apple", 5);
            fruitBasket.Add("Banana", 2);
            fruitBasket.Add("Orange", 12);
            int appleQuantity = fruitBasket["Apple"];
            if (fruitBasket.ContainsKey("Apple"))
                Console.WriteLine($"Apple Quantity:{appleQuantity}\n\n");
            foreach(KeyValuePair<string,int>fruit in fruitBasket)
            {
                Console.WriteLine($"fruit:{fruit.Key},Quantity:{fruit.Value}");
            }
            if (fruitBasket.ContainsKey("Apple"))
                fruitBasket["Apple"] = 10;
            if (fruitBasket.ContainsKey("Mango"))
                fruitBasket.Remove("Mango");
            else
                Console.WriteLine("There is no key Mango");
            //Implementing TryGetValue method
            Console.WriteLine("\n\nImplementing TryGetValue method");
            if (fruitBasket.TryGetValue("Apple",out int AppleQuantity))
                Console.WriteLine($"Apple quantity: {AppleQuantity}");
            else
                Console.WriteLine("Apple not found in the basket.");
            //Utilizing LINQ with Dictionaries
            //Selecting Items
            Console.WriteLine("\n\nSelecting Items");
            var fruitInfo = fruitBasket.Select(fruit => new {fruit.Key,fruit.Value});
            foreach(var item in fruitInfo)
            {
                Console.WriteLine($"Fruit:{item.Key},Quantity:{item.Value}");
            }
            //Filtering Items
            Console.WriteLine("\n\nFiltering Items");
            var filteredFruit = fruitBasket.Where(kpv => kpv.Value > 3);
            foreach (var item in filteredFruit)
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            //Sorting Dictionary Items
            Console.WriteLine("\n\nSorting Dictionary Items");
            var sortedFruits = fruitBasket.OrderBy(kyv => kyv.Value);
            foreach (var item in sortedFruits)
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            Console.WriteLine("\n\nSorting Descending Dictionary Items");
            var sortedFruitsDescending = fruitBasket.OrderByDescending(kyv => kyv.Value);
            foreach (var item in sortedFruitsDescending)
                Console.WriteLine($"Fruit: {item.Key}, Quantity: {item.Value}");
            //Aggregating Data
            Console.WriteLine("\n\nFinding Total Quantity");
            var totalQuantity = fruitBasket.Sum(kyv => kyv.Value);
            Console.WriteLine($"\n\nTotal Quantity: {totalQuantity}");
            Console.WriteLine("\n\nCombining LINQ Queries");
            var sortedFilteredFruits = fruitBasket
                                    .Where(kyv => kyv.Value > 3)
                                    .OrderBy(kyv => kyv.Value)
                                    .Select(kyv => new { kyv.Key, kyv.Value });
            foreach (var fruit in sortedFilteredFruits)
            {
                Console.WriteLine($"Fruit: {fruit.Key}, Quantity: {fruit.Value}");
            }
        }
    }
}
