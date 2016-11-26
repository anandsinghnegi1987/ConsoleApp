using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class Employee1
    {
        public int EmpID { get; set; }
        public string Name { get; set; }
        public int DepID { get; set; }
        public string Mob {get;set;}

        public static List<Employee1> getAllEmployee()
        {
            List<Employee1> E = new List<Employee1>();
            E.Add(new Employee1 { EmpID = 1, Name = "Manish", DepID = 1 });
            E.Add(new Employee1 { EmpID = 2, Name = "Rajesh", DepID = 2 });
            E.Add(new Employee1 { EmpID = 3, Name = "Sonu", DepID = 2 });
            E.Add(new Employee1 { EmpID = 3, Name = "Ashu" });
            return E;
        }

    }
}
