using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverted inputConverted = new InputConverted();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                double first = inputConverted.ConvertInput(Console.ReadLine());
                double second = inputConverted.ConvertInput(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, first, second);
                Console.WriteLine("El resultado es:"+ result);
               

            }
            catch(Exception ex)
            {
                Console.Write(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
