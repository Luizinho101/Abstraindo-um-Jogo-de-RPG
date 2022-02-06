using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraindo_um_Jogo_de_RPG.src.Entities
{
    public class wizard : Hero
    {
        public wizard(string Name, int Level, string heroTyper)
        {
            this.Name = Name;
            this.Level = Level;
            this.heroTyper = heroTyper;
        }
        public override string Attack()
        {
            return this.Name + "Lançou magia ";
        }
        public string Attack(int Bonus)
        {
            if(Bonus>6)
            {
                return this.Name + "Lançou Magia Super efetiva com bonus de " + Bonus;
            }
            else
            {
                return this.Name + "Lançou uma magia com força fraca com bonus de " + Bonus;
            }
           
        }
    }
}
