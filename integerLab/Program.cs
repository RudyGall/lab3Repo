using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace integerLab
{
    class Program
    {
        static void Main(string[] args)
        {
            char doAgain;
            bool runP = true;

            Console.WriteLine("Please enter your first name");
            string firstName = Console.ReadLine();

            while (runP == true)
            {
                Console.WriteLine("Hello {0}, Please enter an interger value between 1 and 100",
                    firstName);
                int value = int.Parse(Console.ReadLine());
                Console.WriteLine("You entered {0}, lets perform the conditional actions!",
                    value);
                if (value % 2 == 0 & value > 2 & value < 25 & value < 100)
                {
                    Console.WriteLine("Even and less than 25");
                    Console.ReadLine();
                }
                else if (value % 2 == 0 & value > 25 & value <= 60)
                {
                    Console.WriteLine("Even");
                    Console.ReadLine();
                }
                else if (value % 2 == 0 & value >= 60 & value < 100)
                {
                    Console.WriteLine("{0}, Even", value);
                    Console.ReadLine();
                }
                else if (value % 2 != 0 & value >= 60 & value < 100)
                {
                    Console.WriteLine("{0}, Odd", value);
                    Console.ReadLine();
                }
                else if (value % 2 != 0 & value > 1 || value < 100)
                {
                    Console.WriteLine("{0}, Odd", value);
                    Console.ReadLine();
                }
                    else if (value % 2 != 0 || value % 2 == 0 & value < 1 || value > 100)
                {
                    Console.WriteLine("Not an integer between 1 and 100");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid entry");
                    Console.ReadLine();
                }
                Console.WriteLine("{0}, Would you like to run the application again? (Y or N)",
                    firstName);

                doAgain = Convert.ToChar(Console.ReadLine());

                if (doAgain != 'y' && doAgain != 'Y')
                {
                    runP = false;
                }
                else
                    runP = true;
            }
        }
    }
}