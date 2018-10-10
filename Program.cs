using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameGenerator {
    class Program {
        static void Main(string[] args) {
            // Writing names to console.
            // try {
            //     for (int i = 0; i < nameAnalyser.names.Count; i++) {
            //         nameAnalyser.names.ForEach(name => Console.Write("{0}\n", name));
            //         Console.ReadKey();
            //     }
            // } catch (System.IO.IOException nameNull) {
            //     Console.WriteLine("Exception caught: {0}", nameNull);
            // } catch (TypeInitializationException typeExcp) {
            //     Console.WriteLine("Exception caught: {0}", typeExcp);
            //     Console.ReadKey();
            // } finally {
            //     Console.WriteLine("end.");
            // }
            List<char> chr = new List<char>();
            string subStrStart = String.Empty;
            // Filling the dictionarys.
            try {
                for (int i = 0; i < nameAnalyser.names.Count(); i++) {
                    string chrStart = nameAnalyser.names[i].Substring(2, nameAnalyser.names[i].Length - 2);
                    subStrStart = nameAnalyser.names[i].Substring(0, 2);
                    foreach (char c in chrStart) {
                        chr.Add(c);
                        
                    }
                    
                }
                
                nameAnalyser.goodNameStartings.Add(subStrStart, chr);
            } catch (System.IndexOutOfRangeException outOfRange) {
                Console.WriteLine("Exception caught: {0}", outOfRange);
            } catch (System.ArgumentException argExcp) {
                Console.WriteLine("Exception caught: {0},", argExcp);
            } finally {
                Console.WriteLine("end.");
            }

            Console.WriteLine("Values: " + nameAnalyser.goodNameStartings.Values);
            Console.WriteLine("Keys:  " + nameAnalyser.goodNameStartings.Keys);
            Console.ReadKey();
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
