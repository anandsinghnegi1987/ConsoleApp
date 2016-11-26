using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class AVB
    {
        static AVB()
        {
            Console.WriteLine("Static Constructor!");
            Console.ReadLine();
        }
    }
    public class Demo
    {
        int k = 5;
        static Demo()
        {
            Console.WriteLine("Static Constructor!");
            Console.ReadLine();
        }

        public Demo(int p)
        {
            this.k = p;
            Console.WriteLine(this.k);
            Console.ReadLine();
        }
    }
}
