// using System.Xml;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        public void Addition<T>(T x, T y)
        {
            dynamic d1 = x;
            dynamic d2 = y;
            System.Console.WriteLine("Result is: " + d1 + d2);
            System.Console.WriteLine("Result is: " + x + y);
        }

        static void Main(string[] args)
        {
            // *****Array List******            
            // ArrayList al = new ArrayList();            
            // System.Console.Write("Enter the number of elements for array: ");            
            // int s = Convert.ToInt32(Console.ReadLine());            
            // for (int i=0; i<s; i++){            
            //     System.Console.Write("Enter value: ");            
            //     var ip = Console.ReadLine();            
            //     al.Add(ip);            
            // }            
            // foreach(Object obj in al){            
            //     System.Console.WriteLine(obj);            
            // }            

            //*****Hash Table*****            
            // Hashtable ht = new Hashtable();
            // System.Console.Write("Enter the number of elements for hashtable: ");            
            // int sh = Convert.ToInt32(Console.ReadLine());            
            // for (int i=0; i<sh; i++){            
            //     System.Console.Write("Enter key: ");            
            //     var k = Console.ReadLine()!;            
            //     System.Console.Write("Enter value: ");            
            //     var v = Console.ReadLine();            
            //     ht.Add(k,v);            
            // }            
            // foreach(Object obj in ht.Keys){            
            //     System.Console.WriteLine(obj +": " + ht[obj]);            
            // }      

            //Taking input from user without taking length.
            // System.Console.WriteLine("*****Hashtable*****");
            // do
            // {
            //     System.Console.WriteLine();
            //     System.Console.Write("Enter key: ");
            //     var k = Console.ReadLine()!;
            //     System.Console.Write("Enter value: ");
            //     var v = Console.ReadLine();
            //     ht.Add(k, v);

            //     System.Console.Write("Press <end> to exit: ");
            // } while (Console.ReadKey().Key != ConsoleKey.End);

            // System.Console.WriteLine();
            // foreach (Object obj in ht.Keys)
            // {
            //     System.Console.WriteLine(obj + ": " + ht[obj]);
            // }

            //*****Dictionary*****
            // Dictionary<string,string> dt = new Dictionary<string, string>();
            // dt.Add("Name","Abhishek");
            // dt.Add("Age","Twenty");
            // dt.Add("Loc","Kolkata");
            // dt.Add("Country","India");

            // System.Console.WriteLine("***Dictionary***");
            // do
            // {
            //     System.Console.Write("Enter key: ");
            //     var ky = Console.ReadLine()!;
            //     System.Console.Write("Enter value: ");
            //     var vl = Console.ReadLine()!;
            //     dt.Add(ky,vl);

            //     System.Console.WriteLine("Press <end> to exit: ");
            // } while (Console.ReadKey().Key != ConsoleKey.End);

            // foreach (var item in dt)
            // {
            //     System.Console.WriteLine(item);
            // }

            // foreach (var item in dt.Keys)
            // {
            //     System.Console.WriteLine(item + ":" + dt[item]);
            // }

            //Generics
            Program p1 = new Program();
            bool res = p1.Compare<float>(9, 9);
            System.Console.WriteLine(res);

            //Doubt<<<<<<
            p1.Addition<int>(7, 9);
            p1.Addition<string>("bihar", "jharkhand");



            //*****Stack******
            Stack<int> st = new Stack<int>();
            st.Push(6);
            st.Push(2);
            st.Push(1);
            st.Push(45);

            System.Console.WriteLine("***Stack***");
            do
            {
                System.Console.Write("Enter a value: ");
                int val = Convert.ToInt32(Console.ReadLine());
                st.Push(val);

                System.Console.WriteLine("Press <end> to exit: ");
            } while (Console.ReadKey().Key != ConsoleKey.End);

            foreach (var item in st)
            {
                System.Console.WriteLine("Value stored in stack: " + item);
            }

            //Pop one item from top of the stack
            var exp = st.Pop();
            System.Console.WriteLine("Value poped out is " + exp);
            var topElement = st.Peek();
            System.Console.WriteLine("Element at top of stack: " + topElement);

            System.Console.WriteLine("Stack after poping one value:-");
            foreach (var item in st)
            {
                System.Console.WriteLine("Value stored in stack: " + item);
            }

            st.Pop();
            st.Pop();
            st.Pop();
            //st.Pop();----->>>>>Exception raised(InvalidOperationException)

            // System.Console.WriteLine("Stack after poping all value");
            // foreach (var item in st)
            // {
            //     System.Console.WriteLine("Value stored in stack: " + item);
            // }



            //*****Queue*****
            Queue<int> qt = new Queue<int>();
            qt.Enqueue(8);
            qt.Enqueue(32);
            qt.Enqueue(0);
            qt.Enqueue(5);
            qt.Enqueue(21);


            System.Console.WriteLine("***Queue***");
            do
            {
                System.Console.Write("Enter a value: ");
                int val = Convert.ToInt32(Console.ReadLine());
                qt.Enqueue(val);

                System.Console.WriteLine("Press <end> to exit: ");
            } while (Console.ReadKey().Key != ConsoleKey.End);


            foreach (var item in qt)
            {
                System.Console.WriteLine("Value stored in queue: " + item);
            }


            //Dequeue element from front in queue
            var dq = qt.Dequeue();
            System.Console.WriteLine("Element dequed from queue: " + dq);


            System.Console.WriteLine("Queue after dequing an element:-");
            foreach (var item in qt)
            {
                System.Console.WriteLine("Value stored in queue: " + item);
            }

        }
    }
}