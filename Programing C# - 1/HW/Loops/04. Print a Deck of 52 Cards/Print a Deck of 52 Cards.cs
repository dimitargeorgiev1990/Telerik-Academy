using System;

/*Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
    The card faces should start from 2 to A.
    Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.*/

class PrintDeckOf52Cards
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
            string card = "";
   
            switch (i)
            { 
                case 11:
                    card = "J";
                    break;
                case 12:
                    card = "Q";
                    break;
                case 13:
                    card = "K";
                    break;
                case 14:
                    card = "A";
                    break;
                default: card = i.ToString();
                    break;
            }
            for (int j = 1; j < 5; j++) 
            {
                char currentCardSimbol = (char)('\x02' + j);
                Console.WriteLine(card + " " + currentCardSimbol);
            }
        }
    }
}
