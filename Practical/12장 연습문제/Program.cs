using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace _12장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee
                {
                    Id = 12341,
                    Name = "김하나",
                    HireDate = new DateTime(2018,01,03),
                },
                new Employee
                {
                    Id = 12346,
                    Name = "차두리",
                    HireDate = new DateTime(2008,01,04),
                },
            };


            using (var stream = new FileStream("employees.json", FileMode.Create, FileAccess.Write))
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            using (var ms = new MemoryStream())
            { 
                var serializer = new DataContractJsonSerializer(emps.GetType());

                serializer.WriteObject(ms, emps);
                var jsonText = Encoding.UTF8.GetString(ms.ToArray());
                writer.Write(jsonText);
                
            }
            
        }
    }

    [DataContract(Name = "employee")]
    public class Employee
    {
        // 빠진 부분
        public int Id { get; set; }
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "hiredate")]
        public DateTime HireDate { get; set; }
  
    }
}
