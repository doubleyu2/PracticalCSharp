﻿using System;
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


            }
        }
    }
}
