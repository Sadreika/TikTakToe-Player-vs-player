using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public class Player
    {
       private string PlayerSymbol;

       public Player(string name)
       {
            PlayerSymbol = name;
       }

       public string returnPlayerSymbol()
       {
            return PlayerSymbol;
       }
    }
}
