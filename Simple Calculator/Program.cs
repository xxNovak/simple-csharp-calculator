using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to CALCULATOR");
            Console.WriteLine("Choose a number and write it");
            var number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Choose a sign now. Either '+', '-', '*' or '/'");
            var oprt = Console.ReadLine();
            if (oprt == "*")
            {
                Console.WriteLine("Pick another number, which you want to be multiplied");
            }
            else if (oprt == "+")
            {
                Console.WriteLine("Pick another number, which you want to be added");
            }
            else if (oprt == "-")
            {
                Console.WriteLine("Pick another number, which you want to be substracted");
            }
            else if (oprt == "/")
            {
                Console.WriteLine("Pick another number, which you want to be divided");
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
