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
            Game startGame = new Game();
            startGame.startGame();
            Console.ReadLine();
        }
    }
}
