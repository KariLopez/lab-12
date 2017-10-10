using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RoshamboApp
    {
        protected string uChoice;
        protected string jChoice;
        protected string dChoice;
        User u = new User();
        public string AskPlay()
        {//formats users selection with their name
            uChoice = u.GenerateRoshValue();
            string formatted = u.GetName() + ": " + uChoice;
            return formatted;
        }
        //method also checks who will win game
        public string PlayerSelection(string player)
        {
                if (player == "john cena")
                {
                    //creates new instance of JohnCena class, creating new random value, different time stamp
                    JohnCena j = new JohnCena();
                    jChoice = j.GenerateRoshValue();
                    Console.WriteLine(j.GetName() + ": " + jChoice);

                    if (uChoice == jChoice)
                    {
                    Console.WriteLine("draw!");
                    }
                    else 
                    {
                        if (uChoice == "rock" && jChoice == "scissors")
                        {
                        Console.WriteLine(u.GetName()+" wins!");
                        }
                        else if (uChoice == "paper" && jChoice == "rock")
                        {
                        Console.WriteLine(u.GetName() + " wins!");
                        }
                        else if (uChoice == "scissors" && jChoice == "paper")
                        {
                        Console.WriteLine(u.GetName() + " wins!");
                        }
                        else
                        {
                        Console.WriteLine(j.GetName()+" wins!");
                        }
                    }   
                }   
                else if (player == "dwayne johnson")
                {
                    DwayneJohnson d = new DwayneJohnson();
                    dChoice=d.GenerateRoshValue();
                    Console.WriteLine(d.GetName() + ": " + dChoice);
                    if (uChoice == dChoice)
                    {
                    Console.WriteLine("draw!");
                    }
                    else 
                    {
                        if (uChoice == "paper" && dChoice == "rock")
                        {
                        Console.WriteLine(u.GetName() + " wins!");
                    }
                        else if (uChoice == "scissors" && dChoice == "paper")
                        {
                        Console.WriteLine(u.GetName() + " wins!");
                    }
                        else
                        {
                        Console.WriteLine(d.GetName()+" wins!");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("That is not a player");
                    
                }
            return "not a valid entry";
        }
    }
}
