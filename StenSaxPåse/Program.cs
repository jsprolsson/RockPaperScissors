using System;

namespace StenSaxPåse
{
    class Program
    {
        static void Main(string[] args)
        {

            RockPaperScissors.Play();

        }

        class RockPaperScissors
        {

            public static void Play()
            {
                Random random = new Random();
                int computerScore = 0;
                int userScore = 0;
                string userChoice;
                int randomNumber = random.Next(1, 3);

                Console.WriteLine("Best of 1, 3, 5 or 7? ");
                int bestOfNumber = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"Computer score: {computerScore}");
                    Console.WriteLine($"Player score: {userScore}");
                    Console.WriteLine("--------------------------------------");
                    Console.Write("STEN, SAX eller PÅSE: ");
                    userChoice = Console.ReadLine();
                    string userChoiceUpper = userChoice.ToUpper();

                    if (randomNumber == 1)
                    {
                        Console.WriteLine("Computer plays STEN.");

                        if (userChoiceUpper == "STEN")
                        {
                            Console.WriteLine("It's a tie!\n No points given.");
                        }
                        else if (userChoiceUpper == "SAX")
                        {
                            Console.WriteLine("Player lose!");
                            computerScore++;
                        }
                        else if (userChoiceUpper == "PÅSE")
                        {
                            Console.WriteLine("Player win!");
                            userScore++;
                        }

                    }
                    else if (randomNumber == 2)
                    {

                        Console.WriteLine("Computer plays SAX.");

                        if (userChoiceUpper == "STEN")
                        {
                            Console.WriteLine("Player wins!");
                            userScore++;
                        }
                        else if (userChoiceUpper == "SAX")
                        {
                            Console.WriteLine("It's a tie!\nNo point given.");
                        }
                        else if (userChoiceUpper == "PÅSE")
                        {
                            Console.WriteLine("Computer win!");
                            computerScore++;
                        }

                    }
                    else if (randomNumber == 3)
                    {
                        Console.WriteLine("Computer plays PÅSE.");

                        if (userChoiceUpper == "STEN")
                        {
                            Console.WriteLine("Computer win!");
                            computerScore++;
                        }
                        else if (userChoiceUpper == "SAX")
                        {
                            Console.WriteLine("Player win!");
                            userScore++;
                        }
                        else if (userChoiceUpper == "PÅSE")
                        {
                            Console.WriteLine("It's a tie!\n No points given.");
                        }

                    }

                    Console.ReadKey();
                    Console.Clear();


                } while (computerScore != bestOfNumber && userScore != bestOfNumber);
            }




        }
    }
}
