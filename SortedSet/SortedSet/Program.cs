using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedSet<int> sortedSet = new SortedSet<int>();
            sortedSet.Add(1);
            sortedSet.Add(2);
            sortedSet.Add(3);
            sortedSet.Add(4);
            sortedSet.Add(10);
            sortedSet.Add(7);
            sortedSet.Add(8);
            sortedSet.Add(5);
            foreach (int element in sortedSet)
                Console.WriteLine(element);
            int target = 3;
            if (sortedSet.Contains(target))
                Console.WriteLine($"Element {target} exists in the SortedSet.");
            sortedSet.Remove(2);
            Console.WriteLine("SortedSet elements after removal:");
            foreach (int element in sortedSet)
                Console.WriteLine(element);
            SortedSet<int> sortedSet1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            var filteredSet = sortedSet1.Where(element => element > 2);
            Console.WriteLine("Filtered Set:");
            foreach (var element in filteredSet)
                Console.Write(element+" ");
            Console.WriteLine();
            var sum = sortedSet1.Sum();
            Console.WriteLine("Sum of all elements: " + sum);
            var maxElement = sortedSet1.Max();
            var minElement = sortedSet1.Min();
            Console.WriteLine("Maximum element: " + maxElement);
            Console.WriteLine("Minimum element: " + minElement);
            var DescendingSet = sortedSet1.OrderByDescending(x => x);
            Console.WriteLine("Descending Sorted Set:");
            foreach (var item in DescendingSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SortedSet<int> numbers = new SortedSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbersSquared = numbers.Where(x => x % 2 == 0).Select(x => x = x * x);
            Console.WriteLine("Squares of even numbers:");
            foreach (var item in evenNumbersSquared)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SortedSet<int> set1 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            SortedSet<int> set2 = new SortedSet<int>() { 3, 4, 5, 6, 7 };
            SortedSet<int> UnionSet = new SortedSet<int>();
            UnionSet.UnionWith(set2);
            Console.WriteLine("\nUnion:");
            foreach (int item in UnionSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SortedSet<int> intersectSet = new SortedSet<int>(set1);
            intersectSet.IntersectWith(set2);
            Console.WriteLine("\nIntersection:");
            foreach (int item in intersectSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            SortedSet<int> differenceSet = new SortedSet<int>();
            differenceSet.ExceptWith(set2);
            Console.WriteLine("\nDifference (set1 - set2):");
            foreach (int item in differenceSet)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\nSubset:");
            if(set1.IsSupersetOf(set2))
                Console.WriteLine("Set1 is a superset of Set2");
            else
                Console.WriteLine("Set1 is not a superset of Set2");
            SortedSet<int> set3 = new SortedSet<int>() { 1, 2, 3, 4, 5 };
            SortedSet<int> set4 = new SortedSet<int>() { 3, 4, 5, 6, 7 };
            Console.WriteLine(set3.Equals(set4));
            Console.WriteLine(set3.IsSubsetOf(set4));
            Console.WriteLine(set3.IsSupersetOf(set4));
            Console.ReadKey();
        }
    }
}
