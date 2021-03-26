using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCalculator
{
    class Calculate : ICalculate
    {
        public int Division(int number1, int number2)
        {
            return number1 / number2;
        }

        public int Minus(int number1, int number2)
        {
            return number1 - number2;
        }

        public int Multiple(int number1, int number2)
        {
            return number1 * number2;
        }

        public int Plus(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
