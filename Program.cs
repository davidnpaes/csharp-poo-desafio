using DesafioPOO.Models;

Smartphone iphone = new Iphone(numero: "12345678", modelo: "Iphone 1", imei: "111111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone nokia = new Nokia(numero: "87654321", modelo: "Nokia 1", imei: "222222", memoria: 128);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");
