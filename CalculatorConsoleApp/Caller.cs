using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    public class Caller
    {
        public double[] myArr;
        public double num1;
        public double num2;
        
        public Caller(double[] myArr)
        {
            this.myArr = myArr;
        }
        public Caller(double num1,double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public double Addition(double[] calculate)
        {
            double result = 0;
            foreach (double item in calculate)
            {
                result = result + item;
            }
            return result;
        }
        public double Addition(double num1,double num2)
        {
            return num1 + num2;
        }
        public double Subtraction(double[] calculate)
        {
            double result = 0;
            foreach (double item in calculate)
            {
                result = result - item;
            }
            return result;
        }
        public double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public double Division(double num1, double num2)
        {
            double result = 0;

            result = num1 / num2;
            
            if (Double.IsInfinity(result) == true)
            {
                return 0;
            }
            else
            {
                return result;
            }
        }
    }
}
