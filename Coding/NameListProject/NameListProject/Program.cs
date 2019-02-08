using System;

namespace NameListProject
{
    class Program
    {
        public static void Main(string[] args)
        {
            NameList theNames = new NameList();
            theNames.AddName("Vondy");
            theNames.AddName("Jason");
            theNames.AddName("Craig");

            Console.WriteLine("There are now " + theNames.Length() + " entries in the table");
            theNames.RemoveName("Craig");
            Console.WriteLine("There are now " + theNames.Length() + " entries in the table");

        }


    }
}
