using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _11장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            var xdoc = XDocument.Load("sample.xml");
            var xelements = xdoc.Root.Elements();

            //           var x = new { name = "홍", age = 30 };


            {
                var list = xelements.Select(x => new { Name = x.Element("name").Value, Count = x.Element("teammembers").Value });

                foreach (var item in list)
                {
                    Console.WriteLine($"{item.Name} - {item.Count}");
                }
            }
            {
                var year = xelements.Select(x => new { Name = x.Element("name").Value, Firstplayed = x.Element("firstplayed").Value })
                                    .OrderBy(a => int.Parse(a.Firstplayed));
                foreach (var item in year)
                {
                    Console.WriteLine();
                    Console.WriteLine($"{item.Name}:{item.Firstplayed}");
                }

            }

            {
                var members = xelements.Select(x => new { Name = x.Element("name").Value, members = x.Element("teammembers").Value })
                                       .OrderByDescending(a => int.Parse(a.members)).First();
                Console.WriteLine();
                Console.WriteLine(members.Name);
            }
        }
    }
}
