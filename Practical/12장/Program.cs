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
           using (var reader = XmlReader.Create("novel.xml"))
            {
                var serializer = new DataContractSerializer(typeof(Novel));
                var novel = serializer.ReadObject(reader) as Novel;
                Console.WriteLine(novel);
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
