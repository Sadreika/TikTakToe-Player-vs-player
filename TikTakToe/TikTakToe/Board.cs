using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public class Board
    {
        public List<string> boardList = new List<String>();

        public void fillingBoardWithEmptyValues()
        {
            for(int i = 0; i < 9; i++)
            {
                boardList.Add(" ");
            }
        }

        public int fillOne(string symbol, int whichOneToFill)
        {
            if(boardList[whichOneToFill - 1].Equals(" "))
            {
                boardList[whichOneToFill - 1] = symbol;
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int fillOnePC(string symbol, int whichOneToFill)
        {
            if (boardList[whichOneToFill].Equals(" "))
            {
                boardList[whichOneToFill] = symbol;
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void showBoard()
        {
            Console.WriteLine(boardList[0] + "|" + boardList[1] + "|" + boardList[2] + "\n" +
                              boardList[3] + "|" + boardList[4] + "|" + boardList[5] + "\n" +
                              boardList[6] + "|" + boardList[7] + "|" + boardList[8]);
        }

        public int checkingIfGameIsEnded()
        {
            if((boardList[0] == boardList[1] && boardList[1] == boardList[2] && !boardList[0].Equals(" ")) ||
               (boardList[3] == boardList[4] && boardList[4] == boardList[5] && !boardList[3].Equals(" ")) ||
               (boardList[6] == boardList[7] && boardList[7] == boardList[8] && !boardList[6].Equals(" ")) ||

               (boardList[0] == boardList[3] && boardList[3] == boardList[6] && !boardList[0].Equals(" ")) ||
               (boardList[1] == boardList[4] && boardList[4] == boardList[7] && !boardList[1].Equals(" ")) |
               (boardList[2] == boardList[5] && boardList[5] == boardList[8] && !boardList[2].Equals(" ")) ||

               (boardList[0] == boardList[4] && boardList[4] == boardList[8] && !boardList[0].Equals(" ")) ||
               (boardList[2] == boardList[4] && boardList[4] == boardList[6] && !boardList[2].Equals(" ")))
            {
                
                return 1;
            }
            else
            {
                return 0;
            }

        }

        public int checkingHowMuchEmptyWindows()
        {
            int counting = 0;
            for(int i = 0; i < boardList.Count; i++)
            {
                if(boardList[i].Equals(" "))
                {
                    counting = counting + 1;
                }
            }
            return counting;
        }
    }
}
