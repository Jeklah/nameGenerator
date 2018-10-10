using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nameGenerator {
    class Program {
        static void Main(string[] args) {
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            try {
                for (int i = 0; i < nameDictionary.names.Count; i++) {
                    nameDictionary.names.ForEach(name => Console.Write("{0}\n", name));
                    Console.ReadKey();
                }
            } catch (System.IO.IOException nameNull) {
                Console.WriteLine("Exception caught: {0}", nameNull);
            } catch (TypeInitializationException typeExcp) {
                Console.WriteLine("Exception caught: {0}", typeExcp);
                Console.ReadKey();
            } finally {
                Console.WriteLine("end.");
            }
            

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
