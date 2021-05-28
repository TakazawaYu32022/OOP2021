using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator {
    //売り上げ集計クラス
    class SalesCounter {
        private IEnumerable<Sale> _sales;

        //コンストラクタ
        public SalesCounter(string filePath) {
            _sales = ReadSales(filePath);
        }

        private static IEnumerable<Sale> ReadSales(string filePath) {
            List<Sale> sales = new List<Sale>();
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines) {
                string[] items = line.Split(',');
                Sale sale = new Sale {
                    ShopName = items[0],
                    Productcategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);
            }
            return sales;
        }

        public IDictionary<string,int> GetPerStoreSales() {
            var dict = new Dictionary<string, int>();
            foreach(var sale in _sales) {
                if (dict.ContainsKey(sale.ShopName))
                    //すでにコレクション店舗が設定されている
                    dict[sale.ShopName] += sale.Amount;
                else
                    //コレクションへ店舗を登録
                    dict[sale.ShopName] = sale.Amount;
            }
            return dict;
        }
    }
}
