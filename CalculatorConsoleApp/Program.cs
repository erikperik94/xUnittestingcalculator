using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] myArr = new double[] { 1, 2, 3 };
            double num1 = 1;
            double num2 = 2;
            double num11 = 1;
            double num22 = 0;
            

            Caller Add_result = new Caller(myArr);
            Caller Sub_result = new Caller(myArr);
            Caller Div_result = new Caller(num1,num2);
            Caller Mul_result = new Caller(num1,num2);

            Console.WriteLine(Add_result.Addition(myArr));
            Console.WriteLine(Sub_result.Subtraction(myArr));
            Console.WriteLine(Div_result.Division(num11,num22));
            Console.WriteLine(Mul_result.Multiplication(num1,num2));

        }
    }
}