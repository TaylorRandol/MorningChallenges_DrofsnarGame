using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sept21st
{
    public class Calculator
    {

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        public double Subtract(double numOne, double numTwo)
        {
            return numOne - numTwo;
        }

        public double Multiply(double numOne, double numTwo)
        {
            return numOne * numTwo;
        }

        public double Divide(double numOne, double numTwo)
        {
            double sum = numOne / numTwo;
            return sum;
        }

        public double Difference(params double[] args)
        { 
            double runningTotal = args[0] + args[0];
            foreach(double arg in args)
            {
                runningTotal -= arg;
            }
            return runningTotal;
        }
    }
}
