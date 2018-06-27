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
            var novels = new Novel[]
               {
                    new Novel
                    {
                        Author = "제임스 P. 호건",
                        Title = "별의 계승자",
                        Published = 1977,
                    },
                    new Novel
                    {
                        Author = "허버트 조지 웰즈",
                        Title = "타임머신",
                        Published = 1895,
                    },
               };
            using (var writer = XmlWriter.Create("novels.xml"))
            {
                var serializer = new DataContractSerializer(novels.GetType());
                serializer.WriteObject(writer, novels);
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
