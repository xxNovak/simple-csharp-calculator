using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CALCULATOR");
            Console.WriteLine("Choose a number and write it here");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a sign now. Either '+', '-', '*' or '/'");
            var oprt = Console.ReadLine();
            if (oprt == "*")
            {
                Console.WriteLine("Pick another number, which you want to be multiplied by furst number");
            }
            else if (oprt == "+")
            {
                Console.WriteLine("Pick another number, which you want to be added to first number");
            }
            else if (oprt == "-")
            {
                Console.WriteLine("Pick another number, which you want to be substractd from first number");
            }
            else if (oprt == "/")
            {
                Console.WriteLine("Pick another number, which you want first number to be divided by");
            }
            var number2 = int.Parse(Console.ReadLine());
            var result = 0;
            switch (oprt)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    result = number1 / number2;
                    break;
                default:
                    Console.WriteLine("Weirdo, you've chosen death");
                    break;
            }
            Console.WriteLine(result);
        }
    }
}
