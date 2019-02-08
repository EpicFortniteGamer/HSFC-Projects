using System;

namespace ConversionProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            int choice = 0;
            Console.WriteLine("1. Reverse a string");
            Console.WriteLine("2. Denary to Binary");
            Console.WriteLine("3. Binary to denary");
            Console.WriteLine("4. Quit");

            Conversion myConvert = new Conversion();
            Console.WriteLine("Enter your string to reverse");
            String userString = Console.ReadLine();
            Console.WriteLine("The reverse is {0}", myConvert.ReverseString(userString));

            int ToDenary(String binaryString)
            {
                return 0;
            }

            String ToBinary(int decimalNumber);
            {
                return 0;
            }




        }

    }

}
