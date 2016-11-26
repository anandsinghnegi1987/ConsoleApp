using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class PClas
    {
        public virtual void Print()
        {
            Console.WriteLine("Base Class!");
        }
    }

    public class CClas : PClas
    {

        public override void Print()
        {
            Console.WriteLine("Derived Class!");
        }
    }
}
