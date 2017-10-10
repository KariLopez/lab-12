using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboGenerate
    {
        List<string> roshambo = new List<string>();
        public RoshamboGenerate()
        {
            roshambo.Add("rock");
            roshambo.Add("paper");
            roshambo.Add("scissors");

        }
        public string GetString(string input)
        {
            string output;

            if (input == "r")
            {
                output = roshambo[0];
            }
            else if (input == "p")
            {
                output = roshambo[1];
            }
            else if (input == "s")
            {
                output = roshambo[2];
            }
            else
            {
                output = "not a valid entry";
            }
            return output;
        }
        public string GetIndex(int i)
        {
            string output;
            try
            {
                output = roshambo[i];
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("That was not a valid index put into the roshambo index");
                output = "-1";
            }
            return output;
        }
    }
}
