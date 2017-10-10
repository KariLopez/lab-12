using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class User : Player
    {
        RoshamboGenerate r = new RoshamboGenerate();
        new string name;
        public User()
        {
            Console.WriteLine("Enter your name");
            string nameInput = Console.ReadLine();
            name = nameInput;
        }
        public override string GetName()
        {
            return name;
        }

        public override string GenerateRoshValue()
        {
            
            Console.WriteLine("Please select what you'd like to throw? R for Rock, P for Paper, S for Scissors");
            string input = Console.ReadLine();
            input.ToLower();
            return r.GetString(input);
            
            
        }
    }
}
