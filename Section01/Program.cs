using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {

            /*var names = new List<string> {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra", "Hong Kong",
            };

            IEnumerable<string> query = names.Where(s => s.Length <= 5).Select(s => s.ToLower());
            foreach (string s in query) {
                Console.WriteLine(s);
            }*/


            /*string[] names = {
                "Tokyo", "New Delhi", "Bangkok", "London", "Paris", "Berlin", "Canberra"  };
            var query = names.Where(s => s.Length <= 5).ToList();

            query.ForEach(Console.WriteLine);

            foreach (var item in query)
                Console.WriteLine(item);
            Console.WriteLine("------");

            names[0] = "Osaka";
            foreach (var item in query)
                Console.WriteLine(item);*/


            var numbers = new List<int> { 12, 87, 94, 14, 53, 20, 40, 35, 76, 91, 31, 17, 48 };

            // 3.1.1
            Exercise1_1(numbers);
            Console.WriteLine("-----");

            // 3.1.2
            Exercise1_2(numbers);
            Console.WriteLine("-----");

            // 3.1.3
            Exercise1_3(numbers);
            Console.WriteLine("-----");

            // 3.1.4
            Exercise1_4(numbers);

        }




        private static void Exercise1_1(List<int> numbers) {
            var exist = numbers.Exists(n => n % 8 == 0 || n % 9 == 0);//整数はなるべくnを使おう。sはStringで使う。

            if (exist) {
                Console.WriteLine("存在しています");
            } else {
                Console.WriteLine("存在していません");
            }
                
        }

        private static void Exercise1_2(List<int> numbers) {
            numbers.ForEach(n => Console.WriteLine(n / 2));
        }

        private static void Exercise1_3(List<int> numbers) {
            throw new NotImplementedException();
        }

        private static void Exercise1_4(List<int> numbers) {

        }
    }
}
