using System.Collections.Generic;
using System.IO;

namespace Test01 {
    class ScoreCounter {
        private IEnumerable<Student> _score;

        // コンストラクタ
        public ScoreCounter(string filePath) {
            _score = ReadScore(filePath);


            
        }


        //メソッドの概要： 生徒情報を読み込み、Studentオブジェクトのリストを返す
        private static IEnumerable<Student> ReadScore(string filePath) {
            List<Student> students = new List<Student>();
            string[] lines = File.ReadAllLines(filePath);
            foreach(string line in lines) {
                string[] items = line.Split(',');
                Student student = new Student {
                    Name = items[0],
                    Subject = items[1],
                    Score = int.Parse(items[2])
                };
                students.Add(student);
            }
            return students;





            
        }

        //メソッドの概要： 教科別得点を求める
        public IDictionary<string, int> GetPerStudentScore() {
            var dict = new Dictionary<string, int>();
            foreach(var student in _score) {
                if (dict.ContainsKey(student.Subject))
                    //すでにコレクション点数が設定されている
                    dict[student.Subject] += student.Score;
                else
                    //コレクション点数を登録
                    dict[student.Subject] = student.Score;
            }
            return dict;



            
        }
    }
}
