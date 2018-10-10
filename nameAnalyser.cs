using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nameGenerator {
    public class nameAnalyser {
        const string FILEPATH = "D:\\Projects\\nameGenerator\\nameGenerator\\names.txt";
        static string[] nameFile = File.ReadAllLines(FILEPATH);
        public static List<string> names = new List<string>(nameFile);
        public static Dictionary<string, List<char>> goodNameStartings = new Dictionary<string, List<char>>();
        public Dictionary<string, List<char>> goodNameEndings = new Dictionary<string, List<char>>();
    }
}

