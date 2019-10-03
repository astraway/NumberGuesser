using System;
// Namespace
namespace NumberGuesser
{   // Main class
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();


            Greeting();

            while (true)
            {
                

                //create a random object
                Random random = new Random();

                //init correct number
                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;


                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");


                while (guess != correctNumber)
                {
                    //get usersinput
                    string input = Console.ReadLine();
                    // test that this is a num
                    if (!int.TryParse(input, out guess))
                    {
                        PrintColor(ConsoleColor.Red, "You did not input a number, please enter a number 1-10");

                        continue;

                    }
                    //Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {

                        PrintColor(ConsoleColor.Red, "Wrong number please try again!");

                    }



                }

                PrintColor(ConsoleColor.Magenta, "You guessed correctly!!!!!");
                
                
                // ask to play again
                Console.WriteLine("Play again ? [Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
            }
        }

        static void GetAppInfo() {

            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Eric Jurotich";
            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther);
            //Reset Text color 
            Console.ResetColor();

        }

        static void Greeting() {

            Console.WriteLine("What is your name?");
            string usrName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", usrName);

        }

        static void PrintColor(ConsoleColor color, string message) {

            //change text color
            Console.ForegroundColor = color;
            //wrong 
            Console.WriteLine(message);
            //Reset Text color 
            Console.ResetColor();


        }
    }
}
