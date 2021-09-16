using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._4.Tests
{
    public class Remainder
    {
        public double FirstDigit { get; set; }
        public double SecondDigit { get; set; }

        public double Remain { get; private set; }

        public Remainder(double firstDigit, double secondDigit) 
        {
            FirstDigit = firstDigit;
            SecondDigit = secondDigit;
            Remain = FirstDigit - SecondDigit;
        }
    }
}
