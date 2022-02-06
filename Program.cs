using Abstraindo_um_Jogo_de_RPG.src.Entities;
using System;


namespace Abstraindo_um_Jogo_de_RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus",23,"Type");
            wizard wizard = new wizard("Jenica", 23, "wite wizard");

            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
        }
    }
}
