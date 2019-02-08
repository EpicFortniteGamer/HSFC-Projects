using System;

namespace PesonProject
{
    class Program  
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.setName("Fred");
            Console.WriteLine("The name of p1 is" + p1.getName());
            Person p2 = new Person();
            p2.setName("Mary");
            Console.WriteLine("The name of p2 is " + p2.getName()); 
           
        }
    }
}
