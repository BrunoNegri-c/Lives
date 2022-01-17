using System;
using System.Collections.Generic;

namespace Lives.src.Entities
{
    public class Herois
    {
       public Herois(string Nome, string ClasseFantastica)
       {
           this.Nome = Nome;
           this.ClasseFantastica = ClasseFantastica;
           this.Level = 1;
           this.PontosDeMagia = 50;
           this.PontosDeVida = 99;
       }
        public string Nome{ get; set ;}
        public int PontosDeVida { get; set ;}
        public int PontosDeMagia { get; set ;}
        public string ClasseFantastica{ get; set ;}
        public int Level { get ; set ;}

        public int ValorDoUltimoAtaque { get; set; }

        public override string ToString()
        {
            return "Meu nome é " + this.Nome + "\n"
                + "Level:" + this.Level + "\n"
                + "PontosdeVida:" + this.PontosDeVida + "\n"
                + "ClasseFantastica:" + this.ClasseFantastica + "\n"
                + "PontodeMagia :" + this.PontosDeMagia + "\n";
        }

        public virtual string Atacar()
        {
            Random dado = new Random();
            int ForcaDoAtaque = this.Level + dado.Next(1,20);
            this.ValorDoUltimoAtaque = ForcaDoAtaque;

            return this.Nome  +  "Ataca com sua espada e da " + 
                    ForcaDoAtaque  +   "de dano";
            
        }

        public void ReceberDano(int danorecebido)
        {
            this.PontosDeVida = this.PontosDeVida - danorecebido;
        }

    }
}