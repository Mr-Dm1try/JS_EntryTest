using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask {
    class Program {
        static void Main(string[] args) {
            String str, sel = "";

            Console.WriteLine("\t### Insidious brackets ###");
            do {
                Console.WriteLine("Input a line with brackets to check their placement:");
                str = Console.ReadLine();
                Console.WriteLine();

                Int32 result = Brackets.CheckBracketPlacement(str);
                if (result == -1)
                    Console.WriteLine("Brackets are located correctly!");
                else
                    Console.WriteLine("Brackets are located incorrectly! Error detected at index " + result);

                Console.WriteLine("Again? (y/n)");
                sel = Console.ReadLine();
                while(sel != "n" && sel != "N" && sel != "y" && sel != "Y") {
                    Console.WriteLine("Wrong symbol!!!");
                    Console.WriteLine("Again? (y/n)");
                    sel = Console.ReadLine();
                }

                Console.WriteLine();
                Console.WriteLine();
            } while (sel != "n" && sel != "N");
        }
    }
}
