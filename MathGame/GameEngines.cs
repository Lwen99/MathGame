using MathGame.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace MathGame
{
    internal class GameEngines
    {
        Random random1 = new Random();

        void OutPutScore(Game game, int score)
        {
            decimal result = ((decimal)score / 5);
            string resultP = result.ToString("P");
            game.Score = resultP;
            GameHistory.Add(game);
            Console.WriteLine($"Your score is {result:p}");
            Console.WriteLine("Press any key to return to the main menu");
            Console.ReadKey();
            Console.WriteLine();
        }
        internal void Addition(Game game)
        {
            Random randomNumber = new Random();
            int firstNumber = 0;
            int secondNumber = 0;
            int score = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                if (game.GameDifficulty == GameDifficulty.easy)
                {
                    firstNumber = randomNumber.Next(1, 9);
                    secondNumber = randomNumber.Next(1, 9);
                } else if (game.GameDifficulty == GameDifficulty.hard) 
                {
                    firstNumber = randomNumber.Next(10, 99);
                    secondNumber = randomNumber.Next(10, 99);
                }
                

                int correctAnswer = firstNumber + secondNumber;

                Console.WriteLine($"What is {firstNumber} + {secondNumber}");

                Console.Write("Enter your answer here: ");
                string?userInput = Console.ReadLine();


                while (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out _)) 
                {
                    Console.WriteLine("Incorrect input, try again");
                    Console.WriteLine($"What is {firstNumber} + {secondNumber}");
                    Console.Write("Enter your answer here: ");
                    userInput = Console.ReadLine();
                }
                if(int.Parse(userInput) == correctAnswer)
                {
                    score++;
                }
               


            }
            OutPutScore(game, score);

        }

        //internal void Division(DateTime date)
        //{
        //    Random random = new Random();
        //    int score = 0;


        //    for (int i = 0; i < 5; i++)
        //    {

        //        Console.Clear();
        //        int firstNumber = random.Next(1, 99);
        //        int secondNumber = random.Next(1, 99);

        //        while (secondNumber % firstNumber != 0)
        //        {
        //            firstNumber = random.Next(1, 99);
        //            secondNumber = random.Next(1, 99);
        //        }
        //        Console.WriteLine($"What is {secondNumber} / {firstNumber}");
        //        Console.WriteLine("Enter your answer here: ");
        //        int answer = secondNumber/firstNumber;

        //        string?userInput = Console.ReadLine();
        //        while (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out _)) 
        //        {
        //            Console.WriteLine("Incorrect input, try again");
        //            Console.WriteLine($"What is {secondNumber} / {firstNumber}");
        //            Console.WriteLine("Enter your answer here: ");
        //            userInput = Console.ReadLine();

        //        }

        //        if (answer == int.Parse(userInput))
        //        {
        //            score++;
        //        }
               

        //    }
        //    OutPutScore(GameType.Division, score, date);
        //}

        //internal void Multiplication(DateTime date)
        //{
        //    int firstNumber;
        //    int secondNumber;
        //    int score = 0;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Clear();

        //        firstNumber = random1.Next(1, 9);
        //        secondNumber = random1.Next(1, 9);

        //        int answer = firstNumber * secondNumber;

        //        Console.WriteLine($"What is {firstNumber} * {secondNumber}");
        //        Console.Write("Enter your answer here: ");
        //        string?userInput = Console.ReadLine();
        //        while(string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out _))
        //        {
        //            Console.WriteLine("Incorrect input, try again");
        //            Console.WriteLine($"What is {firstNumber} * {secondNumber}");
        //            Console.Write("Enter your answer here: ");
        //            userInput = Console.ReadLine();

        //        }

        //        if (int.Parse(userInput) == answer)
        //        {
        //            score ++;
        //        }
                



        //    }
        //    OutPutScore(GameType.Multiplication, score, date);

        //}

        //internal void SubtractionGame(DateTime date)
        //{
        //    var random = new Random();
        //    var score = 0;

        //    int firstNumber;
        //    int secondNumber;

        //    for (int i = 0; i < 5; i++)
        //    {
        //        Console.Clear();

        //        firstNumber = random.Next(1, 9);
        //        secondNumber = random.Next(1, 9);

        //        while(secondNumber - firstNumber <= 0)
        //        {
        //            firstNumber = random.Next(1, 9);
        //            secondNumber = random.Next(1, 9);
        //        }

        //        int answer = secondNumber - firstNumber;

        //        Console.WriteLine($"What is {secondNumber} - {firstNumber}");
        //        Console.Write("Enter your answer here: ");
        //        string? userInput = Console.ReadLine();
        //        while (string.IsNullOrEmpty(userInput) || !Int32.TryParse(userInput, out _))
        //        {
        //            Console.WriteLine("Incorrect input, try again");
        //            Console.WriteLine($"What is {secondNumber} - {firstNumber}");
        //            Console.Write("Enter your answer here: ");
        //            userInput = Console.ReadLine();

        //        }

        //        if (int.Parse(userInput) == answer)
        //        {
        //            score++;
        //        }
             
               
        //    }
        //    OutPutScore(GameType.Subtraction, score, date);

        //}
    }
}
