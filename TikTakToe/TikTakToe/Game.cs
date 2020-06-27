using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTakToe
{
    public class Game : Board
    {
        private bool gameNotEnded = true;
        private Board boardObject = new Board();

        public void startGame()
        {
            boardObject.fillingBoardWithEmptyValues();
            Player player1 = new Player("X");
            Player player2 = new Player("O");
            int enteringValue = 0;
            while (gameNotEnded)
            {
                boardObject.showBoard();
                Console.WriteLine("Player 1 turn");
                do
                {
                    enteringValue = boardObject.fillOne(player1.returnPlayerSymbol(), Int16.Parse(turn(player1)));
                } while (enteringValue == 0);
                boardObject.showBoard();
                if (boardObject.checkingIfGameIsEnded() == 1)
                {
                    Console.WriteLine("Player 1 won");
                    break;
                }
                if(boardObject.checkingHowMuchEmptyWindows() == 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                Console.Clear();
                boardObject.showBoard();
                Console.WriteLine("Player 2 turn");
                do
                {
                    enteringValue = boardObject.fillOne(player2.returnPlayerSymbol(), Int16.Parse(turn(player2)));
                } while (enteringValue == 0);
                boardObject.showBoard();
                boardObject.checkingIfGameIsEnded();
                if (boardObject.checkingIfGameIsEnded() == 1)
                {
                    Console.WriteLine("Player 2 won");
                    break;
                }
                if (boardObject.checkingHowMuchEmptyWindows() == 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                Console.Clear();
            }
        }

        public void startGameVsPc()
        {
            boardObject.fillingBoardWithEmptyValues();
            Player player1 = new Player("X");
            Player player2 = new Player("O");
            int enteringValue = 0;
            while (gameNotEnded)
            {
                boardObject.showBoard();
                Console.WriteLine("Player 1 turn");
                do
                {
                    enteringValue = boardObject.fillOne(player1.returnPlayerSymbol(), Int16.Parse(turn(player1)));
                } while (enteringValue == 0);
                boardObject.showBoard();
                if (boardObject.checkingIfGameIsEnded() == 1)
                {
                    Console.WriteLine("Player 1 won");
                    break;
                }
                if (boardObject.checkingHowMuchEmptyWindows() == 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                Console.Clear();
                boardObject.showBoard();
                Console.WriteLine("PC turn");

                TikTakToeAI.Program pcObject = new TikTakToeAI.Program();
                int whereToGoValue = pcObject.whereToGo(boardObject.boardList, player2.returnPlayerSymbol(), player1.returnPlayerSymbol());
                
                boardObject.fillOnePC(player2.returnPlayerSymbol(), whereToGoValue);
                
                boardObject.showBoard();
                boardObject.checkingIfGameIsEnded();

                if (boardObject.checkingIfGameIsEnded() == 1)
                {
                    Console.WriteLine("PC won");
                    break;
                }
                if (boardObject.checkingHowMuchEmptyWindows() == 0)
                {
                    Console.WriteLine("Draw");
                    break;
                }
                Console.Clear();
            }
        }

        public string turn(Player user)
        { 
            string valueFromUser = askingForInput();
            int isGivenValueValid = checkingIfValueIsInt(valueFromUser);
            if (isGivenValueValid == 0)
            {
                while (isGivenValueValid == 0)
                {
                    valueFromUser = askingForInput();
                    isGivenValueValid = checkingIfValueIsInt(valueFromUser);
                }
            }
            return valueFromUser;
        }

        public void turnPC()
        {
            for(int i = 0; i < boardObject.boardList.Count; i++)
            {
                Console.WriteLine("elements" + i + boardObject.boardList[i]);
            }
        }

        public string askingForInput()
        {
            Console.WriteLine("Enter elements number");
            string input = Console.ReadLine();
            return input;
        }

        public int checkingIfValueIsInt(string valueFromUser)
        {
            try
            {
                int value = Int16.Parse(valueFromUser);
                if(value < 1 || value > 9)
                {
                    return 0;
                }
                else
                {   
                    return 1;
                }
            } catch (Exception)
            {
                return 0;
            }
        }
    }
}
