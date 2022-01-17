using System;

namespace Lives.src.Entities

{
    public class Mago : Herois
    {

        public Mago(string Nome, string ClasseFantastica) : base(Nome,ClasseFantastica)
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
            int ForcaDoAtaque = this.Level + dado.Next(1,10);
            this.ValorDoUltimoAtaque = ForcaDoAtaque;

            return this.Nome + "Ataca com o seu cajado e da " + ForcaDoAtaque + "de dano";
        }
        public string Atacar(int bonus)
        {
            Random dado = new Random();
            int ForcaDoAtaque = this.Level + dado.Next(1,10) + bonus;
            return this.Nome + "Ataca com bonus com seu cajado e da" + ForcaDoAtaque + "de dado";
            {
                 
            }    
        }

    }
}