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
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        //wrong 
                        Console.WriteLine("You did not input a number, please enter a number 1-10");
                        //Reset Text color 
                        Console.ResetColor();

                        continue;

                    }
                    //Cast to int and put in guess var
                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                        //change text color
                        Console.ForegroundColor = ConsoleColor.Red;
                        //wrong 
                        Console.WriteLine("Wrong number please try again!");
                        //Reset Text color 
                        Console.ResetColor();

                    }



                }
                //change text color
                Console.ForegroundColor = ConsoleColor.Magenta;
                //out put success
                Console.WriteLine("You guessed correctly!!!!!");
                //Reset Text color 
                Console.ResetColor();

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
    }
}
