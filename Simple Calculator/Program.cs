using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a calculator. WORKING Edition by HAHOOS");
            var math = Console.ReadLine();
            var mathArgs = math.Split(" ");
            Console.WriteLine((int.Parse(mathArgs[0]) + int.Parse(mathArgs[1])));
            Main(null);
        }
    }
}
