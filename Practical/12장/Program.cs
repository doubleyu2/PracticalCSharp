using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace _12장
{
    class Program
    {
        static void Main(string[] args)
        {
            var novel = new Novel
            {
                Author = "로버트 A. 하인리히",
                Title = "여름으로 가는 길",
                Published = 1956,
            };

            using (var st = new FileStream("sample.json", FileMode.Create, FileAccess.Write))
            using (var stream = new StreamWriter(st, Encoding.UTF8))
            using (var writer = new JsonTextWriter(stream))
            {
                JsonSerializer serializer = new JsonSerializer
                {
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver(),
                };
                serializer.Serialize(writer, novel);
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
