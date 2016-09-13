using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class ConsoleIOCalculator
    {
        private double FirstOperand = 0;
        private double SecondOperand = 0;
        private Calculations.Operations Operation;

        public double Calculate()
        {
            double result = 0;
            Calculations calculations = new Calculations();
            try
            {
                Console.Write("First operand is ");
                FirstOperand = double.Parse(Console.ReadLine());
                Console.Write("Second operand is ");
                SecondOperand = double.Parse(Console.ReadLine());
                Console.WriteLine("Choose an operation 1 - sum, 2 - sub, 3 - mul, 4 - div ");
                int tOperation = int.Parse(Console.ReadLine());
                Operation = (Calculations.Operations)tOperation;

                result = calculations.Calculate(FirstOperand, SecondOperand, Operation);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Error: Invalid operation." + ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero." + ex.Message);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Error: Wrong format." + ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: Unknown exception." + ex.Message);
            }
            Console.WriteLine("Result is {0}", result);
            return result;
        }
    }
}
