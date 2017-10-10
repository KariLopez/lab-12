using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            RoshamboApp letsPlay = new RoshamboApp();
            bool doAgain = true;
            while (doAgain == true)
            {
                Console.WriteLine("Would you like to play against Dwayne Johnson or John Cena?");
                string selectPlayer = Console.ReadLine();
                selectPlayer.ToLower();
                Console.WriteLine(letsPlay.AskPlay());
                letsPlay.PlayerSelection(selectPlayer);
                doAgain = Continue();
            }
        }
        public static bool Continue()
        {
            string input;
            Console.WriteLine("Would you like to play again? Y/N");
            input=Console.ReadLine();
            input.ToLower();
            bool repeat;
            if (input == "y")
            {
                repeat = true;
            }
            else if (input == "n")
            {
                repeat = false;
            }
            else
            {
             Console.WriteLine("I'm sorry that is not a valid entry, please try again");
             repeat = true;
            }
            return repeat;
        }
     }

}