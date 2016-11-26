using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate int HelloDelegate(int a, int b);
public delegate void Hello(int h, int k);

namespace ConsoleTesting
{
    class DelaegateDemo
    {
        
        public virtual string Name
        {
            get; set;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Mul(int a, int b)
        {
            return a * b;
        }

        public void Sub(int a, int b)
        {
            Console.WriteLine("OutPut :" + (a - b));
        }
        public void pro(int a, int b)
        {
            Console.WriteLine("OutPut :" + (a * b));
        }

        private void Abv()
        {
            pro(1, 2);
        }
    }
}
