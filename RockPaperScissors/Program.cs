﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;

            while (playAgain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter ROCK, PAPER or SCISSORS: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                random.Next(1, 4);
                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                    case 2:
                        computer = "PAPER";
                        break;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player: " + player);
                Console.WriteLine("Computer: " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a DRAW!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You LOSE!");
                        }
                        else
                        {
                            Console.WriteLine("You WIN!");
                        }
                        break;

                    case "PAPER":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You WIN!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a DRAW!");
                        }
                        else
                        {
                            Console.WriteLine("You LOSE!");
                        }
                        break;

                    case "SCISSORS":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("You LOSE!");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You WIN");
                        }
                        else
                        {
                            Console.WriteLine("It's a DRAW");
                        }
                        break;
                }
                Console.Write("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
            Console.WriteLine("Thanks for playing!");
        }
    }
}
