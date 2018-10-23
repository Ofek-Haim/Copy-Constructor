using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("p1", 10);
            Person p2 = new Person(p1);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            p2.GASAge = 10.1;
            p2.GASName = "p2";
            Console.WriteLine(p1);
            Console.WriteLine(p2);
        }
    }
}
