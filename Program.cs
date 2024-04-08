using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter three numbers");
            int number = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            int number3 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            //Taking each int and applying to the methods
            Console.WriteLine(MathOps.Math1(number));
            Console.ReadLine();

            Console.WriteLine(MathOps.Math2(number2));
            Console.ReadLine();

            Console.WriteLine(MathOps.Math3(number3));
            Console.ReadLine();
        }


    }
}
