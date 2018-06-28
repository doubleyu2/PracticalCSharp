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

            using (var reader = XmlReader.Create("emp2.xml"))
            {
                var serializer = new DataContractSerializer(typeof(Employee[]));
                var emps = serializer.ReadObject(reader) as Employee[];
                foreach (var item in emps)
                {
                    Console.WriteLine($"{item.Id}-{item.Name}-{item.HireDate}");
                }
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
