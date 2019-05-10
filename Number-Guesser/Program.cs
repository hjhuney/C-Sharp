using System;

// namespace
namespace NumberGuesser
{
    // mainclass
    class Program
    {
        // entry point for application
        // "void" is return value; we won't have one in this instance which is why we use "void"
        static void Main(string[] args)
        {

            GetAppInfo();

            // change text color
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            // ask users name
            Console.WriteLine("What is your name?");

            // reset text color back to default
            Console.ResetColor();

            // get user input
            string userName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game ...", userName);

            while (true) {

                // create new random object
                Random random = new Random();

                // init correct number
                int correctNumber = random.Next(1, 11);

                // init guess var
                int guess = 0;

                Console.WriteLine("Guess a number betweeen 1 and 10");

                while (guess != correctNumber)
                {
                    // get user input
                    string inputNum = Console.ReadLine();

                    // make sure user input is a number
                    if (!int.TryParse(inputNum, out guess)) {

                        // change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // tell user its not a number
                        Console.WriteLine("this is an invalid number; please try again");

                        // reset text color
                        Console.ResetColor();

                        // keep going
                        continue;

                    }

                    // cast to int and put in guess
                    guess = Int32.Parse(inputNum);

                    // match guess to correct number
                    if (guess != correctNumber)
                    {
                        // change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        // write out appp info
                        Console.WriteLine("wrong number, please try again.");

                        // reset text color
                        Console.ResetColor();

                    }
                }

                // output success message

                // change text color
                Console.ForegroundColor = ConsoleColor.Yellow;

                // tell user its right number
                Console.WriteLine("You are correct!");

                // reset text color
                Console.ResetColor();

                // ask to play again
                Console.WriteLine("Would you like to play again? [Y or N]");

                // get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }

                else if (answer=="N")
                {
                    return;
                }

                else
                {
                    return;
                }


            }

        }

        static void GetAppInfo()
        {
            // set app variables
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Jake Huneycutt";

            // change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;

            // write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // reset text color back to default
            Console.ResetColor();
        }
    }
}
