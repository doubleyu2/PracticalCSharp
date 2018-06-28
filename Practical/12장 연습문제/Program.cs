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
            var emps = new Employee[] {
                new Employee {
                    Id = 12341,
                    Name = "홍길순",
                    HireDate = new DateTime(2017, 06, 01),
                },
                new Employee
                {
                    Id = 12342,
                    Name = "김철수",
                    HireDate = new DateTime(2016,12,01),
                },
            };

            using (var writer = XmlWriter.Create("emp2.xml"))
            {
                var serializer = new DataContractSerializer(emps.GetType());
                serializer.WriteObject(writer, emps);
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
