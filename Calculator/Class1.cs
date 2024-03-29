﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise0
{
    public class Calculator
    {
        public Calculator()
        {
            Accumulator = 0.0;
        }

        public double Add(double a, double b)
        {
            Accumulator = a + b;
            return Accumulator;
        }

        public double Subtract(double a, double b)
        {
            Accumulator = a - b;
            return Accumulator;
        }

        public double Multiply(double a, double b)
        {
            Accumulator = a * b;
            return Accumulator;
        }

        public double Power(double x, double exponent)
        {
            Accumulator = Math.Pow(x, exponent);
            return Accumulator;
        }

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                Accumulator = double.NaN;
                return Accumulator;
            }
            else
            {
                Accumulator = dividend / divisor;
                return Accumulator;
            }
        }

        public void Clear(double Accumulator)
        {
            Accumulator = 0.0;
        }
        public double Accumulator { get; private set; } 

    }
}
