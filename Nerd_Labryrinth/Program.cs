using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nerd_game
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game. How many players do you have? 2-8");

            string playerCountBad = Console.ReadLine();
            int playerCount = int.Parse(playerCountBad); string playersPluck = "1.5";
            //float playersLuck = float.Parse(playersPluck);
            //Console.WriteLine(playersLuck);
            int test = 0;

            switch (playerCount)
            {
                case 2:
                    Console.WriteLine("You have 2 players");
                    //do
                    //{
                    //    Console.WriteLine("gay :L");
                    //    test++;
                    //} while (test < 2);
                    Console.WriteLine("What's the Player's name?");
                    string playerName1 = Console.ReadLine();
                    Console.WriteLine("What's the Player's age?");
                    int playerAge1 = Convert.ToInt32(Console.ReadLine());
                    var rand = new Random();
                    double playerLuck1 = rand.Next(0, 10);
                    int playerRoll1 = rand.Next(1, 10);
                    int playerPoints = 10;



                    //Console.WriteLine($"You have {playerCount} players.");
                    Console.WriteLine($"Player name is {playerName1}.");
                    Console.WriteLine($"Player age is {playerAge1}.");
                    Console.WriteLine($"Player luck is 1.{playerLuck1}.");
                    Console.WriteLine($"Player roll is {playerRoll1}.");
                    Console.WriteLine($"Player points are {playerPoints}");
                    break;
                case 3:
                    Console.WriteLine("You have 3 players");

                    break;
                case 4:
                    Console.WriteLine("You have 4 players");

                    break;
                case 5:
                    Console.WriteLine("You have 5 players");

                    break;
                case 6:
                    Console.WriteLine("You have 6 players");

                    break;
                case 7:
                    Console.WriteLine("You have 7 players");

                    break;
                case 8:
                    Console.WriteLine("You have 8 players");

                    break;

                default:
                    Console.WriteLine("Restart!!!");
                    break;
            }



            Console.ReadKey();
            Player.certifiedHoodClassic();
            MiniGame.numGuess(10);
            Console.ReadKey();
        }

    }

    public class Player
    {
        public static void certifiedHoodClassic()
        {

            Console.WriteLine("What's the Player's name?");
            string playerName = Console.ReadLine();
            Console.WriteLine("What's the Player's age?");
            int playerAge = Convert.ToInt32(Console.ReadLine());
            var rand = new Random();
            double playerLuck = rand.Next(0, 10);
            int playerRoll = rand.Next(1, 10);




            //Console.WriteLine($"You have {playerCount} players.");
            Console.WriteLine($"Player name is {playerName}.");
            Console.WriteLine($"Player age is {playerAge}.");
            Console.WriteLine($"Player luck is 1.{playerLuck}.");
            Console.WriteLine($"Player roll is {playerRoll}.");
        }
    }

    public class MiniGame
    {
        public static void numGuess(int playerPoints)
        {
            Console.WriteLine("Ok now its time for the number guesser mini game. Player 1 Please pick a number");
            int correctNum = Convert.ToInt32(Console.ReadLine());

            while (correctNum != 77)
            {
                Console.WriteLine("Make another guess");
                correctNum = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("That is correct");

            if (correctNum != 77)
            {
                playerPoints--;
            }
            else
            {
                playerPoints++;
            }
        }
    }
}