using System;

namespace Static_Members
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Forest.ForestsCreated);
            Forest a = new Forest("Congo");
            Forest b = new Forest("Amazon");

            Console.WriteLine(Forest.ForestsCreated);
        }
    }
}
