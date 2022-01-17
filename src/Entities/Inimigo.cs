using  System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lives.src.Entities
{
    public class Inimigo : Mago
    {  public Inimigo(string Nome, string ClasseFantastica) : base(Nome,ClasseFantastica)
       {
           this.Nome = Nome;
           this.ClasseFantastica = ClasseFantastica;
           this.Level = 1;
           this.PontosDeMagia = 50;
           this.PontosDeVida = 99;
       }

        public override string Atacar()
        {
            Random dado = new Random();
            int ForcaDoAtaque = this.Level + dado.Next(1,15);

            return this.Nome + "Ataca e da " + ForcaDoAtaque + "de dano";   
        }

    }
}