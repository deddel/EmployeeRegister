using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    //Class of employers with the attributes Name and Wage.
    internal class Employee
    {
        public string Name {  get; set; }
        public double Wage { get; set; }

        //Constructor
        public Employee(string name, double salary) 
        {
            this.Name = name;
            this.Wage = salary;
        }
    }
}
