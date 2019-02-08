using System;

namespace HalloweenTingYeet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("There is something lurking in the shadows " + userName + ". Which weapon will you choose?");

            Console.WriteLine(@"
1. A silver bullet
2. A Wooden stake
3. A priest
");
            int weapon = Convert.ToInt32(Console.ReadLine());
            if (weapon == 1)
            {
                Console.WriteLine("You have chosen a silver bullet!");
            } 
            else if (weapon == 2)
            {
                Console.WriteLine("You have chosen a wooden stake!");
            }
            else if (weapon == 3)
            {
                Console.WriteLine("You have chosen a priest!");
            }
            else
            {
                Console.WriteLine("You have chosen not to arm yourself..");
            }




        }
    }
}
