using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1 {
    class Program {
        static void Main(string[] args) {
            //5-1
            Console.Write("一つ目の文字列を入力");
            var s1 = Console.ReadLine();
            Console.Write("二つ目の文字列を入力");
            var s2 = Console.ReadLine();
            if (String.Compare(s1, s2, ignoreCase : true) == 0) {
                Console.WriteLine("等しい");
            } else { 
                Console.WriteLine("等しくない");
            }

            //5-2


            //5-3

        }
    }
}
