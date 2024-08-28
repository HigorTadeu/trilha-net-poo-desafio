using DesafioPOO.Models;

Console.WriteLine("Iniciando os testes dos celulares:");
Console.WriteLine("\n");

Nokia nokia = new Nokia(numero: "(55) 79 1234-56789", modelo: "N20 FE", imei: "11111111111", memoria: 128);
nokia.Ligar();
Console.WriteLine("\n");
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");
nokia.ReceberLigacao();

Iphone iphone = new Iphone(numero: "(55) 79 1111-22222", modelo: "X15", imei: "222222222222", memoria: 256);
iphone.Ligar();
Console.WriteLine("\n");
iphone.InstalarAplicativo("Zoom");
Console.WriteLine("\n");
iphone.ReceberLigacao();