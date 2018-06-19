using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type in value 1: ");
            string value1 = Console.ReadLine();

            Console.Write("Type in value 2: ");
            string value2 = Console.ReadLine();

            int average = (int.Parse(value1) + int.Parse(value2)) / 2;
            int amount = int.Parse(value1) + int.Parse(value2);
            int difference = int.Parse(value1) - int.Parse(value2);

            Console.WriteLine("Avarage: " + average);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Difference: " + difference);

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadLine();
        }
    }
}
