using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Coelesce
    {
        private void Colessce()
        {
            int? tickets = 50;
            //Null Coelescing......
            int Ava = tickets ?? 0;

            Console.WriteLine("Avail is {0}", Ava);
            Console.ReadLine();
        }
    }
}
