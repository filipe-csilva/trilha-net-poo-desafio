using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456", modelo: "6100", imei: "15437894623", memoria:2);
nokia.Ligar();
Thread.Sleep(2000);
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia: ");
Smartphone iphone = new Iphone(numero: "165748", modelo: "15", imei: "16416519848", memoria: 4);
iphone.ReceberLigacao();
Thread.Sleep(2000);
iphone.InstalarAplicativo("Telegram");