using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace DwarfConsoleGame
{
    class Program
    {
        static string[] obsticles = new string[] { "^", "@", "*", "&", "-", "+", "%", "#" };
        static Obsticle dwarf = new Obsticle() { Value = "(0)", X = Console.WindowWidth / 2, Y = Console.WindowHeight };
        static List<Obsticle> obsticlesList = new List<Obsticle>();
        static Random rand = new Random();

        static void Main(string[] args)
        {
            Console.Title = "Dwarf Game";
            Console.CursorVisible = false;
            // Console.SetBufferSize(Console.WindowHeight - 1, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (true)
            {               
                Thread.Sleep(150);
                Console.Clear();
                
               
                // add new rock
                obsticlesList.Add(new Obsticle() { Value = obsticles[rand.Next(0, obsticles.Length)], Y = 0, X = rand.Next(0, Console.WindowWidth) });

                for (int i = 0; i < obsticlesList.Count; i++)
                {
                    obsticlesList[i].Y++;
                    if (obsticlesList[i].Y > Console.WindowHeight)
                    {
                        obsticlesList.RemoveAt(i);
                        continue;
                    }

                    if (obsticlesList[i].Y == dwarf.Y && (obsticlesList[i].X == dwarf.X || obsticlesList[i].X == dwarf.X + 2 || obsticlesList[i].X == dwarf.X + 1))
                    {
                        Console.Clear();
                        Console.SetCursorPosition(Console.WindowWidth / 2 ,Console.WindowHeight / 2);
                        Console.WriteLine("GAME OVER");
                        Console.ReadKey();
                        return;
                    }
                    Console.SetCursorPosition(obsticlesList[i].X, obsticlesList[i].Y);
                    Console.Write(obsticlesList[i].Value);
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyPressed = Console.ReadKey();
                    if (keyPressed.Key == ConsoleKey.LeftArrow)
                    {
                        dwarf.X -=2;
                    }
                    else if (keyPressed.Key == ConsoleKey.RightArrow)
                    {
                        dwarf.X += 2;
                    }

                }
                // write dwarf
                Console.SetCursorPosition(dwarf.X, dwarf.Y);
                Console.Write(dwarf.Value);
            }
        }

        static void CheckMoveDwarf() 
        {
            
        }
    }
    class Obsticle 
    {
        public string Value { get; set; }

        public int X { get; set; }

        public int Y { get; set; }
    }
}
