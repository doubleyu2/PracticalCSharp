using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;

namespace _12장
{
    class Program
    {
        static void Main(string[] args)
        {
            using (XmlReader reader = XmlReader.Create("novels.xml")){
                var serializer = new DataContractSerializer(typeof(Novel[]));
                var novels = serializer.ReadObject(reader) as Novel[];
                foreach (var novel in novels)
                {
                    Console.WriteLine(novel);
                }
            }
        
        }
    }

    public class Novel
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Published { get; set; }
        public override string ToString()
        {
            return string.Format($"Title: {Title}, Author: {Author}, Published: {Published}");
        }
    }
}
