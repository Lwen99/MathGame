using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathGame.Models;
namespace MathGame
{
    internal static class GameHistory
    {
        static List<Game> games = new List<Game>();

        internal static void Add(Game game) {

            games.Add(game);
            
        }

        internal static void PrintGameHisotry()
        {
            Console.Clear();
            if(games.Count <= 0)
            {
                Console.WriteLine("No games played yet");
            }
            foreach (Game game in games)
            {
                Console.WriteLine($"{game.Date} {game.GameType} {game.GameDifficulty} {game.Score}");
            }
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
        }
    }
}
