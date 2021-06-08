using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section01 {
    class Program {
        static void Main(string[] args) {
            //P125
            int count = 0;

            Console.WriteLine($"後置：{count++}");

            Console.WriteLine($"前置：{++count}");


            //var ret = GetProductA();

            //P116
            /* string code = "12345";
             //null合体演算子
             var message = GetMessage(code) ?? DefaultMessage();
             Console.WriteLine(message);*/

            //P110
            /*var list = new List<int> { 10, 20, 30, 40, };
            var key = 40;
            var num = list.Contains(key)? 1 : 0;
            Console.WriteLine(num);*/

            //P105
            /*var person = new Person {
                Name = "新井遥菜",
                Birthday = new DateTime(1995, 11, 23),
                PhoneNumber = "123-4567-890",

            };*/
        }

        /*private static Product GetProductA() {
            Sale sale = new Sale();
            //sale.Product = new Product();
            //sale = null;
            return sale?.Product; //null条件演算子
        }*/

        //P116
        //スタブ
        /*private static object DefaultMessage() {
            return "Default Message";
        }
        private static object GetMessage(object code) {
            return code;
        }*/
    }

    /*class Sale {
        public string ShopName { get; set; } = "abcde";
        public int Amount { get; set; } = 12340;
        public Product Product { get; set; }
    }*/
}
