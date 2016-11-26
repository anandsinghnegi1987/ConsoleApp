using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    class Misc
    {
        public static bool ISPali(string Name)
        {
            char[] A = Name.ToCharArray();
            int L = Name.Length;
            string Rev = string.Empty;

            for (int i = L - 1; i >= 0; i--)
            {
                Rev = Rev + A[i].ToString();
            }

            if (string.Equals(Name, Rev, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Numbers(int Fn, int Sn, out int Sum, out int Product)
        {
            Sum = Fn + Sn;
            Product = Fn * Sn;
        }

        public static int A(int[] B)
        {
            ArrayList ar = new ArrayList();
            foreach (int p in B)
            {
                ar.Add(p);
            }
            return (int)ar[ar.Count - 1];
        }
    }
}
