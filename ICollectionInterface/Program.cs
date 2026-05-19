using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionInterface
{
    public class SimpleCollection<T> : ICollection<T>
    {
        private List<T> items = new List<T>();
        public int Count => items.Count;
        public bool IsReadOnly => false;
        public void Add(T item)
        {
            items.Add(item);
        }
        public bool Remove(T item)
        {
            return items.Remove(item);
        }
        public bool Contains(T item)
        {
            return items.Contains(item);
        }
        public void Clear()
        {
            items.Clear();
        }
        public void CopyTo(T[] array,int arrayIndex)
        {
            items.CopyTo(array, arrayIndex);
        }
        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SimpleCollection<int> items = new SimpleCollection<int>();
            items.Add(1);
            items.Add(2);
            items.Add(3);
            items.Add(4);
            Console.WriteLine(items.Count());
            Console.WriteLine("Print the elements of items");
            foreach(var item in items)
            {
                Console.WriteLine(item);
            }
            if (items.Contains(4))
                items.Remove(4);
            Console.WriteLine("Print the elements of items after removing element 4");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
