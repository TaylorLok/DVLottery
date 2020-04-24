using System;


namespace DVLotteryNumber
{

    //Main Class
    class Program
    {
        //Entry point Method
        static void Main(string[] args)
        {
            GetAppInfo();//get the Application info

            GetUser();//asking for user prompt


            while (true)
            {

                //set correct number
                //int correctNumber=8;

                //Create a new Random Object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //init guess var
                int guess = 0;

                Console.WriteLine("Please Enter a number from 1 to 100:");

                while (guess != correctNumber)
                {
                    String input = Console.ReadLine();

                    //making sure its a number not a letter
                    if (!int.TryParse(input, out guess))
                    {
                        //print error message
                        PrintColorMessage(ConsoleColor.Red, "Please enter a number NOT letters");

                        continue;

                    }

                    guess = Int32.Parse(input);

                    if (guess != correctNumber)
                    {
                       PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");
                    }

                }

                //out put success message
                
                PrintColorMessage(ConsoleColor.Green, "Congratulation! you have won DV Lottery 2020");


                //Ask if they want to continue playing
                Console.WriteLine("Play Again? [Y or N]");

                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y") 
                {
                    continue;
                }
                else if (answer == "N")
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
            String appName = "DV LOTTERY MACHINE";
            String appVersion = "2.0.0";
            String author = "Taylor Lokombe";

            //change displyaing text color
            Console.ForegroundColor = ConsoleColor.Yellow;


            Console.WriteLine("{0}: Version  {1} by {2}", appName, appVersion, author);
            Console.ResetColor();
        }
        static void GetUser() 
        {
            // Prompt a messages to user
            Console.WriteLine("Please Enter your name:");

            //user input
            String inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, welcome to DV Lottery...", inputName);
        }
        static void PrintColorMessage(ConsoleColor color,string message )
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

    }
}
