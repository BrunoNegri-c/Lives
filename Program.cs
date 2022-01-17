using System;
using Lives.src.Entities;

namespace Lives
{
    class Program
    {
        static void Main(string[] args)
        {
            Herois Arus = new Herois("Arus", "Guerreiro");
            Mago Wedge = new Mago("Wedge", "Mago Negro");
            Inimigo KingMummy = new Inimigo("KingMummy", "Zumbi");


            Console.WriteLine(Arus.Atacar());
            Console.WriteLine(KingMummy.Atacar());
           

            if(Arus.ValorDoUltimoAtaque == KingMummy.ValorDoUltimoAtaque)
            {
                Console.WriteLine("Empate, ambos deram dano de"+ Arus.ValorDoUltimoAtaque);
            }
            else if(Arus.ValorDoUltimoAtaque > KingMummy.ValorDoUltimoAtaque)
            {
                KingMummy.ReceberDano(Arus.ValorDoUltimoAtaque - KingMummy.ValorDoUltimoAtaque);
                Console.WriteLine(Arus.Nome + "Venceu esse round");
            }else
            {
                Arus.ReceberDano(KingMummy.ValorDoUltimoAtaque - Arus.ValorDoUltimoAtaque);
                Console.WriteLine(KingMummy.Nome + "Venceu esse round");
            }
            
            

        
            
           
          

        }
    }
}
