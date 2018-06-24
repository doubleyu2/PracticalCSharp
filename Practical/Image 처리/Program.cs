using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Google.Cloud.Vision.V1;
namespace Image_처리
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", @"prj.json");
            string value = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");

            var client = ImageAnnotatorClient.Create();

            var image = Image.FromFile(@"ho.jpg");

            var response = client.DetectWebInformation(image);

            foreach (var item in response.WebEntities)
            {
                if (item.Description != null)
                {
                    Console.WriteLine(item.Description);
                }
            }

        }
    }
}
