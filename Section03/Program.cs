using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section03 {

    // List 7-20
    class Program {
        static void Main(string[] args) {
            // コンストラクタ呼び出し
            var abbrs = new Abbreviations();

            // Addメソッドの呼び出し例
            abbrs.Add("IOC", "国際オリンピック委員会");
            abbrs.Add("NPT", "核兵器不拡散条約");

            // インデクサの利用例
            var names = new[] { "WHO", "FIFA", "NPT", };
            foreach (var name in names) {
                var fullname = abbrs[name];
                if (fullname == null)
                    Console.WriteLine("{0}は見つかりません", name);
                else
                    Console.WriteLine("{0}={1}", name, fullname);
            }
            Console.WriteLine();

            // ToAbbreviationメソッドの利用例
            var japanese = "東南アジア諸国連合";
            var abbreviation = abbrs.ToAbbreviation(japanese);
            if (abbreviation == null)
                Console.WriteLine("{0} は見つかりません", japanese);
            else
                Console.WriteLine("「{0}」の略語は {1} です", japanese, abbreviation);
            Console.WriteLine();

            // FindAllメソッドの利用例
            foreach (var item in abbrs.FindAll("国際")) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
            Console.WriteLine();

            //7.2.3(Countの呼び出し)
            var count = abbrs.Count;
            Console.WriteLine("----7.2.3 Countの呼び出し ----");
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            //7.2.3(Removeの呼び出し)
            Console.WriteLine("----7.2.3 Removeの呼び出し ----");
            if (abbrs.Remove("IOC")) {
                Console.WriteLine("削除されました");
            }
            if (abbrs.Remove("IOC")) {
                Console.WriteLine("削除されました");
            } else {
                Console.WriteLine("削除エラー");
            }

            //7.2.3(Removeでちゃんと消えたか確認)
            count = abbrs.Count;
            Console.WriteLine("----7.2.3 Countの呼び出し ----");
            Console.WriteLine(abbrs.Count);
            Console.WriteLine();

            //7.2.4
            foreach(var item in abbrs.Where(x=>x.Key.Length == 3)) {
                Console.WriteLine("{0}={1}", item.Key, item.Value);
            }
        }
    }
}
