using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> fruits = new HashSet<string>();
            fruits.Add("Apple");
            fruits.Add("Banana");
            fruits.Add("Orange");
            fruits.Add("Mango");
            foreach (string item in fruits)
                Console.WriteLine($"item:{item}");
            Console.WriteLine("\n\nChecking for Existence in HashSet");
            if(fruits.Contains("Apple"))
                Console.WriteLine("Apple is in the HashSet");
            else
                Console.WriteLine("Apple is not in the HashSet");
            Console.WriteLine("\n\nRemoving Elements from HashSet");
            if (fruits.Contains("Milon"))
                fruits.Remove("Milon");
            else
                Console.WriteLine("Milon is not in the HashSet");
            Console.WriteLine("\n\nUsing HashSet to Remove Duplicates");
            // Array with duplicate values
            int[] array = new int[] { 1, 2, 2, 3, 4, 4, 5 };
            HashSet<int> uniqueNumbers = new HashSet<int>(array);
            foreach (int number in uniqueNumbers)
                Console.WriteLine(number);
            Console.WriteLine("\n\nUsing HashSet with LINQ in C#");
            var evenNumbers = uniqueNumbers.Where(num => num % 2 == 0);
            Console.WriteLine("\n\nEven Numbers:");
            foreach (var number in evenNumbers)
            {
                Console.WriteLine(number);
            }
            // Creating and populating a HashSet of strings
            HashSet<string> names = new HashSet<string> { "Alice", "Bob", "Charlie", "Daisy", "Ethan", "Fiona" };


            // Using LINQ to filter names that start with 'C'
            var namesStartingWithC = names.Where(name => name.StartsWith("C"));


            // Displaying the names starting with 'C'
            Console.WriteLine("Names Starting with C:");
            foreach (var name in namesStartingWithC)
            {
                Console.WriteLine(name);
            }


            // Using LINQ to find names with length greater than 4 characters
            var namesLongerThanFour = names.Where(name => name.Length > 4);


            // Displaying the names longer than four characters
            Console.WriteLine("\nNames Longer Than Four Characters:");
            foreach (var name in namesLongerThanFour)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
