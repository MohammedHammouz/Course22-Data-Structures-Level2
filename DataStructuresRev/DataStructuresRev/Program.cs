using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresRev
{

    
    internal class Program
    {
        class Matrix {
            
            public static void PrintMatrixArray(int[,] arr)
            {
                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        Console.Write("{0} ",arr[i, j]);
                    }
                }
            }
            
        }
        class Array
        {
            public static void PrintArray(int[] arr)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write("{0} ", arr[i]);
                }
            }
        }
        class Stacks
        {
            public static void PushStack(ref Stack<int> stack,int number)
            {
                
                stack.Push(number);
                
            }
            public static void GetStackSize(Stack<int> stack)
            {
                Console.WriteLine("\n Size of stack= {0}", stack.Count);
            }
            public static void PrintTopElementOfStack(Stack<int> stack)
            {
                if (stack.Count != 0)
                    Console.WriteLine("\nTop element Of stack = {0}", stack.Peek());
                else
                    Console.WriteLine("\n The length of stack =0");
            }
            public static void PopElementFromStack(ref Stack<int> stack)
            {
                if (stack.Count != 0)
                    stack.Pop();
                else
                    Console.WriteLine("\n The length of stack = 0");

            }
            public static void SwapStacks(ref Stack<int> stack1, ref Stack<int> stack2)
            {
                Stack<int> temp  = new Stack<int>();
                temp = stack1;
                stack1= stack2;
                stack2= temp;
            }
        }
        class Queues { 
            public static void PushQueue(ref Queue<int> queue,int number)
            {
                queue.Enqueue(number);
            }
            public static void GetQueueSize(Queue<int> queue)
            {
                if (queue.Count != 0)
                    Console.WriteLine($"Queue size: {queue.Count}");
                else
                    Console.WriteLine($"Queue size = 0");
            }
            public static void PrintTopElementOfQueue(Queue<int> queue)
            {
                if(queue.Count != 0)
                    Console.WriteLine($"First element of queue: {queue.Peek()}");
                else
                    Console.WriteLine($"Queue size = 0");
            }
            public static void PrintBackElementOfQueue(Queue<int> queue)
            {
                if (queue.Count != 0)
                    Console.WriteLine($"Last element of queue: {queue.Last()}");
                else
                    Console.WriteLine($"Queue size = 0");
            }
            public static void PopElementFromQueue(ref Queue<int> queue)
            {
                if (queue.Count != 0)
                    queue.Dequeue();
                else
                    Console.WriteLine($"Queue size = 0");
            }
            public static void SwapQueues(ref  Queue<int> queue1,ref  Queue<int> queue2)
            {
                Queue<int> temp = queue1;
                queue1 = queue2;
                queue2= temp;
            }
        }
        
        class SinglyLinkedList
        {
            
            public class Node
            {
                public int Data
                {
                    get;
                    set; 
                }
                public Node next
                {
                    get;
                    set;
                }
                public Node(int Data)
                {
                    this.Data = Data;
                    this.next = null;
                }
                
            }
            public Node head
            {
                get;
                set;
            }
            public SinglyLinkedList()
            {
                this.head = null;
            }
            public void insertAtBeginingOfLinkedList(int Data)
            {
                Node node = new Node(Data);
                if (head == null)
                {
                    this.head = node;
                }
                else {
                    Node Current = this.head;
                    node.next = Current;
                    head= node;
                }
            }
            public void InsertAtEnd( int Data)
            {
                if (this.head == null)
                {
                    this.insertAtBeginingOfLinkedList(Data);
                }
                else
                {
                    Node node = new Node(Data);
                    Node current= this.head;
                    while ( current.next!=null)
                    {
                        current = current.next;
                    }
                    current.next = node;
                }
            }
            public void InsertAt(int Data,int Position)
            {
                

                if (this.head == null)
                {
                    this.insertAtBeginingOfLinkedList(Data);
                }
                
                else
                {
                    Node node = new Node(Data);
                    Node prev= this.head;
                    Node current =this.head;
                    int count = 0;
                    for(int i = 0; i < Position; i++)
                    {
                        if (current != null)
                        {
                            prev = current;
                            current = current.next;
                            count++;
                        }
                        else
                        {
                            break;
                        }
                       
                    }
                    if (count < Position)
                    {
                        prev.next = node;
                    }
                    else
                    {
                        prev.next = node;
                        prev.next.next = current;
                    }
                        
                }
            }
            public void DeleteBegin()
            {
                if(this.head == null)
                {
                    return;
                }
                else
                {
                    this.head=this.head.next;
                }
            }
            public void DeleteAtEnd()
            {
                
                if (this.head == null)
                {
                    return;
                }
                Node current = this.head;
                Node current1 = current;
                while (current.next!=null)
                {
                    current1 = current;
                    current=current.next;
                }
                current1.next = null;
                //40->30->140->120->20->10->190->100->
                //current=100
                //current1=190
            }
            public void DeleteAt(int index)
            {
                if (this.head == null)
                {
                    return;
                }
                Node prev= this.head;
                Node current = this.head;
                int counter = 0;
                for(int i = 0; i < index; i++)
                {
                    if (current != null)
                    {
                        prev = current;
                        current = current.next;

                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter < index)
                {
                    return;
                }
                prev.next = current.next;
                //40->30->140->120->20->10->190
            }
            public void Print()
            {
                Node current=this.head;
                while (current != null) { 
                    Console.Write($"{current.Data}->");
                    current = current.next;
                }
            } 
        }
        class DoublyLinkedList
        {
            
            public class Node 
            {
                public int Data;
                public Node prev;
                public Node next;
                public Node(int Data)
                {
                    this.prev = null;
                    this.Data = Data;
                    this.next = null;
                }
                
            }
            public Node head;
            public void InsertAtBegin(int NewData)
            {
                Node NewNode = new Node(NewData);
                if (this.head == null)
                {
                    this.head = NewNode;

                }
                else
                {
                    NewNode.next = this.head;
                    this.head.prev = NewNode;
                  
                    this.head = NewNode;
                }

            }
            public void InsertAtEnd(int Data)
            {
                Node NewNode = new Node(Data);
                if (this.head == null)
                {
                    InsertAtBegin(Data);
                    return;
                }
                else
                {
                    Node current = this.head;
                    while (current.next != null)
                    {
                        current = current.next;
                    }
                    NewNode.prev = current;
                    current.next = NewNode;
                }
            }
            public void InsertAt(int Data,int Position)
            {
                Node NewNode = new Node(Data);
                if (this.head == null)
                {
                    InsertAtBegin(Data);
                    return;
                }
                else
                {
                    Node current = this.head;
                    Node prev1 = this.head;
                    int counter = 1;
                    for (int i = 0; i < Position-1; i++)
                    {
                        if (current != null)
                        {
                            prev1 = current;
                            current = current.next;
                            counter++;
                            
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (counter < Position)
                    {
                        InsertAtEnd(Data);
                    }
                    else
                    {
                        NewNode.next = current;
                        NewNode.prev = prev1;
                        current.prev = NewNode;
                        prev1.next = NewNode;
                    }
                        
                    
                }
            }
            public void DeleteAtBegin()
            {
                if (this.head == null)
                {
                    return;
                }
                this.head = this.head.next;
            }
            public void DeleteAtEnd()
            {
                if (this.head == null)
                {
                    return;
                }
                Node current = this.head;
                Node prev = current;
                while (current.next != null)
                {
                    prev = current;
                    current = current.next;
                }
                prev.next = null;
            }
            public void DeleteAt(int Position)
            {
                Node current = this.head;

                Node prev = current;
                int counter = -1;
                if (Position == 0)
                {
                    DeleteAtBegin();
                }
                if (this.head == null)
                {
                    return;
                }
                for (int i = 0; i < Position-1; i++)
                {
                    if (current != null)
                    {
                        
                        prev = current;
                        current = current.next;
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                
                if (counter < Position)
                {
                    return;
                }
                else
                {
                    
                    prev.next = current.next;
                    current.next.prev = prev;
                }

            }
            public void Print()
            {
                Node current = this.head;
                while (current != null)
                {
                    Console.Write($"{current.Data}<-->");
                    current = current.next;
                }
            }
        }
        static void Main(string[] args)
        {
            //int[] arr1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //Console.WriteLine("Array Elements :");
            //Array.PrintArray(arr1);
            //int[,] arr = { { 1, 2, 3 }, { 4, 5, 6 } };
            //Console.WriteLine("\nMatrix Elements :");
            //Matrix.PrintMatrixArray(arr);
            //Stack<int> stack = new Stack<int>();
            //Stacks.PushStack(ref stack,1);
            //Stacks.PushStack(ref stack, 2);
            //Stacks.PushStack(ref stack, 3);
            //Stacks.PushStack(ref stack, 4);
            //Stacks.PushStack(ref stack, 5);
            //Console.WriteLine("\nSize of stack={0}",stack.Count);
            //Stacks.GetStackSize(stack);
            //Stacks.PrintTopElementOfStack(stack);
            //Stacks.PopElementFromStack(ref stack);
            //Stacks.PrintTopElementOfStack(stack);
            //Stacks.GetStackSize(stack);
            //Stacks.PopElementFromStack(ref stack);
            //Stacks.GetStackSize(stack);
            //Stack<int> stack1 = new Stack<int>();
            //Stacks.PushStack(ref stack1, 1);
            //Stacks.PushStack(ref stack1, 2);
            //Stacks.PushStack(ref stack1, 3);
            //Stacks.PushStack(ref stack1, 4);
            //Stacks.PushStack(ref stack1, 5);
            //Stacks.PushStack(ref stack1, 6);
            //Stacks.PushStack(ref stack1, 7);
            //Stacks.PushStack(ref stack1, 8);
            //Stacks.PushStack(ref stack1, 9);
            //Stacks.PushStack(ref stack1, 10);
            //Stacks.PrintTopElementOfStack(stack);
            //Stacks.PrintTopElementOfStack(stack1);
            //Stacks.SwapStacks(ref stack, ref stack1);
            //Stacks.PrintTopElementOfStack(stack);
            //Stacks.PrintTopElementOfStack(stack1);

            //Queue<int> queue = new Queue<int>();
            //Queues.PushQueue(ref queue, 10);
            //Queues.PushQueue(ref queue, 20);
            //Queues.PushQueue(ref queue, 30);
            //Queues.PushQueue(ref queue, 40);
            //Queues.PushQueue(ref queue, 50);
            //Queues.GetQueueSize(queue);
            //Queues.PrintTopElementOfQueue(queue);
            //Queues.PrintBackElementOfQueue(queue);

            //Queues.PrintTopElementOfQueue(queue);
            //Queues.PrintBackElementOfQueue(queue);
            //Queue<int> queue1 = new Queue<int>();
            //Queues.PushQueue(ref queue1, 60);
            //Queues.PushQueue(ref queue1, 70);
            //Queues.PushQueue(ref queue1, 80);
            //Queues.PushQueue(ref queue1, 90);
            //Queues.PushQueue(ref queue1, 100);
            //Queues.GetQueueSize(queue1);
            //Console.WriteLine("\nQueues before swaping");
            //Queues.PrintTopElementOfQueue(queue);
            //Queues.PrintBackElementOfQueue(queue);

            //Queues.PrintTopElementOfQueue(queue1);
            //Queues.PrintBackElementOfQueue(queue1);
            //Queues.SwapQueues(ref queue, ref queue1);
            //Console.WriteLine("\nQueues after swaping");
            //Queues.PrintTopElementOfQueue(queue);
            //Queues.PrintBackElementOfQueue(queue);
            //Queues.PrintTopElementOfQueue(queue1);
            //Queues.PrintBackElementOfQueue(queue1);
            SinglyLinkedList singlyLinkedList = new SinglyLinkedList();
            singlyLinkedList.InsertAt(190, 3);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.DeleteAt(1000);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.insertAtBeginingOfLinkedList(10);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.insertAtBeginingOfLinkedList(20);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.insertAtBeginingOfLinkedList(30);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.insertAtBeginingOfLinkedList(40);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.insertAtBeginingOfLinkedList(50);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.InsertAtEnd(100);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.InsertAt(120, 590);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.InsertAt(140, 111111);
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.DeleteBegin();
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.DeleteAtEnd();
            singlyLinkedList.Print();
            Console.WriteLine("");
            singlyLinkedList.DeleteAt(3);
            singlyLinkedList.Print();
            Console.WriteLine("");
            //DoublyLinkedList doublyLinkedList = new DoublyLinkedList();
            //doublyLinkedList.InsertAtBegin(1);
            //doublyLinkedList.DeleteAt(100);

            //doublyLinkedList.Print();
            //Console.WriteLine("");
            //SinglyLinkedList sll = new SinglyLinkedList();
            //sll.DeleteAt(100);
            //sll.Print();
            //Console.ReadLine();
        }
    }
}
