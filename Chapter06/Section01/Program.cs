using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            var books = Books.GetBooks();

            Console.WriteLine("本の平均価格は" + books.Average(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("本の総ページ数は" + books.Sum(x => x.Pages).ToString("#,0") + "ページ");
            Console.WriteLine("一番高い本は" + books.Max(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("一番安い本は" + books.Min(x => x.Price).ToString("#,0") + "円");
            Console.WriteLine("500円以上のほんの冊数は" + books.Count(x => x.Price>=500)+ "冊");
            Console.WriteLine("物語がふくまれている本は" + books.Count(x => x.Title.Contains("物語")) + "です");
            var bookData = books.Where(x => x.Title.Contains("物語")).Take(2);
            foreach(var book in bookData) {
                Console.WriteLine(book.Title);
            }
            var output = books.OrderByDescending(x => x.Price).Take(3);
            foreach(var item in output) {
                Console.WriteLine(item.Title + " " + item.Price);
            }

            var titles = books.Select(x => x.Title);
            foreach(var item in titles) {
                Console.WriteLine(item);
            }
        }
    }
}
