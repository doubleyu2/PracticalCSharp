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
            var xelements = xdoc.Root.Elements();
            foreach (var xnovelist in xelements)
            {
                XElement xname = xnovelist.Element("name");
                Console.WriteLine(xname.Value);
            }
        }
    }
}
