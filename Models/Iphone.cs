using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        
          public Iphone(string numero, string modelo, string iMEI, int memoria)   : base(numero, modelo, iMEI, memoria) { }
      
         //Install APP

        public override void InstalarAplicativo(string nomeApp)
        {
     
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone!");
        }

        //Make Call

        public override void FazerChamada(string numero)
        {
            Console.WriteLine($"Fazendo chamada para o número {numero} usando o Iphone.");
        }

        // Take a Picture 

             public override void TirarFoto(string marca)
        {
            Console.WriteLine($"Tirando foto com meu {marca}");
        }

    }
    }
