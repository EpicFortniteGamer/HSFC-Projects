using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int userAnswer = 0;

            Random myRandom = new Random ();
            num1 = myRandom.Next(1, 10);
            num2 = myRandom.Next(1, 10);

            for (int count=0; count < 10; count++)
            {

                Console.WriteLine("What is " + num1 + "+" + num2 + "?");
                userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == num1 + num2)
                {
                    Console.WriteLine("Correct");
                }


            }
        }
    }
}
