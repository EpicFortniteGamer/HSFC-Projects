using System;

namespace Stack
{
    class Program
    {
        static Stack s1;
        static void Main(string[] args)
        {
            Console.WriteLine("How big do you want your stack?");
            int num = Convert.ToInt32(Console.ReadLine());
            s1 = new Stack(num);
        }
    }
}
