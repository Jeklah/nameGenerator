using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace nameGenerator {
    public class nameDictionary {
        const string FILEPATH = "D:\\Projects\\nameGenerator\\nameGenerator\\names.txt";
        // List<string> names = new List<string>();
        static string[] nameFile = File.ReadAllLines(FILEPATH);
        public static List<string> names = new List<string>(nameFile); 
    }
}
