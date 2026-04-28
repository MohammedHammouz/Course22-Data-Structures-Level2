using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Libraries = new SortedList<string, int> { { "Python", 1 }, { "Java", 2 }, { "JavaScript", 3 }, { "C#", 4 }, { "C++", 5 } };
            foreach (var language in Libraries)
                Console.WriteLine($"Programming language: {language.Key}, Rank of skill: {language.Value}");
            var LibrariesInfo = Libraries.Where(LibKV => LibKV.Value > 2);
            foreach (var language in LibrariesInfo)
                Console.WriteLine($"Programming language: {language.Key}, Rank of skill: {language.Value}");
            SortedList<int, string> sortedList = new SortedList<int, string>()
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Cherry" },
                { 4, "Date" },
                { 5, "Grape" },
                { 6, "Fig" },
                { 7, "Elderberry" }
            };
            Console.WriteLine("Grouping fruits by the length of their names:");
            var groups = sortedList.GroupBy(KVP => KVP.Value.Length);
            foreach (var group in groups)
            {
                Console.WriteLine($"Name Length {group.Key}: {string.Join(",",group.Select(KVP=>KVP.Value))}");
            }
           groups = sortedList.GroupBy(KVP => KVP.Value.Length%2);
            foreach (var group in groups)
            {
                Console.WriteLine($"Name Length {group.Key}: {string.Join(",", group.Select(KVP => KVP.Value))}");
            }
            groups = sortedList.GroupBy(KVP => KVP.Value.IndexOf(KVP.Value.First()));
            foreach (var group in groups)
            {
                Console.WriteLine($"Name`[`{string.Join(",", group.Select(KVP => KVP.Value))}`]`");
                
            }
            SortedList<int, Employee> employees = new SortedList<int, Employee>()
{
                { 1, new Employee("Alice", "HR", 50000) },
                { 2, new Employee("Bob", "IT", 70000) },
                { 3, new Employee("Charlie", "HR", 52000) },
                { 4, new Employee("Daisy", "IT", 80000) },
                { 5, new Employee("Ethan", "Marketing", 45000) }
             };
            var query = employees.Where(KVP => KVP.Value.Department == "IT")
                .OrderByDescending(KVP=>KVP.Value.Name)
                .Select(KVP => KVP.Value.Name)
                ;
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
            query = employees.Where(KVP => KVP.Value.Salary>50000)
                .OrderByDescending(KVP => KVP.Value.Name)
                .Select(KVP => KVP.Value.Name)
                ;
            foreach (var name in query)
            {
                Console.WriteLine(name);
            }
        }
        public class Employee
        {
            public string Name { get; set; }
            public string Department { get; set; }
            public decimal Salary { get; set; }


            public Employee(string name, string department, decimal salary)
            {
                Name = name;
                Department = department;
                Salary = salary;
            }
        }

    }
}
