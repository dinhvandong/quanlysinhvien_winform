using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Winform
{
    internal class Sale: Staff
    {

        public int Percentage { get; set; }


        public double GetSalary()
        {
            return Percentage * 1000000 + this.Salary;
        }
        
    }
}
