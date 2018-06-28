using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _12장
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person { Id = 1, Name = "홍길동" };

            var pList = new List<Person>
            {
                p,
                new Person { Id = 2, Name = "김삿갓" }
            };


            string json = JsonConvert.SerializeObject(pList);
            Console.WriteLine(json);


            var dpList = JsonConvert.DeserializeObject<List<Person>>(json);

            dpList.ForEach(a => Console.WriteLine(a.Name));
      
        
        }
    }
    
    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }


    }
}
