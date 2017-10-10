using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
    //random class
{
    class JohnCena : Player
    {
        new string name;
        /*creates new roshclass everytime JohnCena class is created so that random 
         property will work correctly*/
        RoshamboGenerate rosh = new RoshamboGenerate();
        public JohnCena()
        {
            name = "John Cena";
        }
        public override string GetName()
        {
            return name;
        }
        public override string GenerateRoshValue()
        {
            Random r = new Random();
            int rando = r.Next(0, 3);
            return rosh.GetIndex(rando);

        }
    }
}
    