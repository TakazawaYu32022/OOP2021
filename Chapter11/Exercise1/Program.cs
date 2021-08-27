using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = "Sample.xml";
            Exercise1_1(file);
            Console.WriteLine("-------");
            var file2 = "Sample.xml";
            Exercise1_2(file2);
            Console.WriteLine("-------");
            /*var file = "Sample.xml";
            Exercise1_3(file);
            Console.WriteLine("-------");*/
        }

        private static void Exercise1_1(string file)
        {
            var xdoc = XDocument.Load("Sample.xml");
            foreach (var sample in xdoc.Root.Elements())  
            {
                var xname = sample.Element("name");
                var member = (int)sample.Element("teammembers");
                Console.WriteLine("{0} {1}",xname.Value,member.ToString());
            }
        }

        private static void Exercise1_2(string file2)
        {
            var xdoc = XDocument.Load("Sample.xml");
            var xsamples = xdoc.Root.Elements()
                                       .Select(x => new
                                       {
                                           Firstplayed = x.Element("firstplayed").Value,
                                           Name = x.Element("name").Attribute("kanji").Value
                                       }).OrderBy(x => int.Parse(x.Firstplayed));//Order ByをOrder By Descendingにすると新しい順になる
            foreach (var sample in xsamples)
            {
                Console.WriteLine("{0} {1}",sample.Name,sample.Firstplayed);
            }
        }

        /*private static void Exercise1_3(string file)
        {
            var xdoc = XDocument.Load("Sample.xml");
        }*/
    }
}
