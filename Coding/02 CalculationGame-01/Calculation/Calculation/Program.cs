using System;

namespace Calculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Random MyRandom = new Random(); //Inport random class from library

            // declare the variables that we need
            int num1, num2;
            int userAnswer, userScore = 0;
            int skillLevel = 1;
            int levelMultiplier = 17;   // we increment this everytime we change our skill level

            for (int count = 0; count < 10; count++) // For Loop
            {
                num1 = MyRandom.Next(0, skillLevel * levelMultiplier); // generates a random num from 0 to levelMultiplier * skillLevel
                num2 = MyRandom.Next(0, skillLevel * levelMultiplier); //

                Console.Write("What is " + num1 + " + " + num2 + ": "); //Question
                userAnswer = Convert.ToInt32(Console.ReadLine()); //Read in

                if (userAnswer == num1 + num2)
                {
                    Console.WriteLine("Correct");
                    userScore++;   // increment our correct score
                }
                else
                {
                    Console.WriteLine("Incorrect. The correct answer is " + (num1 + num2));
                }

                Console.WriteLine();
                Console.WriteLine("Your current score is " + userScore);

                // Now lets look to see if we should adjust the skill level
                if (userScore % 3 == 0) // count is a multiple of 3 so increase skill level
                {
                    skillLevel++;
                    Console.WriteLine("Congratulations, you skill level has increased\n\n");
                }
            }

            // We need to keep the window open, so wait for a ReadLine

            Console.ReadLine();
        }
    }
}

