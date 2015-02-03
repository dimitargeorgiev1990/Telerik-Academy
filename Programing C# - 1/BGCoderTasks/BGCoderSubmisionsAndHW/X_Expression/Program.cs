using System;

namespace X_Expression
{
    class Program
    {
        static char operation = '\0';
        static decimal currentResult;
        static decimal tempResFromBrackets;
        static char tempOperation = '\0';

        static void Main(string[] args)
        {
            string inputExp = Console.ReadLine().Trim();
            if (inputExp[0] == '(')
            {
              inputExp = inputExp.Remove(0, 1);
              inputExp = inputExp.Remove(inputExp.IndexOf(')'), 1);
            }
            inputExp = inputExp.Substring(0, inputExp.Length - 1);
            currentResult = decimal.Parse(inputExp[0].ToString());
            operation = inputExp[1];

            for (int i = 2; i < inputExp.Length; i++)
            {
                if (inputExp[i] == ')')
                    continue;
                if (char.IsDigit(inputExp[i]))
                {
                    PerformOperation(int.Parse(inputExp[i].ToString()), false);
                }
                else if (inputExp[i] == '(')
                {
                    string tempExp = inputExp.Substring(i + 1, inputExp.IndexOf(')', i + 1) - i);
                    tempResFromBrackets = decimal.Parse(tempExp[0].ToString());
                    tempOperation = tempExp[1];
                    i += 2;
                    for (int j = 2; j < tempExp.Length; j++, i++)
                    {
                        if (char.IsDigit(tempExp[j])) PerformOperation(int.Parse(tempExp[j].ToString()), true);
                        else tempOperation = tempExp[j];
                    }

                    PerformOperation(tempResFromBrackets, false);
                }
                else
                {
                    operation = inputExp[i];
                }

            }
            Console.WriteLine(currentResult.ToString("F2"));

        }

        static void PerformOperation(decimal param, bool isTempOperation)
        {
            if (!isTempOperation)
                switch (operation)
                {
                    case '-': currentResult -= param;
                        break;
                    case '+': currentResult += param;
                        break;
                    case '*': currentResult *= param;
                        break;
                    case '/': currentResult /= param;
                        break;
                    default:
                        break;
                }
            else
                switch (tempOperation)
                {
                    case '-': tempResFromBrackets -= param;
                        break;
                    case '+': tempResFromBrackets += param;
                        break;
                    case '*': tempResFromBrackets *= param;
                        break;
                    case '/': tempResFromBrackets /= param;
                        break;
                    default:
                        break;
                }
        }

    }
}