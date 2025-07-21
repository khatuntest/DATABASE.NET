using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level2_S3.Classes
{
    internal static class Filtration
    {
        public static bool PerAge(Employee e)
        {
            return e.Age > 30;
        }
       
        public static List<Employee> Filter(List<Employee> employees , MyDelegate1 del)
        {
            List<Employee> result = new List<Employee>();
            foreach(Employee e in employees)
            {
                if (del(e))
                {
                    result.Add(e);
                }
            }
            return result;
        }

        public static List<Employee> GenericFilter(List<Employee> employees, Func<Employee , bool> del)
        {
            List<Employee> result = new List<Employee>();
            foreach (Employee e in employees)
            {
                if (del(e))
                {
                    result.Add(e);
                }
            }
            return result;
        }
    }
}
