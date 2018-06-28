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

            using (var stream = new FileStream("novelist.json", FileMode.Create, FileAccess.Write))
            using (var writer = new StreamWriter(stream, Encoding.UTF8))
            using (var ms = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(novelist.GetType());
                serializer.WriteObject(ms, novelist);
                var jsontext = Encoding.UTF8.GetString(ms.ToArray());
                writer.Write(jsontext);
            }
            
            
        }
    }

    [DataContract(Name ="novelist")]
    public class Novelist
    {
        [DataMember(Name = "name")]
        public string Name { get; set; }
        [DataMember(Name = "birth")]
        public DateTime Birth { get; set; }
        [DataMember(Name = "masterpieces")]
        [XmlArray("masterpieces")]
        [XmlArrayItem("title",typeof(string))]
        public string[] MasterPieces { get; set; }

    }
}
