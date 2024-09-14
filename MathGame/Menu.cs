using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using MathGame.Models;
namespace MathGame
{
    internal class Menu
    {

        internal void NewGame(Game newGame, GameType type, DateTime date)
        {
            newGame.GameType = type;
            newGame.Date = date;
            ShowDifficulties(newGame);

        }
        internal void ShowMenu()
        {


            bool isGameOn = true;
            do
            {
                Game newGame = new Game();

                DateTime date = DateTime.Now;

                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine($"Hello. It's {date.DayOfWeek}, {date}");
                Console.WriteLine($"What mathmatical operation would you need?");
                Console.WriteLine("Choose one of the following:");
                Console.WriteLine($"V - View Game history\r\nA - Addition\r\nS - Substraction\r\nM - Multiplication\r\nD - Divison\r\nQ - Quit the program");
                Console.WriteLine("-------------------------");

                string? userInput = Console.ReadLine();
                GameEngines gameEngines = new GameEngines();
                switch (userInput.Trim().ToLower())
                {
                    case ("v"):
                        GameHistory.PrintGameHisotry();
                        break;
                    case ("a"):
     
                        NewGame(newGame, GameType.Addition, date);
                        gameEngines.Addition(newGame);
                        break;
                    case ("s"):
                        NewGame(newGame, GameType.Subtraction, date);
                        gameEngines.Addition(newGame);
                        break;
                    case ("m"):
                        NewGame(newGame, GameType.Multiplication, date);
                        gameEngines.Addition(newGame);

                        break;
                    case ("d"):
                        NewGame(newGame, GameType.Division, date);
                        gameEngines.Addition(newGame);
                        break;
                    case ("q"):
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            } while (isGameOn);

        }
        void ShowDifficulties(Game game)
        {
            Console.Clear();
            Console.WriteLine("-------------------------");
            Console.WriteLine($"Choose a level of difficulty");
            Console.WriteLine($"1 - Easy\r\n2 - Hard");
            Console.WriteLine("-------------------------");
            string? userInput = Console.ReadLine();

            while (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out _) || (userInput != "1" && userInput !="2"))
            {
                Console.Clear();
                Console.WriteLine("Invalid input, try again");

                Console.WriteLine($"Choose a level of difficulty");
                Console.WriteLine($"1 - Easy\r\n2 - Hard");

                userInput = Console.ReadLine();

            }
            switch (userInput)
            {
                case ("1"):
                    game.GameDifficulty = GameDifficulty.easy;
                    break;
                case ("2"):
                    game.GameDifficulty = GameDifficulty.hard;
                    break;

            }


        }

    }   

   
}
