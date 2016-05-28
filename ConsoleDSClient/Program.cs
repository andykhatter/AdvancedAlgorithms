using AdvancedDatastructures.LinkedListImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDSClient
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            TestLinkedList();


        }

        public static void TestLinkedList()
        {
            LinkedList list = new LinkedList();
            list.Insert("node1");
            list.Insert("node2");
            list.Insert("node3");
            list.Insert("node3");
            list.Insert("node5");

            list.PrintLinkedList();
            Console.WriteLine("------------------");
            list.DeleteDuplicates();
            list.PrintLinkedList();
         //   Console.WriteLine(list.GetFirstElement().ToString());
         //   Console.WriteLine(list.GetCurrentValue().ToString());
            Console.ReadLine();
        }
    }
}
