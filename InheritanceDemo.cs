using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class Baseclass
    {
        const int value = 0;
        readonly int d = 5;
        public string ID { get; set; }
        public int Name { get; set; }
        static Baseclass()
        {
            //value = 1;

            Console.WriteLine();
        }
        public Baseclass()
        {
            d = 56;
        }
    }

    public class childClass : Baseclass
    {
        //childClass ob = (childClass)new Baseclass();
    }
}
