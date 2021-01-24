using System;

namespace LoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("LOOPING EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Print Numbers in Reverse Order");
                Console.WriteLine("2. Reverse Counting");
                Console.WriteLine("3. Print the Square of Even Numbers");
                Console.WriteLine("4. Guess the Magic Number");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        NumbersInReverse();
                        break;
                    case "2":
                        ReverseCounting();
                        break;
                    case "3":
                        SquareOfEvenNumbers();
                        break;
                    case "4":
                        GuessMagicNumber();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void NumbersInReverse()
        {
            // Print out numbers from 5 to 1.

            Console.Clear();
            Console.WriteLine("PRINT NUMBERS IN REVERSE ORDER\n");

            // Enter your solution here

            for (int count1 = 5; count1 >= 1; count1 --)
            {
                Console.WriteLine(count1);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        static void ReverseCounting()
        {
            // Ask the user for a number between 1-20. Starting at the number given,
            // count backwards to 1 and print the numbers to the console.

            Console.Clear();
            Console.WriteLine("REVERSE COUNTING\n");

            // Enter your solution here

            Console.WriteLine("Enter a number between 1-20.");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            for (int count2 = 1; userNumber >= count2; userNumber --)
            {
                Console.WriteLine(userNumber);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SquareOfEvenNumbers()
        {
            // Print the squares (the number multiplied by itself) for even numbers between 1-9.

            Console.Clear();
            Console.WriteLine("PRINT THE SQUARE OF EVEN NUMBERS\n");

            // Enter your solution here

            int startNumber = 1;

            while (startNumber <= 9)
            {
                int squareNumber = startNumber * startNumber;
                startNumber++;
                {
                    if (startNumber % 2 == 0)
                    {
                        // Do nothing
                    }
                    else
                    {
                        Console.WriteLine(squareNumber);
                    }
                }
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void GuessMagicNumber()
        {
            // Write a console application that asks the user for an integer.
            // If that integer is evenly divisible by 3, then print “You Won!”.
            // If it isn’t, ask the user to “Try again.”
            // Keep asking them for a number (looping) until they win.

            Console.Clear();
            Console.WriteLine("GUESS THE MAGIC NUMBER\n");

            // Enter your solution here

            Console.WriteLine("Pick a number, any number!");
            int userNumber2 = Convert.ToInt32(Console.ReadLine());

            while (userNumber2 % 3 != 0)
            {
                Console.WriteLine("Try Again!");
                userNumber2 = Convert.ToInt32(Console.ReadLine());
                if (userNumber2 % 3 == 0)
                    Console.WriteLine("You Won!");
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}
