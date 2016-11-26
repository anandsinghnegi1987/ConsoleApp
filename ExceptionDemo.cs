using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class ExceptionDemo
    {
        protected int id;
        List<string> ow = new List<string>();
        public ExceptionDemo(string str)
        {
            throw new Exception(str);
        }
        public void Divide(int a, int b)
        {

            try
            {
                Console.WriteLine(a / b);
                return;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
                Console.ReadLine();
            }
            finally
            {
                Console.WriteLine("Finish");
                Console.ReadLine();
            }
        }

        
    }

    
}
