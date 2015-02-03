using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Basic
{
    class Program
    {
        static Dictionary<int, string> commands = new Dictionary<int, string>();
        static List<int> commandsOrder = new List<int>();

        static string variables = "VWXYZ";
        static void Main()
        {
            string command = Console.ReadLine().Trim();
            string[] commandSplited = command.Split(new char[] { ' ' }, 
                StringSplitOptions.RemoveEmptyEntries);
            commandsOrder.Add(int.Parse(commandSplited[0]));
            commands.Add(int.Parse(commandSplited[0]), command);
            while (command != "RUN")
            {
                command = Console.ReadLine().Trim();
                commandSplited = command.Split(new char[] { ' ' },
                    StringSplitOptions.RemoveEmptyEntries);
                commandsOrder.Add(int.Parse(commandSplited[0]));
                commands.Add(int.Parse(commandSplited[0]), command);
            }

            commandsOrder.Sort();
            throw new NotImplementedException();
            foreach (int key in commandsOrder)
            {
                switch (commands[key].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1][0])
                {
                    case ' ':
                        break;
                    default:
                        break;
                }
            }



        }
    }
}
