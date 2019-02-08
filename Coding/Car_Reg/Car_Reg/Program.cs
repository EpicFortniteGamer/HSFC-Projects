using System;

namespace Car_Reg
{
    class Program
    {
        static void Main(string[] args)
        {
            bool checkRules(String Reg)
            {
                bool success = true;
                char letter = Reg[0];
                if ((letter < 'A') | (letter > 'Z') |
                    (letter == 'I') | (letter == 'Q') | (letter == 'Z'));
                {
                    Console.ReadLine("Error in fist character");
                }
                
                       
            }

            string reg;
            int reg_year;
            Console.WriteLine("Does your car have a current registration number? (Please answer 'Yes' or 'No')");
            reg = Console.ReadLine();

            if (reg == "Yes")
            {
                Console.WriteLine("Please enter registration year");
                reg_year = Convert.ToInt32(Console.ReadLine());

                if (reg_year < 2001)
                {
                    incorrect();
                }

                else
                {
                    Console.WriteLine("Please enter registration number");
                    String myReg = Console.ReadLine();
                }

            }
            else
            {
                incorrect();
            }
            Console.ReadLine();
        }

        static void incorrect()
        {
            Console.WriteLine("Yeet");
            Console.ReadLine();
        }
    }
}
