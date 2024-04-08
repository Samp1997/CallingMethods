using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(MathOps.Math1(number));
            Console.ReadLine();
        }


    }
}
