using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IListCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleList<string> myList = new SimpleList<string>();
            myList.Add("First");
            myList.Add("Second");
            myList.Insert(1, "Inserted");

            Console.WriteLine("List after adding and inserting:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }


            myList.RemoveAt(1); // Removes "Inserted"
            myList[0] = "Updated First"; // Update the first item


            Console.WriteLine("\nList after removing and updating:");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
