using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program

    {

        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("key1", "value1");
            hashtable.Add(2, "value2");
            hashtable.Remove(2);
            hashtable.Add("key3", "value3");
            hashtable.Add("key4", "value4");
            Console.WriteLine(hashtable["key3"]);
            foreach(DictionaryEntry entry in hashtable)
            {
                Console.WriteLine($"key = {entry.Key},value = {entry.Value}");
            }
            //Dictionary<int, int> dic = new Dictionary<int, int> { };
            Console.ReadLine();
        }
    }
}
