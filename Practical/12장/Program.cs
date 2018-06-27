using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace _12장
{
    class Program
    {
        static void Main(string[] args)
        {
            var novel = new Novel
            {
                Author = "제임스 P. 호건",
                Title = "별의 계승자",
                Published = 1977,
            };

            var sb = new StringBuilder();
            using (var writer = XmlWriter.Create(sb))
            {
                var serializer = new XmlSerializer(novel.GetType());
                serializer.Serialize(writer, novel);
            }

            var xmlText = sb.ToString();
            Console.WriteLine(xmlText);
            using (var reader = XmlReader.Create(new StringReader(xmlText)))
            {
                var serializer = new XmlSerializer(typeof(Novel));
                var novel2 = serializer.Deserialize(reader) as Novel;
                Console.WriteLine(novel2);
            }


        
        }
    }

    [XmlRoot("novel")]
    public class Novel
    {
        [XmlElement(ElementName ="title")]
        public string Title { get; set; }
        [XmlElement(ElementName ="author")]
        public string Author { get; set; }
        [XmlElement(ElementName ="published")]
        public int Published { get; set; }
        public override string ToString()
        {
            return string.Format($"Title: {Title}, Author: {Author}, Published: {Published}");
        }
    }
}
