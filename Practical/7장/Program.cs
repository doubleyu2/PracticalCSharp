using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7장
{

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> flowerDict = new Dictionary<string, int>
            {
                ["sunflower"] = 400,
                ["pansy"] = 300
            };


            var employees = new List<Employee>()
            {
                new Employee() { Code = 100, Name = "이몽룡" },
                new Employee() { Code = 112, Name = "변학도" },
                new Employee() { Code = 125, Name = "성춘향" },


            };

            var employeeDict = employees.ToDictionary(e => e.Code, e => e.Name);

            foreach (var item in employeeDict)
            {
                Console.WriteLine($"{item.Key}, {item.Value}");
            }

        }
    }

    class Employee
    {
        public int Code { get; set; }
        public string Name { get; set; }
    }
}
