using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListGenericExample
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListGeneric<int> list1 = new LinkedListGeneric<int>();
            list1.Insert(12);
            list1.Insert(14);
            list1.Insert(45);
            Console.WriteLine("Inhoud van de list met ints: {0}", list1.ToString());

            LinkedListGeneric<string> list2 = new LinkedListGeneric<string>();
            list2.Insert("abc");
            list2.Insert("def");
            list2.Insert("ghi");
            Console.WriteLine("Inhoud van de list met strings: {0}", list2.ToString());

            LinkedListGeneric<LinkedListGeneric<int>> list3 = 
                new LinkedListGeneric<LinkedListGeneric<int>>();
            for(int i = 0; i < 3; i++)
            {
                LinkedListGeneric<int> tmp = new LinkedListGeneric<int>();
                tmp.Insert(i * 10 + 0);
                tmp.Insert(i * 10 + 1);
                tmp.Insert(i * 10 + 2);
                list3.Insert(tmp);
            }
            Console.WriteLine("Inhoud van de list met list met ints: {0}", list3.ToString());

            Console.WriteLine("Druk Enter om door te gaan");
            string input = Console.ReadLine();
        }
    }
}
