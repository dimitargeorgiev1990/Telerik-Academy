using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Enigmanation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.SetIn(new System.IO.StreamReader(Console.OpenStandardInput(8192))); // for local tests big text pasted in the console

            string input = Console.ReadLine().Trim();

            decimal result = 0.0m; // last result to print
            decimal bracketsResult = 0.0m;

            char mathOperation = '\0';
            char tempMathOperation = '\0';

            bool isInBrackets = false;

            int i = 0;
            while (input[i] != '=')
            {
                if (input[i] == '(')
                {
                    isInBrackets = true;
                }
                else if (input[i] == ')')
                {
                    isInBrackets = false;
                    if (mathOperation != '\0')
                    {
                        switch (mathOperation)
                        {
                            case '+': result += bracketsResult;
                                break;
                            case '-': result -= bracketsResult;
                                break;
                            case '*': result *= bracketsResult;
                                break;
                            case '%': result %= bracketsResult;
                                break;
                            case '/': result /= bracketsResult;
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        result = bracketsResult;

                    }
                    tempMathOperation = '\0'; // if you dont have this -> 52 / 100

                }
                else if (!char.IsDigit(input[i]) && !isInBrackets)
                {
                    mathOperation = input[i];
                }
                else if (!char.IsDigit(input[i]) && isInBrackets)
                {
                    tempMathOperation = input[i];
                }
                else // input[i] is diggit
                {
                    if (isInBrackets)
                    {
                        if (tempMathOperation == '\0')
                        {
                            bracketsResult = int.Parse(input[i].ToString());
                        }
                        else
                        {
                            switch (tempMathOperation)
                            {
                                case '+': bracketsResult += decimal.Parse(input[i].ToString());
                                    break;
                                case '-': bracketsResult -= decimal.Parse(input[i].ToString());
                                    break;
                                case '*': bracketsResult *= decimal.Parse(input[i].ToString());
                                    break;
                                case '%': bracketsResult %= decimal.Parse(input[i].ToString());
                                    break;
                                case '/': bracketsResult /= decimal.Parse(input[i].ToString());
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                    else
                    {
                        if (mathOperation == '\0')
                        {
                            result = int.Parse(input[i].ToString());
                        }
                        else
                        {
                            switch (mathOperation)
                            {
                                case '+': result += decimal.Parse(input[i].ToString());
                                    break;
                                case '-': result -= decimal.Parse(input[i].ToString());
                                    break;
                                case '*': result *= decimal.Parse(input[i].ToString());
                                    break;
                                case '%': result %= decimal.Parse(input[i].ToString());
                                    break;
                                case '/': result /= decimal.Parse(input[i].ToString());
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                i++;
            }
            Console.WriteLine("{0:F2}", result);
        }
    }
}
