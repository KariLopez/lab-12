using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {
        protected string name;
        public Player()
        {
        }
        public virtual string GetName()
        {
            return name;
        }
        public abstract string GenerateRoshValue();
    }
}
