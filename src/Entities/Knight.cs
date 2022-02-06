using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class Knight: Hero
    {
        public Knight(string Name, int Level, string heroTyper)
        {
            this.Name = Name;
            this.Level = Level;
            this.heroTyper = heroTyper;
        }
    }
}
