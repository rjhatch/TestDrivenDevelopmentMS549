using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentMS549
{
    class Menu
    {
        private int input;
        public int Input { get { return input; } }

        public bool InitialPrompt()
        {
            Console.Write("How many elements would you like to work with (must be an integer from 1 to 10)? ");
            if (!TestInput(Console.ReadLine(), 1, 10))
            {
                ErrorMessage();
                return false;
            }

            return true;
        }

        public bool DisplayMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.Write("1) Add a value.\n" +
                "2) See the top value.\n" +
                "3) Remove the top value.\n" +
                "4) Start over.\n" +
                "5) Quit.\n>>");

            string choice = Console.ReadLine();
            if (TestInput(choice, 1, 5))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool TestInput(string value, int min, int max)
        {
            try
            {
                int num = Int32.Parse(value);
                if (num >= min && num <= max)
                {
                    input = num;
                    return true;
                }
            }
            catch (Exception)
            {

                return false;
            }
            return false;
        }

        public void ErrorMessage()
        {
            Console.WriteLine("The value must be a postive integer and within range.");
        }

        public bool NumberInput()
        {
            Console.Write("Enter a number from 1 to 100: ");
            string choice = Console.ReadLine();
            if (TestInput(choice, 1, 100))
            {
                return true;
            }

            return false;
        }

        public void SuccessMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public void FailedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
