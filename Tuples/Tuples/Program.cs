using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, string, bool> myTuple = new Tuple<int, string, bool>(1, "Hello", true);
            Console.WriteLine(myTuple.Item1);
            Console.WriteLine(myTuple.Item2);
            Console.WriteLine(myTuple.Item3);
            var value = GetValue();
            Console.WriteLine($"Age: {value.Item1}");
            Console.WriteLine($"Name: {value.Item2}");
            (int, string, double) person = (1, "Alice", 5.5);
            // Access tuple elements
            Console.WriteLine("ID: " + person.Item1);
            Console.WriteLine("Name: " + person.Item2);
            Console.WriteLine("Height: " + person.Item3 + " feet");
        }
        static (int, string) GetValue()
        {
            return (31, "Mohammed Hammouz");
        }
    }
}
