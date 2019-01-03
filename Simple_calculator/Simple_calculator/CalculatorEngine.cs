using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    public class CalculatorEngine
    {
        public double Calculate(string operation,double first, double second)
        {
            double result;
            switch (operation.ToLower())
            {
                case "suma":
                case "+":
                result=first + second;
                break;

                case "resta":
                case "-":
                result = first - second;
                break;

                case "multiplicación":
                case "multiplicacion":
                case "*":
                result = first * second;
                break;

                case "división":
                case "division":
                case "/":
                result = first / second;
                break;

                default:
                throw new InvalidOperationException("No se reconoce la operación ingresada.");
            }
            return result;
        }
    }
}
