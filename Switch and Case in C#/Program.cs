using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_and_Case_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 5: ");
            int number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    Console.WriteLine("You entered one.");
                    break;
                case 2:
                    Console.WriteLine("You entered two.");
                    break;
                case 3:
                    Console.WriteLine("You entered three.");
                    break;
                case 4:
                    Console.WriteLine("You entered four.");
                    break;
                case 5:
                    Console.WriteLine("You entered five.");
                    break;
                default:
                    Console.WriteLine("You entered a number outside the range of 1 to 5.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
