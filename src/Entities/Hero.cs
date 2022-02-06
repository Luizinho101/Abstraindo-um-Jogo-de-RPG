using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string heroTyper)
        {
            this.Name = Name;
            this.Level = Level;
            this.heroTyper = heroTyper;
        }
        public Hero()
        {

        }
        public string Name;
        public int Level;
        public string heroTyper;
        public override string ToString()
        {
            return this.Name+ " "+ this.Level+" "+this.heroTyper ;
        }
        public virtual string Attack()
        {
            return this.Name + "Atacounco sua espada ";
        }
    }
}
