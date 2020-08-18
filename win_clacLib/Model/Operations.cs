using System;
using System.Collections.Generic;
using System.Text;

namespace win_calc
{
    public class Operations: Iwin_Calc
    {
        public double Add(double value, double value2)
        {
            return value + value2;
        }

        public double Times(double value, double value2)
        {
            return value * value2;
        }

        public double Divide(double value, double value2)
        {
            if (value2 == 0)
            {
                throw new DivideByZeroException("You can't divide by zero");
            }
            return value / value2;
        }

        public double Subtract(double value, double value2)
        {
            return value - value2;
        }
    }
}
