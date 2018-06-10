using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _11장
{
    class Program
    {
        static void Main(string[] args)
        {

            var novelists = ReadNovelists();

            foreach (var novelist in novelists)
            {
                Console.WriteLine($"Name: {novelist.Name}, Birth: {novelist.Birth.Year}, Death: {novelist.Death.Year}, {string.Join("-, ", novelist.Masterpieces)}");
            }                
        
        }

        static IEnumerable<Novelist> ReadNovelists()
        {
            var xdoc = XDocument.Load("novelists.xml");
            var novelists = xdoc.Root.Elements()
                                     .Select(x => new Novelist
                                     {
                                         Name = (string)x.Element("name"),
                                         EngName = (string)(x.Element("name").Attribute("eng")),
                                         Birth = (DateTime)x.Element("birth"),
                                         Death = (DateTime)x.Element("death"),
                                         Masterpieces = x.Element("masterpieces")
                                                        .Elements("title")
                                                        .Select(title => title.Value)
                                                        .ToArray()
                                     });
            return novelists.ToArray();
        }

    }


    class Novelist
    {
        public string Name { get; set; }
        public string EngName { get; set; }
        public DateTime Birth { get; set; }
        public DateTime Death { get; set; }
        public IEnumerable<string> Masterpieces { get; set; }


    }

  
}
