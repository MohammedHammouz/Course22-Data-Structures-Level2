using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
namespace Observable_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observable_Collections");
            System.Collections.ObjectModel.ObservableCollection<string> names = new System.Collections.ObjectModel.ObservableCollection<string>();
            names.CollectionChanged += Names_CollectionChanged;
            names.Add("Alice");
            names.Add("Bob");
            names.Add("James");
            names.Add("Jack");
            foreach (var name in names)
                Console.WriteLine(name);
            names.RemoveAt(1);
            names.Insert(0, "Mohammed");
            names[1] = "Hammouz";
            names.Move(0, 2);
            
            Console.ReadKey();
        }
        static void Names_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Added");
                    foreach (var name in e.NewItems)
                        Console.WriteLine(name);
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Move:
                    Console.WriteLine("Moved");
                    Console.WriteLine($"- From index {e.OldStartingIndex} to index {e.NewStartingIndex}");

                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Replaced:");
                    foreach (var oldItem in e.OldItems)
                    {
                        Console.WriteLine("- " + oldItem);
                    }
                    Console.WriteLine("With:");
                    foreach (var newItem in e.NewItems)
                    {
                        Console.WriteLine("- " + newItem);
                    }
                    break;
                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Removed:");
                    foreach (var oldItem in e.OldItems)
                    {
                        Console.WriteLine("- " + oldItem);
                    }
                    break;
                
            }
        }
    }
}
