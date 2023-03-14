using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement_Winform
{
    internal class Staff
    {

        public string Name { get; set; }
        public string Address { get; set; }

        public string Phone { get; set; }   

        public int Age { get; set; }

        public string PersonalID { get; set; }

        public double Salary { get; set; }  


        public double GetSalary()
        {
            return Salary;
        }




        public Staff() { }


        public Staff(string Name, string Address, string Phone, 
            int Age, string PersonalID, double Salary)
        {
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Age = Age;
            this.Salary = Salary;
            this.PersonalID = PersonalID;

        }


    }
}
