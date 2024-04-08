using System;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            
            Console.ReadLine();
            //Taking each int and applying to the methods
            Console.WriteLine(MathOps.Math1(number));
            Console.ReadLine();

            Console.WriteLine(MathOps.Math2(number));
            Console.ReadLine();

            Console.WriteLine(MathOps.Math3(number));
            Console.ReadLine();

            Console.WriteLine("The number selected has been divided, multiplied and added by 5");
        }


    }
}
