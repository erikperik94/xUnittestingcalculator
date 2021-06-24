using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Quit this program press enter or Continue with another key.");
                var stopprogram = Console.ReadKey().Key;
                if (stopprogram == ConsoleKey.Enter)
                {
                    break;
                }
                Console.WriteLine("By typing 1 you choose to Add two numbers");
                Console.WriteLine("By typing 2 you choose to Substract two numbers");
                Console.WriteLine("By typing 3 you choose to Divide two numbers");
                Console.WriteLine("By typing 4 you choose to Multiply two numbers ");
                int userSelection = GetNumberFromUser("menu selection");
                double number1 = 0;
                double number2 = 0;
                switch (userSelection)
                {
                    case 1:
                        Console.WriteLine("You choosed Addition");
                        (number1, number2) = GetUserInputs(userSelection);
                        Caller Add_result = new Caller(number1, number2);
                        Console.WriteLine(Add_result.Addition(number1, number2));
                        break;

                    case 2:
                        Console.WriteLine("You choosed Subtraction");
                        (number1, number2) = GetUserInputs(userSelection);
                        Caller Sub_result = new Caller(number1, number2);
                        Console.WriteLine(Sub_result.Subtraction(number1, number2));
                        break;

                    case 3:
                        Console.WriteLine("You choosed Division");
                        (number1, number2) = GetUserInputs(userSelection);
                        Caller Div_result = new Caller(number1, number2);
                        Console.WriteLine(Div_result.Division(number1, number2));
                        break;

                    case 4:
                        Console.WriteLine("You choosed Multiplication");
                        (number1, number2) = GetUserInputs(userSelection);
                        Caller Multi_result = new Caller(number1, number2);
                        Console.WriteLine(Multi_result.Multiplication(number1, number2));
                        break;

                    default:
                        Console.WriteLine("Not in the menu");
                        break;
                }
            }

        }//end of Main
        public static int GetNumberFromUser(string forWhat)
        {
            Console.Write("Enter " + forWhat + " number: ");
            string userInput = Console.ReadLine();

            int number = 0;
            int.TryParse(userInput, out number);

            return number;
        }
        public static (double number1, double number2) GetUserInputs(int userSelection)
        {
            string userInput1 = Console.ReadLine();
            double number1;
            double.TryParse(userInput1, out number1);

            string userInput2 = Console.ReadLine();
            double number2;
            double.TryParse(userInput2, out number2);
            while (number2 == 0 && userSelection == 3)
            {
                Console.WriteLine($"Invalid number {number2} for division, write another number");
                string userInput3 = Console.ReadLine();
                double.TryParse(userInput3, out number2);
                if (number2 != 0)
                {
                    break;
                }
            }
            return (number1, number2);
        }
    }
}