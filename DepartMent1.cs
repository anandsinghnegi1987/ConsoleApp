using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class DepartMent1
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public static List<DepartMent1> GetAllDepartment()
        {
            List<DepartMent1> D = new List<DepartMent1>();

            D.Add(new DepartMent1 { ID=1,Name="IT"});
            D.Add(new DepartMent1 { ID = 2, Name = "HR" });

            return D;
        }
    }
}
