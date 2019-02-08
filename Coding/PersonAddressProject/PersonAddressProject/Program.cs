using System;

namespace PersonAddressProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1;
            p1 = new Person("", "", 0);
            p1.setOthernames("Vondy");
            Console.WriteLine(p1.getotherNames());

            p1.setSurname("Fix your game it has been out for 4 weeks");
            Console.WriteLine(p1.getSurname());

            p1.setAge(404);
            Console.WriteLine(p1.getAge());

            Console.Read();

            while (0 != 1)
            {
                Console.WriteLine("Error404: 'CallofDuty.BlackOps4' has stopped wprking");
            }

            Console.Read();
        }
    }
}
