using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator. WORKING Edition by HAHOOS");
            Console.Write("First Number:");
            var first = int.Parse(Console.ReadLine());
            Console.WriteLine("Operator:");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Substraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            var _operator = int.Parse(Console.ReadLine());
            Console.Write("Second Number:");
            var second = int.Parse(Console.ReadLine());
            if(_operator == 1)
            {
                Console.WriteLine($"{first} + {second} = {first + second}");
            }else if(_operator == 2)
            {
                Console.WriteLine($"{first} - {second} = {first - second}");
            }else if(_operator == 3)
            {
                Console.WriteLine($"{first} • {second} = {first * second}");
            }else if(_operator == 4)
            {
                Console.WriteLine($"{first} ÷ {second} = {first / second}");
            }
            
            Main(null);
        }
    }
}
