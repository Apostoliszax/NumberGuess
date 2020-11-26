using System;


namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GetAppInfo();

            GreetUser();
            

            while (true)
            {
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                int guess = 0;

                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;


                        Console.WriteLine("Please enter an actual number:");

                        //reset text color
                        Console.ResetColor();

                        continue;
                    }



                    guess = Int32.Parse(input);


                    if (guess != correctNumber)
                    {
                        isNumber();
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;


                Console.WriteLine("You are correct!");

                //reset text color
                Console.ResetColor();

                

                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
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
            string appName = "Number Guess";
            string appVersion = "1.0.0";
            string appAuthor = "Apostolis Zacharakis";

            Console.ForegroundColor = ConsoleColor.Green;


            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //reset text color
            Console.ResetColor();
        }

        static void GreetUser()
        {

            Console.WriteLine("What is your name?");
            String inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);
        }

        static void isNumber()
        {
            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("Wrong Number, please try again:");

            //reset text color
            Console.ResetColor();
        }
    }
}
    