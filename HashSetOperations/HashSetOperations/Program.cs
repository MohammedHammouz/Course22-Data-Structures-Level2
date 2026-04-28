using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashSetOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
            set1.UnionWith(set2);
            Console.WriteLine("Union of sets:");
            foreach (int item in set1)
            {
                Console.WriteLine(item);
            }
            HashSet<int> set3 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set4 = new HashSet<int> { 3, 4, 5 };
            set3.IntersectWith(set4);
            Console.WriteLine("Intersection of sets:");
            foreach (int item in set3)
            {
                Console.WriteLine(item);
            }
            HashSet<int> set5 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set6 = new HashSet<int> { 3, 4, 5 };
            set5.ExceptWith(set6);
            Console.WriteLine("Difference of sets (set5-set6)");
            foreach (int item in set5)
            {
                Console.WriteLine(item);
            }
            HashSet<int> set7 = new HashSet<int> { 1, 2, 3 };
            HashSet<int> set8 = new HashSet<int> { 3, 4, 5 };
            set7.SymmetricExceptWith(set8);
            Console.WriteLine("Symmetric difference of sets:");
            foreach (int item in set7)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Is set7 equals to set8? {set7.Equals(set8)}");
            Console.WriteLine($"Is set7 subset of set8? {set7.IsSubsetOf(set8)}");
            Console.WriteLine($"Is set7 superset of set8? {set7.IsSupersetOf(set8)}");
            Console.ReadKey();
        }
    }
}
