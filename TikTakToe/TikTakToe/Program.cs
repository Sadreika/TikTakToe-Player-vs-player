using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Game startGame = new Game();
                Console.Clear();
                Console.WriteLine("1. Player vs player" + "\n" + "2. Player vs pc" + "\n" + "Other key - Exit");
                string userInput = Console.ReadLine();
                if (userInput.Equals("1"))
                {
                    Console.Clear();
                    startGame.startGame();
                }
                else if (userInput.Equals("2"))
                {
                    Console.Clear();
                    startGame.startGameVsPc();
                }
                else
                {
                    Console.WriteLine("Good Bye");
                    break;
                }
                Console.ReadLine();
            }
        }
    }
}
