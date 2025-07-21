﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2_S3.Classes
{
    public static class Repository
    {
        public static List<Employee> GetEmployees()
        {
            return new List<Employee>
            {
                new Employee{Id = 1, Name = "Ali", Age = 31, Salary = 10234, DeptId = 10 },
                new Employee{Id = 2, Name = "Mohamed", Age = 30, Salary = 2234, DeptId = 20 },
                new Employee{Id = 3, Name = "Osama", Age = 29, Salary = 3234, DeptId = 30 },
                new Employee{Id = 4, Name = "Sara", Age = 28, Salary = 4234, DeptId = 10 },
                new Employee{Id = 5, Name = "Rahma", Age = 27, Salary = 5234, DeptId = 10 },
                new Employee{Id = 6, Name = "Eman", Age = 26, Salary = 6234, DeptId = 10 },
                new Employee{Id = 7, Name = "Ibrahim", Age = 25, Salary = 7234, DeptId = 20 },
                new Employee{Id = 8, Name = "Moustafa", Age = 24, Salary = 8234, DeptId = 20 },
                new Employee{Id = 9, Name = "Emad", Age = 23, Salary = 9234, DeptId = 10},
                new Employee{Id = 10, Name = "Salma", Age = 22, Salary = 1234, DeptId = 30 }
            };
        }
      
    }

}
