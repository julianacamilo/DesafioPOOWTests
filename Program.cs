using DesafioPOO.Models;

//Nokia
Console.WriteLine("Smartphone Nokia: ");

Smartphone nokia = new Nokia(numero: "0000000", modelo: "The First Model", iMEI: "000000", memoria: 128);

nokia.Ligar();
nokia.InstalarAplicativo("Instagram");
nokia.FazerChamada("123456789"); 
nokia.EnviarMensagem("Olá, Tudo bem?");

Console.WriteLine("\n");


//Iphone

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "1111111", modelo: "The Second Model", iMEI: "111111", memoria: 264);

iphone.ReceberLigacao();
iphone.InstalarAplicativo("X");
iphone.FazerChamada("987654321");
iphone.TirarFoto("Iphone 15 PRO");
