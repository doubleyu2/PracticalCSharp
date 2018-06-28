using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace _12장_연습문제
{
    class Program
    {
        static void Main(string[] args)
        {
            var novelist = new Novelist
            {
                Name = "아서 C 클라크",
                Birth = new DateTime(1917, 12, 16),
                MasterPieces = new string[] { "2001 스페이스 오디세이", "유년기의 끝" },
            };

            using (var writer = XmlWriter.Create("novelist.xml"))
            {
                var serializer = new XmlSerializer(novelist.GetType());
                serializer.Serialize(writer, novelist);
            }
            
        }
    }

    public class Novelist
    {
        public string Name { get; set; }
        public DateTime Birth { get; set; }
        [XmlArray("masterpieces")]
        [XmlArrayItem("title",typeof(string))]
        public string[] MasterPieces { get; set; }

    }
}
