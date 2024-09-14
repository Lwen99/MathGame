using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.Models;

internal class Game
{
    public DateTime Date { get; set; }
    public string Score { get; set; }

    public GameType GameType { get; set; }

    public GameDifficulty GameDifficulty { get; set; }
}

internal enum GameType
{
    Addition,
    Subtraction,
    Multiplication,
    Division,
}

internal enum GameDifficulty
{
    easy,
    hard,
}


