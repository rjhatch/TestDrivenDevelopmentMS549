using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDrivenDevelopmentMS549
{
    class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            bool startOver = false;
            Menu menu = new Menu();

            while (!quit)
            {
                startOver = false;

                if (menu.InitialPrompt())
                {
                    StackRH stack = new StackRH(menu.Input);

                    while (!startOver)
                    {
                        if (menu.DisplayMenu())
                        {
                            if (menu.Input == 1 && menu.NumberInput())
                            {
                                if (stack.Push(menu.Input))
                                {
                                    menu.SuccessMessage($"Successfully added {menu.Input}!");
                                }
                                else
                                {
                                    menu.FailedMessage("The stack is full.");
                                }
                            }
                            else if (menu.Input == 2)
                            {
                                if (stack.Peek() != null)
                                {
                                    menu.SuccessMessage($"The top value is {stack.Peek()}.");
                                }
                                else
                                {
                                    menu.FailedMessage("The stack is empty.");
                                }
                            }
                            else if (menu.Input == 3)
                            {
                                int? success = stack.Pop();
                                if (success != null)
                                {
                                    menu.SuccessMessage($"The removed value is {success}.");
                                }
                                else
                                {
                                    menu.FailedMessage("The stack is empty.");
                                }
                            }
                            else if (menu.Input == 4)
                            {
                                startOver = true;
                                break;
                            }
                            else if (menu.Input == 5)
                            {
                                quit = true;
                                break;
                            }
                        }
                        else
                        {
                            menu.ErrorMessage();
                        }
                    }
                }
            }
        }
    }
}
