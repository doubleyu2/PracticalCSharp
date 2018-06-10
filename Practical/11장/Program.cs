using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _11장
{
    
    public class Novelist
    {
        public string Name { get; set; }
        public string EngName { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Death { get; set; }
        public IEnumerable<string> Masterpieces { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var novelists = new List<Novelist>
            {
                new Novelist
                {
                    Name = "마크 트웨인",
                    EngName = "Mark Twain",
                    Birth = DateTime.Parse("1835-11-30"),
                    Death = DateTime.Parse("1910-03-21"),
                    Masterpieces = new string[]{"톰 소여의 모험","허클베리 핀의 모험"},

                },

                new Novelist
                {
                    Name = "어니스트 헤밍웨이",
                    EngName = "Ernest Hemingway",
                    Birth = DateTime.Parse("1899-07-21"),
                    Death = DateTime.Parse("1961-07-02"),
                    Masterpieces = new string[]{"무기여 잘있거라","노인과 바다",},
                },
            };

            var elements = novelists.Select(x =>
                                            new XElement("novelist",
                                                new XElement("name", x.Name, new XAttribute("eng", x.EngName)),
                                                new XElement("birth", x.Birth),
                                                new XElement("death", x.Death),
                                                new XElement("masterpieces", x.Masterpieces.Select(t => new XElement("title", t)))
                                            ));
            var root = new XElement("novelists", elements);
            var xdoc = new XDocument(root);

            var element = new XElement("novelist",
                                new XElement("name", "찰스 디킨스", new XAttribute("eng", "Charles Dickens")),
                                new XElement("birth", "1812-02-07"),
                                new XElement("death", "1870-06-09"),
                                new XElement("masterpieces",
                                    new XElement("title", "올리버 트위스트"),
                                    new XElement("title", "크리스마스 캐럴")));

            xdoc.Root.Add(element);
            
            foreach (var item in xdoc.Root.Elements())
            {
                Console.WriteLine(item.Element("name").Value);
            }

            string elmstring =
                @"<novelist>
                    <name eng=""Mark Twain""> 마크 트웨인 </name> 
                    <birth> 1835-11-30</birth> 
                    <death> 1910-03-21</death>
                    <masterpieces>
                    <title> 도금시대</title> 
                    <title> 아서 왕 궁정의 코네티컷 양키 </title> 
                    </masterpieces> 
                 </novelist>";
            var newElement = XElement.Parse(elmstring);

            element.ReplaceWith(newElement);


            Console.WriteLine();

            foreach (var item in xdoc.Root.Elements())
            {
                Console.WriteLine(item.Element("name").Value);
            }
        }       

    }

   
}
