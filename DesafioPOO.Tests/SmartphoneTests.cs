using DesafioPOO.Models;
using Xunit;
using System;

namespace DesafioPOO.Tests
{
    public class SmartphoneTests
    {
        [Fact]
        public void TestarNokia()
        {
            // Arrange
            Smartphone nokia = new Nokia(numero: "0000000", modelo: "O Primeiro Modelo", iMEI: "000000", memoria: 128);

            // Act
            nokia.Ligar();
            nokia.InstalarAplicativo("Instagram");
            nokia.FazerChamada("123456789");
            nokia.EnviarMensagem("Olá, Tudo bem?");

            // Assert
            Assert.Equal("0000000", nokia.Numero);
            Assert.Equal("O Primeiro Modelo", nokia.Modelo);
            
        }

        [Fact]
        public void TestarIphone()
        {
            // Arrange
            Smartphone iphone = new Iphone(numero: "1111111", modelo: "O Segundo Modelo", iMEI: "111111", memoria: 264);

            // Act
            iphone.ReceberLigacao();
            iphone.InstalarAplicativo("X");
            iphone.FazerChamada("987654321");
            iphone.TirarFoto("Iphone 15 PRO");

            // Assert
            Assert.Equal("1111111", iphone.Numero);
            Assert.Equal("O Segundo Modelo", iphone.Modelo);
          
        }
    }
}
