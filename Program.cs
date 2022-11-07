using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Smarthphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("\n");

System.Console.WriteLine("Smarthphone Iphone");
Smartphone iphone = new Iphone(numero: "55789", modelo: "Modelo 2", imei: "2222222", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");