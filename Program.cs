using System;
using System.Text;
using static System.Math;
using System.Collections.Generic;
using System.Collections;
using ConsoleTesting;
using System.Linq;

namespace ConsoleTestin
{
    public class A
    {
        public void print()
        {
            Console.WriteLine("parent Class");
            Console.ReadLine();
        }

        public int Add(int a,int b)
        {
            return a + b;
        }
        public string Add(int a, int b,int c=0)
        {
            return (a + b).ToString();
        }
    }
    public class B:A
    {
        public new void print()
        {
            Console.WriteLine("Child Class");
            //base.print();
            Console.ReadLine();
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
           

            A ob1 = new A();
            ob1.print();

          //  ob1.Add(2, 3);

            B ob2 = new B();
            ob2.print();
            A ob3 = new B();
            ob3.print();
            //B ob4 = new A();
            

            //var k = (from m in Employee1.getAllEmployee()
            //         join v in DepartMent1.GetAllDepartment()
            //         on m.DepID equals v.ID into e
            //         from v in e.DefaultIfEmpty()
            //         select new
            //         {
            //             Ename=m.Name,
            //             DepaName=v==null?"No Dep": v.Name
            //         });

            //var k = Employee1.getAllEmployee()
            //    .GroupJoin(DepartMent1.GetAllDepartment(),
            //               e => e.DepID,
            //               d => d.ID,
            //               (emp, dept) => new { emp, dept })
            //               .SelectMany(x => x.dept.DefaultIfEmpty(),
            //               (a, b) => new
            //               {EmployeeName=a.emp.Name,
            //               Dep=b==null?"no Dep":b.Name});

            //foreach(var k1 in k)
            //{
            //    Console.WriteLine(k1.EmployeeName + "-" + k1.Dep + "/n");
            //    Console.ReadLine();
            //}

        }
        public void Method1()
        {
            string name = "sandeep";
            string myName = "Sandeep";
            Console.WriteLine("== operator result is {0}", name == myName);
            Console.WriteLine("Equals method result is {0}", name.Equals(myName));
            Console.ReadKey();
        }
        public static void exception()
        {
            throw new Exception("Exception thrown");
        }
        public static bool Palidrome(string input)
        {
            char[] A = input.ToCharArray();
            string B = string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                B = B + A[i].ToString();
            }

            if (string.Equals(B, input, StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }

}
