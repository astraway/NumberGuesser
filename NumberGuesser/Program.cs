using System;
// Namespace
namespace NumberGuesser
{   // Main class
    class Program
    {
        static void Main(string[] args)
        {
            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuther = "Eric Jurotich";
            //change text color
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuther);
            //Reset Text color 
            Console.ResetColor();

            Console.WriteLine("What is your name?");
            string usrName = Console.ReadLine();

            Console.WriteLine("Hello {0}, lets play a game", usrName);

            //init correct number
            int correctNumber = 7;

            //init guess var
            int guess = 0;


            // Ask user for number
            Console.WriteLine("Guess a number between 1 and 10");


            while (guess != correctNumber) {
                //get usersinput
                string input = Console.ReadLine();

                //Cast to int and put in guess var
                guess = Int32.Parse(input);
                    
                if (guess != correctNumber)
                {
                    //change text color
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong number please try again!");
                    //Reset Text color 
                    Console.ResetColor();

                }

              
            
            }



        }
    }
}
