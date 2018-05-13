using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6장
{



    class Program
    {
        static void Main(string[] args)
        {
            var books = new List<Book> {
               new Book { Title = "C# 프로그래밍의 상식", Price = 38000, Pages = 378 },
               new Book { Title = "람다식과 LINQ의 비밀", Price = 25000, Pages = 312 },
               new Book { Title = "원더풀 C# 라이프", Price = 29000, Pages = 385 },
               new Book { Title = "독학 병렬처리 프로그래밍", Price = 48000, Pages = 464 },
               new Book { Title = "구문으로 배우는 C# 입문", Price = 53000, Pages = 604 },
               new Book { Title = "나도 할 수 있는 ASP.NET MVC", Price = 32000, Pages = 453 },
               new Book { Title = "재미있는 C# 프로그래밍 교실", Price = 25400, Pages = 348 },
            };

            var temp = books.FirstOrDefault(book => book.Title == "원더풀 C# 라이프");

            Console.WriteLine($"Title: {temp.Title}, Price: {temp.Price}, Pages: {temp.Pages}");

            var temp2 = books.Count(book => book.Title.Contains("C#"));

            var temp3 = books.Where(s => s.Title.Contains("C#")).Average(book => book.Pages);

            var temp4 = books.FirstOrDefault(book => book.Price >= 40000);

            var temp5 = books.Where(book => book.Price < 40000).Max(book => book.Pages);

            var temp6 = books.Where(book => book.Pages >= 400).OrderByDescending(book => book.Price).ToList();

            var temp7 = books.Where(book => book.Pages <= 500 && book.Title.Contains("C#")).ToList();


            Console.WriteLine();
            Console.WriteLine(temp2);

            Console.WriteLine();
            Console.WriteLine(temp3);

            Console.WriteLine();
            Console.WriteLine(temp4.Title);

            Console.WriteLine();
            Console.WriteLine(temp5);

            Console.WriteLine();
            temp6.ForEach(book => Console.WriteLine($"{book.Title}, {book.Price}"));

            Console.WriteLine();
            temp7.ForEach(book => Console.WriteLine(book.Title));




        }
    }

    class Book
    {
        public String Title { get; set; }
        public int Price { get; set; }
        public int Pages { get; set; }
    }

  


}
