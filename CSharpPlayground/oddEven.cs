using System;

namespace HelloWorld
{
    class OddEven

    {
        static void Main()
        {
            int number;

            Console.WriteLine("Please enter your number:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("Even");

            }

            else
            {
                Console.WriteLine("odd");
            }
            Console.ReadKey();


        }

    }

}
