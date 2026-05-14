using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplesWithLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<(int Id, string Name, int Age)> people = new List<(int, string, int)> { 
                (1, "Alice", 30),
            (2, "Bob", 25),
            (3, "Charlie", 35),
            (4, "Diana", 28)};
            var filterPeople = people.Where(p => p.Age > 30);
            foreach(var person in filterPeople)
            {
                Console.WriteLine($"ID: {person.Id},Name: {person.Name},Age: {person.Age}");
            }
            double averageAge = people.Average(p => p.Age);
            Console.WriteLine("Average Age: " + averageAge);
            int minAge = people.Min(p => p.Age);
            Console.WriteLine("Min Age: " + minAge);
            int maxAge = people.Max(p => p.Age);
            Console.WriteLine("Max Age: " + maxAge);
            int sumAge = people.Sum(p=>p.Age);
            Console.WriteLine("Sum Age: " + sumAge);
            var SortedPeople = people.OrderBy(p => p.Age);
            Console.WriteLine("\n");
            foreach (var person in SortedPeople)
            {
                Console.WriteLine($"ID: {person.Id},Name: {person.Name},Age: {person.Age}");
            }
            var PeopleGroupedBy = people.GroupBy(p => (p.Id,p.Name,p.Age));
            Console.WriteLine("\n");
            foreach (var person in PeopleGroupedBy)
            {
                Console.WriteLine($"ID: {person.Key.Id},Name: {person.Key.Name},Age: {person.Key.Age}");
            }
            Console.ReadKey();
        }
    }
}
