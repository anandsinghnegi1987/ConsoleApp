using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTesting
{
    public class Employee 
    {
        #region Fields
        public int ID;
        public string name;
        

        
        #endregion
    }

    public abstract class department
    {
        public abstract void print1();
        public abstract void print2();
    }
    public interface Student : I1
    {
        void print();
        int print2();
    }

    public interface I1
    {

    }
}
