using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame.kmakai;

public class MathGameGame
{
    public List<Game> GamesPlayed { get; set; } = new List<Game>();
    public Game? CurrentGame { get; set; }

    public void Play()
    {

        Console.WriteLine("Welcome to the Math Game!");
        while (true)
        {
            Console.WriteLine("Please select an operation: ");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Exit");
            Console.WriteLine("6. See Games Played");
            Console.Write("Choice: ");
            string? choice = Console.ReadLine();

            if (choice == "5") break;
            if (choice == "6")
            {
                foreach (Game game in GamesPlayed)
                {
                    Console.WriteLine($"{game.NumberOne} {game.Op} {game.NumberTwo} = {game.Answer}");
                }
            }

            switch (choice)
            {
                case "1":
                    CurrentGame = new Game(Operation.Add);
                    break;
                case "2":
                    CurrentGame = new Game(Operation.Subtract);
                    break;
                case "3":
                    CurrentGame = new Game(Operation.Multiply);
                    break;
                case "4":
                    CurrentGame = new Game(Operation.Divide);
                    break;

            };


            if (CurrentGame != null)
            {
                Console.Clear();
                GamesPlayed.Add(CurrentGame);
                if (choice == "4")
                {
                    Console.WriteLine("Rounding to the nearest whole number.");
                }
                Console.WriteLine($"What is {CurrentGame?.NumberOne} {CurrentGame?.Op} {CurrentGame?.NumberTwo}?");
                Console.Write("Answer: ");
                string? answer = Console.ReadLine();

                if (answer == CurrentGame.Answer.ToString())
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect! The correct answer is {CurrentGame.Answer}");
                }
            }






        }
    }
}


