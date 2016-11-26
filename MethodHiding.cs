using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class Parent
    {
        public void Print()
        {
            Console.WriteLine("I am Base Class!");
            Console.ReadLine();
        }
    }
    public class Child : Parent
    {
        public new void Print()
        {
            Console.WriteLine("I am Child Class!");
            Console.ReadLine();
        }
    }
}
