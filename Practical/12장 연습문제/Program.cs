using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace _12장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new Employee
            {
                Id = 1234,
                Name = "홍길동",
                HireDate = new DateTime(2018, 01, 02),
            };

            using (var emp = XmlWriter.Create("employees.xml"))
            {
                var serializer = new XmlSerializer(employees.GetType());
                serializer.Serialize(emp, employees);
            }
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime HireDate { get; set; }
  
    }
}
