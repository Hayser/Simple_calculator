using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
   public class InputConverted
    {
       public double ConvertInput(string text)
        {
            double convertedNumber;

            if (!double.TryParse(text, out convertedNumber))
                throw new ArgumentException("El valor ingresado no es numero.");
                return convertedNumber;
            
        }
    }
}
