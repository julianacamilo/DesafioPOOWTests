using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
   
         public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        protected Smartphone(string numero, string modelo, string iMEI, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = iMEI;
            Memoria = memoria;
        }

        //Call

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        //Receiving Call

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        //Send Message

        public void EnviarMensagem(string mensagem)
        {
            Console.WriteLine($"Enviando mensagem: {mensagem}");
        }

           
         //Take a Picture
        public abstract void TirarFoto(string marca);

        //Install APP
        public abstract void InstalarAplicativo(string nomeApp);

        //Make Call
         public abstract void FazerChamada(string numero);

    }


}
