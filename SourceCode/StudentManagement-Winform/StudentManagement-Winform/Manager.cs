using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Winform
{
    internal class Manager: Staff
    {

        public double Bonus = 1000;

        public  double GetSalary()
        {
            return Bonus + this.Salary;
        }
       

    }

}
