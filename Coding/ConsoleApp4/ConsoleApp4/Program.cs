using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] num;
            num = new int[20];

            for(int iter = 0; iter < num.Length; iter++)
            {
                Console.WriteLine("Please enter your num");
                num[iter] = Convert.ToInt32(Console.ReadLine());
            }
            for(int iter = num.Length-1; iter >= 0; iter--)
            {
                Console.WriteLine(num[iter]);
            }
            Console.Read();

            
            


        }
    }
}
