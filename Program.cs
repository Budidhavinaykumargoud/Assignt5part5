using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentPart5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your score as a percentage");
            int X = int.Parse(Console.ReadLine());
            if (X >= 90)
            {
                Console.WriteLine('A');
            }
            else if (X >= 80 && X <= 89)
            {
                Console.WriteLine('B');
            }
            else if (X >= 70 && X <= 79)
            {
                Console.WriteLine('C');
            }
            else if (X >= 60 && X <= 69)
            {
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine('F');
            }
            Console.ReadKey();
        }
    }
}
