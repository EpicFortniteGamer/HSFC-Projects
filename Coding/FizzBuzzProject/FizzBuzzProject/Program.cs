using System;

namespace FizzBuzzProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random MyRandom = new Random();

            int Num;
            int Fizz = 3;
            int Buzz = 5;
            string UserAns;

            Console.WriteLine("Welcome to FizzBuzz!");
            Console.WriteLine("Let's get started!");
            Console.WriteLine("Please make sure your answers have capital letters, for example: FizzBuzz");
            
            Num = MyRandom.Next(0, 20);
            Console.WriteLine(Num);
            for (int i = 0; i > 0; i--)
            {
                
                Console.WriteLine("Here we go:" + Num);
                UserAns = Console.ReadLine();


                if (Num % Fizz == 0)
                {
                    if (UserAns == "Fizz")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                }

                if (Num % Buzz == 0)
                {
                    if (UserAns == "Buzz")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                }

                if (Num % Fizz % Buzz == 0)
                {
                    if (UserAns == "FizzBuzz")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Incorrect!");
                    }
                }

                else
                {
                    Console.WriteLine("Correct!");
                }
            }
            Console.ReadLine();

        }
    }
}
