using System;
using System.Linq;
using System.Collections.Generic;

namespace BGCoderSubmissions
{
    class Program
    {
        static int numberOfCommands;
        static int rowsCount = 4;
        static int colsCount = 8;
        static int score = 0;
        static int currentRow = 0;
        static int currentPieceScore = 0;
        static bool[] currentPiece = new bool[8];

        static bool[,] gameField = new bool[4, 8];
        static bool isGameOver = false;
        // low 8 bits - shape; hight 24 bits - score; shift left/right; shift not affect low 8 bits(shape not influence on the score)
        // if shift command leaves field comand - ignored -> peace go down; piece cant shift on final row
        // if peace is landed alredy have to ignore comands
        // peace reaches final pos:
        // score = all 1 bits including height bits; if the row where it reaches final is only with '1' row.clear
        // all rows above it are shifted down by one position and score is * 10
        // game end: when top row contains atleast one bit ? || input has expired
        static void Main()
        {
            numberOfCommands = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfCommands; i++)
            {
                if (isGameOver)
                {
                    break;
                }
                for (int j = 0; j < 4; j++)
                {

                    string input = Console.ReadLine();
                    int number = -1;
                    
                    if (int.TryParse(input, out number))
                    {
                        GetCurrentPiece(number);
                    }
                    else
                    {
                        if (currentRow < rowsCount - 1)
                        {
                            ParseCommand(input);  
                        }                       
                    }
                    if (isGameOver)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(score + currentPieceScore);
        }
        static void ParseCommand(string command) 
        {
            switch (command)
            {
                case "D": MoveDown(); IsGameOver();
                    break;
                case "L": MoveLeft(); IsGameOver();
                    break;
                case "R": MoveRight(); IsGameOver();
                    break;
                case "S": Console.WriteLine("Score: "+ score + " CurrentScore: " + currentPieceScore);
                    break;
                default: CurrentStateTest();
                    break;
            }
        }
        static void GetCurrentPiece(int input) 
        {
            score += currentPieceScore;
            currentPieceScore = 0;
            currentPiece = new bool[colsCount];
            string inputToBinStr = Convert.ToString(input, 2);
            while (inputToBinStr.Length < 8)
            {
                inputToBinStr = "0" + inputToBinStr;
            }
            currentPieceScore = inputToBinStr.Count(x => x == '1');
            string currentPieceToString = inputToBinStr.Substring(0, 8);
            currentPieceToString.Reverse();
            for (int i = 0; i < currentPiece.Length; i++)
            {
                if (currentPieceToString[i] == '1')
                {
                    currentPiece[i] = true;
                }
            }
            MoveInField();
          
        }         
        private static void MoveInField()
        {
            currentRow = 0;
            for (int i = 0; i < colsCount; i++)
            {
                if (currentPiece[i])
                {
                    gameField[0, i] = true;
                }
            }
        }

        private static void MoveDown()
        {
            if (CanGoDown())
            {
                currentRow++;
                for (int i = 0; i < colsCount; i++)
                {
                    if (currentPiece[i])
                    {
                        gameField[currentRow, i] = true;
                        gameField[currentRow - 1, i] = false;
                    }
                }
                CheckAndClearFullRow();
            }
        }
        private static void MoveLeft()
        {
            if (CanGoLeft())
            {
                for (int i = colsCount-1; i >= 0; i--)
                {
                    if (currentPiece[i])
                    {
                        var count = currentPiece.Count(x => x == true);
                        currentPiece[i] = false;
                        currentPiece[i - count] = true;
                        gameField[currentRow, i] = false;
                        gameField[currentRow, i - count] = true;
                        MoveDown();
                        return;
                    }
                }
                MoveDown();
            }
            else 
            {
                MoveDown();
            }
        }
        private static void MoveRight()
        {
            if (CanGoRight())
            {
                for (int i = 0; i < colsCount; i++)
                {                 
                    if (currentPiece[i])
                    {
                        var count = currentPiece.Count(x => x == true);
                        currentPiece[i] = false;
                        currentPiece[count + i] = true;
                        gameField[currentRow, i] = false;
                        gameField[currentRow, count+i] = true;
                        MoveDown();
                        return;
                    }
                }
            }
            else
            {
                MoveDown();
            }
        }

        private static bool CanGoDown() 
        {
            if (currentRow < rowsCount - 1)
            {
                for (int i = 0; i < colsCount; i++)
                {
                    if (currentPiece[i] && gameField[currentRow +1, i])
                    {
                        return false;
                    }
                }
                return true;
            }

            return false;
        }       
        private static bool CanGoLeft()
        {
            for (int i = 0; i < colsCount; i++)
            {
                if (currentPiece[i])
                {
                    if (i > 0 && !gameField[currentRow, i - 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
        private static bool CanGoRight()
        {
            for (int i = colsCount - 1; i >= 0; i--)
            {
                if (currentPiece[i])
                {
                    if (i <= 6 && !gameField[currentRow, i + 1])
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
              
            }
            return false;
        }

        private static void  IsGameOver()
        {
            for (int i = 0; i < colsCount; i++)
            {
                if (gameField[0, i])
                {
                    isGameOver = true;
                    return;
                }
            }            
        }
        private static void CheckAndClearFullRow() 
        {
            // check to clear row?
            bool hasToClearCurRow = true;
            for (int i = 0; i < colsCount; i++)
            {
                if (!gameField[currentRow, i])
                {
                    hasToClearCurRow = false;
                    break;
                }
            }

            // clear!; todo: move down other rows
            if (hasToClearCurRow)
            {
                currentPieceScore *= 10;
                for (int i = 0; i < colsCount; i++)
                {
                    gameField[currentRow, i] = false;
                }
            }
        }

        private static void CurrentStateTest() 
        {
            for (int i = 0; i < rowsCount; i++)
            {
                for (int j = 0; j < colsCount; j++)
                {
                    if (gameField[i,j])
                    {
                        Console.Write("1 ");
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
