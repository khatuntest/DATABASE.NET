using Level2_S3.Classes;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace Level2_S3
{
    internal class Program{
        static void Main(string[] args)
        {

            List<Employee> employees = Repository.GetEmployees();

            #region Part1 : Custom Delegate
            /*
             1.Create a delegate named MyDelegate1 that takes an Employee and returns a bool.
             2.Write a method PerAge(Employee e) in the Filtration class that returns true if the employee's age is above 30.
            3. Use MyDelegate1 to point to PerAge and filter the employee list using Filtration.Filter
            */

            //MyDelegate1 filterAgeDel = Filtration.PerAge;
            //List<Employee> FilteredList = Filtration.Filter(employees, filterAgeDel);
            //foreach (Employee employee in FilteredList)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion

            #region Part2 : Anonymous Methods
            /*
                 1.Declare an anonymous method that filters employees whose names contain the  letter "a".
                 2.Use this method with your delegate to filter and display the employees.
            */

            //MyDelegate1 FilterByNameContainA = delegate (Employee employee)
            //{
            //    return employee.Name != null && employee.Name.ToLower().Contains('a');
            //};

            //List<Employee> filterList = Filtration.Filter(employees, FilterByNameContainA);
            //foreach (Employee employee in filterList)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion

            #region Part3 : Lambda Expressions
            /*
                1.Write a lambda expression that filters employees with a salary greater than 8000.
                2.Use this expression with your delegate to filter and display the employees.
            */

            //MyDelegate1 filterBySalary = (Employee e) => e.Salary > 8000;
            //List<Employee> filteredList = Filtration.Filter(employees, filterBySalary);
            //foreach (Employee employee in filteredList)
            //{
            //    Console.WriteLine(employee);
            //}

            #endregion

            #region Part4 : Built-In Delegates
            /*
                 1.Use a Predicate<Employee> to filter employees who belong to Department ID 20.
                 2.Use an Action<Employee> to print employee details.
                 3.Use a Func<Employee, bool> to filter employees who are older than 35
            */

            //Predicate<Employee> FilterByDpID = (Employee e) => e.DeptId == 20;
            //Action<Employee> Print = (Employee e) => Console.WriteLine(e);
            //Func<Employee, bool> EmployeeOlder35 = (Employee e) => e.Age > 35;

            //Console.WriteLine("The Employees in Department 20");
            //List<Employee> FilterByDp20 = employees.FindAll(FilterByDpID);
            //FilterByDp20.ForEach(Print);

            //Console.WriteLine("\n\nThe Employees Older Than 35");
            //List<Employee> FilterByOlder35 = employees.Where(EmployeeOlder35).ToList();
            //FilterByOlder35.ForEach(Print);

            #endregion

            #region Part5 : Generic Method (Bonus)
            /*
                1.Create a generic filtration method using a Func< Employee, bool> as a parameter.
                2.Reuse this method for different filtration scenarios instead of repeating code.
            */

            //Console.WriteLine("The Employees in Department 10 \n");
            //List<Employee> FilterByDP10 = Filtration.GenericFilter(employees, e => e.DeptId == 10);
            //foreach (Employee employee in FilterByDP10)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine("\n\nThe Employees older than 20 \n");
            //List<Employee> FilterByAge = Filtration.GenericFilter(employees, e => e.Age >20 && e.Age < 30);
            //foreach (Employee employee in FilterByAge)
            //{
            //    Console.WriteLine(employee);
            //}

            //Console.WriteLine("\n\nThe Employees Names length Greater than 4 \n");
            //List<Employee> FilterByNameLength = Filtration.GenericFilter(employees, e => e.Name.Length > 4);
            //foreach (Employee employee in FilterByNameLength)
            //{
            //    Console.WriteLine(employee);
            //}
            //Console.WriteLine("\n\n");
            #endregion

        }
    }
}
