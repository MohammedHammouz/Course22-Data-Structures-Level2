using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(10);
            arrayList.Add("Hello");
            arrayList.Add(true);
            Console.WriteLine("Elements in ArrayList:");
            foreach (var item in arrayList)
                Console.WriteLine(item);
            for (int i = 0; i < arrayList.Count; i++)
                Console.WriteLine($"index : {i},item = {arrayList[i]}");
            System.Collections.ArrayList arrayList1 = new System.Collections.ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var evenNumbers = arrayList1.Cast<int>().Where(x => x % 2 == 0);
            Console.WriteLine("All even numbers:");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }
            System.Collections.ArrayList arrayList2 = new System.Collections.ArrayList { 10, 5, 20, 15, 30 };
            var maxValue = arrayList2.Cast<int>().Max();
            var minValue = arrayList2.Cast<int>().Min();
            var Sum = arrayList2.Cast<int>().Sum();
            var Average = arrayList2.Cast<int>().Average();
            var Count = arrayList2.Cast<int>().Count();
            Console.WriteLine("\nArrayList Items: ");
            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.Write(arrayList[i].ToString() + " ");
            }
            Console.WriteLine("\n\nMinimum value in the ArrayList: " + minValue);
            Console.WriteLine("Maximum value in the ArrayList: " + maxValue);
            Console.WriteLine("Sum values in the ArrayList: " + Sum);
            Console.WriteLine("Average values in the ArrayList: " + Average);
            Console.WriteLine("Count Items in the ArrayList: " + Count);
            arrayList2.Sort();
            Console.WriteLine("\nArrayList Items After Sorting: ");
            for (int i = 0; i < arrayList2.Count; i++)
            {
                Console.Write(arrayList2[i].ToString() + " ");
            }
            System.Collections.ArrayList arrayList3 = new System.Collections.ArrayList { 1, 2, 3, 2, 4, 2, 5 };
            int targetNumber = 2;
            var count = arrayList3.Cast<int>().Count(number => number == targetNumber);
            Console.WriteLine($"\nNumber of occurrences of {targetNumber} in the ArrayList: {count}");
        }
    }
}
