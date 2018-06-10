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
            var xdoc = XDocument.Load("novelists.xml");
            var xnovelists = xdoc.Root.Elements()
                                      .Where(x => ((DateTime)x.Element("birth")).Year >= 1900);

            foreach (var xnovelist in xnovelists)
            {
                var xname = xnovelist.Element("name");
                var birth = (DateTime)xnovelist.Element("birth");
                Console.WriteLine($"Name:{xname.Value},Birthdate:{birth.ToShortDateString()}");

            }
        }
    }
}
