using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculations
    {
        public enum Operations
        {
            Add = 1,
            Subtract,
            Multiply,
            Divide
        }

        private delegate double CalcD(double firstOperand, double secondOperand);

        private double Mul(double firstOperand, double secondOperand)
        {
            return firstOperand * secondOperand;
        }

        private double Div(double firstOperand, double secondOperand)
        {
            if (secondOperand == 0) throw new DivideByZeroException();
            return firstOperand / secondOperand;
        }

        private double Sum(double firstOperand, double secondOperand)
        {
            return firstOperand + secondOperand;
        }

        private double Sub(double firstOperand, double secondOperand)
        {
            return firstOperand - secondOperand;
        }

        public double Calculate(double firstOperand, double secondOperand, Operations operation)
        {
            CalcD function;
            switch(operation)
            {
                case Operations.Add:
                    function= new CalcD(Sum);
                    break;
                case Operations.Subtract:
                    function = new CalcD(Sub);
                    break;
                case Operations.Multiply:
                    function = new CalcD(Mul);
                    break;
                case Operations.Divide:
                    function = new CalcD(Div);
                    break;
                default:
                    throw new ArgumentException();
            }
            return function(firstOperand, secondOperand);
        }
    }
}
