using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Card_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfGames = int.Parse(Console.ReadLine());
            Queue<string> firstPlayerCards = new Queue<string>();
            Queue<string> secondPlayerCards = new Queue<string>();
            BigInteger firstPlayerPoints = 0;
            BigInteger secondPlayerPoints = 0;
            int firstPlayerWonGames = 0;
            int secondPlayerWonGames = 0;

            for (int i = 0; i < numberOfGames; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    firstPlayerCards.Enqueue(Console.ReadLine());
                }

                for (int k = 0; k < 3; k++)
                {
                    secondPlayerCards.Enqueue(Console.ReadLine());
                }
            }

            int firstPlayerTempPoints = 0;
            int secondPlayerTempPoints = 0;
            bool firstHasXCard = false;
            bool secondHasXCard = false;
            int hand = 0;
            while (firstPlayerCards.Count > 0)
            {
                hand++;
                string firstPlayerCurrentCard = firstPlayerCards.Dequeue();
                string secondPlayerCurrentCard = secondPlayerCards.Dequeue();

                switch (firstPlayerCurrentCard)
                {
                    case "2": firstPlayerTempPoints += 10;
                        break;
                    case "3": firstPlayerTempPoints += 9;
                        break;
                    case "4": firstPlayerTempPoints += 8;
                        break;
                    case "5": firstPlayerTempPoints += 7;
                        break;
                    case "6": firstPlayerTempPoints += 6;
                        break;
                    case "7": firstPlayerTempPoints += 5;
                        break;
                    case "8": firstPlayerTempPoints += 4;
                        break;
                    case "9": firstPlayerTempPoints += 3;
                        break;
                    case "10": firstPlayerTempPoints += 2;
                        break;
                    case "J": firstPlayerTempPoints += 11;
                        break;
                    case "Q": firstPlayerTempPoints += 12;
                        break;
                    case "K": firstPlayerTempPoints += 13;
                        break;
                    case "A": firstPlayerTempPoints += 1;
                        break;
                    case "Z": firstPlayerPoints *= 2;
                        break;
                    case "Y": firstPlayerPoints -= 200;
                        break;
                    case "X": firstHasXCard = true;
                        break;
                    default:
                        break;
                }

                switch (secondPlayerCurrentCard)
                {
                    case "2": secondPlayerTempPoints += 10;
                        break;
                    case "3": secondPlayerTempPoints += 9;
                        break;
                    case "4": secondPlayerTempPoints += 8;
                        break;
                    case "5": secondPlayerTempPoints += 7;
                        break;
                    case "6": secondPlayerTempPoints += 6;
                        break;
                    case "7": secondPlayerTempPoints += 5;
                        break;
                    case "8": secondPlayerTempPoints += 4;
                        break;
                    case "9": secondPlayerTempPoints += 3;
                        break;
                    case "10": secondPlayerTempPoints += 2;
                        break;
                    case "J": secondPlayerTempPoints += 11;
                        break;
                    case "Q": secondPlayerTempPoints += 12;
                        break;
                    case "K": secondPlayerTempPoints += 13;
                        break;
                    case "A": secondPlayerTempPoints += 1;
                        break;
                    case "Z": secondPlayerPoints *= 2;
                        break;
                    case "Y": secondPlayerPoints -= 200;
                        break;
                    case "X": secondHasXCard = true;
                        break;
                    default:
                        break;
                }

                if (hand == 3)
                {
                    hand = 0;
                    if (firstHasXCard && !secondHasXCard)
                    {
                        Console.WriteLine("X card drawn! Player one wins the match!");
                        return;
                    }
                    else if (!firstHasXCard && secondHasXCard)
                    {
                        Console.WriteLine("X card drawn! Player two wins the match!");
                        return;

                    }
                    else if (firstHasXCard && secondHasXCard)
                    {
                        secondPlayerPoints += 50;
                        firstPlayerPoints += 50;
                    }
                    
                    if (firstPlayerTempPoints > secondPlayerTempPoints)
                    {
                        firstPlayerPoints += firstPlayerTempPoints;
                        firstPlayerWonGames++;
                    }
                    else if (secondPlayerTempPoints > firstPlayerTempPoints)
                    {
                        secondPlayerPoints += secondPlayerTempPoints;
                        secondPlayerWonGames++;
                    }
                    else
                    {
                        // equal points nothing to do
                    }
                    firstPlayerTempPoints = 0;
                    secondPlayerTempPoints = 0;
                    firstHasXCard = false;
                    secondHasXCard = false;
                }
            }

            if (firstPlayerPoints > secondPlayerPoints)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: " + firstPlayerPoints);
                Console.WriteLine("Games won: " + firstPlayerWonGames);
            }
            else if (firstPlayerPoints < secondPlayerPoints)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: " + secondPlayerPoints);
                Console.WriteLine("Games won: " + secondPlayerWonGames);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: " + secondPlayerPoints);
            }
        }
    }
}