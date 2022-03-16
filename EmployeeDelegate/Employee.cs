using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDelegate
{ 
    //delegate bool PromotDelegate(Employee emp);
    
    internal class Employee
    {
        //public static List<Employee> employees1 = new List<Employee>();

        public int ID { get; set; }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }

        //public Employee(int id, string name, int experience, int salary)
        //{
        //    this.ID = id;
        //    this.Name = name;
        //    this.Experience = experience;
        //    this.Salary = salary;
        //}

       

        public void PrintPromotedEmployee(List<Employee> employees, Func<Employee, bool> promoted)
        {
            
            foreach (var employee in employees)
            {
                if(promoted(employee))
                {
                    Console.WriteLine(employee.Name);
                }
                
            }
        }


    }
}
