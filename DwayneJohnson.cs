using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
    //Class that will always return rock.Because Dwayne Johnson will always be the Rock
{
    class DwayneJohnson:Player
    {
        new string name;
        RoshamboGenerate roshambo = new RoshamboGenerate();
        public DwayneJohnson()
        {
            name = "Dwayne Johnson";
        }
        public override string GetName()
        {
            return name;
        }

        public override string GenerateRoshValue()
        {
            return roshambo.GetIndex(0);
        }
    }
}
