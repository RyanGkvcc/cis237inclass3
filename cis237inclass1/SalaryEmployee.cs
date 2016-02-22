using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    //Use the : to denote that this class should inherit from the class listed after the :
    public class SalaryEmployee : Employee
    {
        //Add backing field for the salary
        private decimal salary;

        //Add property for the salary
        public decimal Salary
        {
            get
            {
                return this.salary;
            }
        }

        /// <summary>
        /// 3 Parameter constructor that takes the following arguments
        /// </summary>
        /// <param name="firstName">First Name of Employee</param>
        /// <param name="lastName">Last Name of Employee</param>
        /// <param name="salary">Yearly Salary the Employee Earns</param>
        public SalaryEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName)
        {
            //Assign the passed in salary to the class level one. The first and last names that
            //were passed in are assigned by calling the parent's constructor.
            //The parent's constructor was called by the : base(firstName, lastName) that follows
            //the constructor declaration.
            this.salary = salary;
        }

        /// <summary>
        /// Print out the information of the class in a readable format
        /// </summary>
        /// <returns>String consisting of forstname, last name, and salary</returns>
        public override string ToString()
        {
            //base.ToString() calls the TOString method of the parent class.
            //We can get a full string of all properties by concating the parent's toString
            //with the salary of this class. We leave the work of creating the parent's information
            //to the parent class.
            return base.ToString() + " " + this.Salary.ToString("C");
        }

        //This is the override for the abstract method we hace declares in the
        //employee class. We are required to provide an implementation since it
        //was declared abstract in Employee.
        public override string getFormattedSalary()
        {
            return this.Salary.ToString("C");
        }
    }
}
