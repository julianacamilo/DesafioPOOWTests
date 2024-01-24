using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
          public Nokia(string numero, string modelo, string iMEI, int memoria) : base(numero, modelo, iMEI, memoria) { }
          

            //Install APP
           public override void InstalarAplicativo(string nomeApp) {
                       
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia!");
           }

            //Make Call
             public override void FazerChamada(string numero)
        {
            Console.WriteLine($"Fazendo chamada para o número {numero} usando o Nokia.");
        }

        // Take a Picture
             public override void TirarFoto(string marca)
        {
            Console.WriteLine($"Tirando foto com meu {marca} mais novo da Nokia");
        }

         
    }
}