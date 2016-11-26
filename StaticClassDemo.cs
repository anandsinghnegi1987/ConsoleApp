using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public static class StaticClassDemo
    {
        public static int wordcount(this string str)
        {
            string[] k = str.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries);
            int count = k.Length;
            return count;
        }

        public static string Reverse(string A)
        {
            string B = A.ToString();
            string H = string.Empty;

            for (int k = B.Length - 1; k >= 0; k--)
            {
                H = H + "" + B[k];
            }

            char[] g = H.ToCharArray();
            if (g.Length > 0)
            {
                //g[0] = char.IsLower(g[0]);
                g[0] = //char.IsUpper(g[0]) ? 
                       //char.ToLower(g[0]) : 
                    char.ToUpper(g[0]);
            }
            return new string(g);

            H = new string(g);
        }
        private static void NewMethod()
        {
            var k = "Anand Singh negi";
            int j = k.Length;


            dynamic p = "Anand singh negi";
            int h = p.Length;
        }


        public static void DuplicateArray(int input1, int[] input2)
        {

            int[] A = { 1, 2, 3, 5, 5, 8, 7, 1, 1, 1, 2 };
            DuplicateArray(2, A);
        }
    }
    public static class StringHelper
    {
        public static string Convertstring(this string input)
        {
            if (input.Length > 0)
            {
                char[] A = input.ToCharArray();
                A[0] = char.IsUpper(A[0]) ? char.ToLower(A[0]) : char.ToUpper(A[0]);
                return new string(A);
            }
            return "";
        }

    }
    public static class Test
    {
        public static string Name { get; set; }
        public static string MobNo { get; set; }
    }
}
