using System;

namespace LoopDemo
{
    class Program
    {
        static void RangedDoWhile()
        {
            // [20, 30]
            Console.WriteLine("Welcome to ranger");

            int value = 0;
            do
            {
                Console.Write("Please enter number between 20 and 30: ");
                value = Convert.ToInt32(Console.ReadLine());
            } while (value < 20 || value > 30);

            Console.WriteLine($"You entered {value}");
        }

        static void RangedWhile()
        {
            // Dit keer met while
            // Zorgt dikwijls wel voor code-duplicatie

            // [20, 30]
            Console.WriteLine("Welcome to ranger");

            Console.Write("Please enter number between 20 and 30: ");
            int value = Convert.ToInt32(Console.ReadLine());
            while (value < 20 || value > 30)
            {
                Console.Write("Sorry you missed. Please enter number between 20 and 30: ");
                value = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"You entered {value}");
        }

        static void TwoRanges()
        {
            // [20, 30] or [80,100]
            Console.WriteLine("Welcome to ranger");

            int value = 0;
            do
            {
                Console.Write("Please enter number between 20 and 30 or between 80 and 100: ");
                value = Convert.ToInt32(Console.ReadLine());
            } while ((value < 20 || value > 30)
                && (value < 80 || value > 100));

            Console.WriteLine($"You entered {value}");
        }

        static void CountDown()
        {
            // 5 ... 4 ... 3 ... 2 ... 1 ... 0

            for (int countDown = 5; countDown >= 0; countDown--)
            {
                System.Threading.Thread.Sleep(1000);

                //if (countDown > 0)
                //{
                //    Console.Write($"{countDown} ... ");
                //}
                //else
                //{
                //    Console.Write($"{countDown}");
                //}

                // OR

                if (countDown == 0)
                {
                    Console.Write($"{countDown}");
                } else
                {
                    Console.Write($"{countDown} ... ");
                }
            }
        }

        static void CountDownNoIf()
        {
            // 5 ... 4 ... 3 ... 2 ... 1 ... 0

            for (int countDown = 5; countDown >= 1; countDown--)
            {
                System.Threading.Thread.Sleep(1000);
                Console.Write($"{countDown} ... ");
            }
            Console.Write("0");
        }

        static void Log2()
        {
            // 2^3 = 8
            // How do we determine exponent? (3)

            Console.WriteLine("Welcome to log2");

            Console.Write("Please enter your log2(x) value: ");
            int value = Convert.ToInt32(Console.ReadLine());

            int exponent = 0;
            while(value > 1)
            {
                value /= 2;     // SAME: value = value / 2;
                exponent++;
            }

            Console.WriteLine($"2 ^ {exponent} = {Math.Pow(2, exponent)}");
        }

        static void Menu()
        {
            // Menu tonen aan de gebruiker en deze een keuze laten maken
            // maar dit keer op basis van string input
            Console.WriteLine("Welcome to my greeter app");

            string userChoice = "";
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("hello: say hello");
                Console.WriteLine("bye: say good bye");
                Console.WriteLine("exit|quit: Exit the app ...");

                userChoice = Console.ReadLine();
                switch (userChoice)
                {
                    case "hello":
                        Console.WriteLine("Computer says hello");
                        break;

                    case "bye":
                        Console.WriteLine("Leaving already ?? Nooooo");
                        break;

                    default:
                        if (userChoice == "exit" || userChoice == "quit")
                        {
                            Console.WriteLine("Closing app ...");
                        }
                        else
                        {
                            Console.WriteLine("Sorry unknown command");
                        }
                        break;
                }
            } while (userChoice != "quit" && userChoice != "exit");
        }

        static void MenuIfElse()
        {
            // Zelfde als Menu() maar dit keer met if-else in plaats
            // switch case
            Console.WriteLine("Welcome to my greeter app");

            string userChoice = "";
            bool keepRunning = true;
            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("hello: say hello");
                Console.WriteLine("bye: say good bye");
                Console.WriteLine("exit|quit: Exit the app ...");

                userChoice = Console.ReadLine();
                if (userChoice == "hello")
                {
                    Console.WriteLine("Computer says hello");
                } else if (userChoice == "bye")
                {
                    Console.WriteLine("Leaving already ?? Nooooo");
                } else if (userChoice == "exit" || userChoice == "quit")
                {
                    Console.WriteLine("Closing app ...");
                    keepRunning = false;
                } else
                {
                    Console.WriteLine("Sorry unknown command");
                }
            } while (keepRunning);
        }



        static void Main(string[] args)
        {
            // Haal een methode uit commentaar

            RangedDoWhile();
            //RangedWhile();
            //TwoRanges();
            //CountDown();
            //CountDownNoIf();
            //Log2();
            //Menu();
            //MenuIfElse();
        }
    }
}
