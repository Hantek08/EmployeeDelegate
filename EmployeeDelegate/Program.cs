// See https://aka.ms/new-console-template for more information
using EmployeeDelegate;

internal class Program
{
    
    static void Main(string[] args)
    {
        //create some employee and store in a List
       List<Employee> employeesList = new List<Employee>() {
        new Employee(){ ID = 1, Name = "Emp1", Experience = 5 ,Salary = 35000},
        new Employee(){ ID = 2, Name = "Emp2", Experience = 10, Salary = 40000},
        new Employee() { ID = 3, Name = "Emp3", Experience = 2, Salary = 25000},
        new Employee(){ ID = 4, Name = "Emp4", Experience = 6, Salary = 27000}
        };

     Employee employee = new Employee();
        
        employee.PrintPromotedEmployee(employeesList, Promot);

    }
    public static bool Promot(Employee emp)
    {
          if(emp.Experience > 5)
            {
                return true;
            }
               
              return false; 
    }
}