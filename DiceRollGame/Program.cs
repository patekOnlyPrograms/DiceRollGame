using System;
namespace DiceRollGame
{
    public class Program
    {
        static void Main(string[] args)
        {
            Dice dice = new Dice();
            UserOperations userOP = new UserOperations();
            //Console.WriteLine(dice.Roll());
            userOP.UserGuessing();
        }
        
      }

    public class Dice
    {
        private readonly Random _number;

        public Random number { get { return _number; } }
        Random rand = new Random();

        public int Roll() => rand.Next(1, 7);


    }

    /*public class Game
    {
        public 
    }
*/
    public class UserOperations
    {
        public void UserGuessing()
        {
            Dice dice = new Dice();
            int roll = dice.Roll();
            int lives = 3;
            Console.WriteLine(roll);
            do
            {
                Console.WriteLine($"Dice rolled. Guess what number it shows in {lives} tries.");
                string input = Console.ReadLine();
                if (Int32.TryParse(input, out int guessValue))
                {
                    Console.WriteLine(guessValue);
                    if (guessValue == roll)
                    {
                        Console.WriteLine("You guessed the right number");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong number");
                        --lives;
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect input");
                    --lives;
                }
            } while (lives > 0);
            
            
        }

        /*private int ReadInt(string message)
        {
            do
            {
                Console.WriteLine($"{message}");
            }
            while
        }*/
    }
}
