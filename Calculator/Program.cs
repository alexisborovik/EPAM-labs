using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isContinue = true;
            ConsoleIOCalculator calculator = new ConsoleIOCalculator();
            Console.WriteLine("Calculator v 1.0");
            while (isContinue)
            {
                calculator.Calculate();
                Console.WriteLine("Continue? y/n");
                if(Console.ReadLine()=="n")isContinue=false;
            }
        }
    }
}
