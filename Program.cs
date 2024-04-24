using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("123456", "Modelo 1", "111111", 16);
nokia.Ligar();
nokia.ReceberLigacao();

nokia.InstalarAplicativo("Waze");

Console.WriteLine("\nSmartphone iPhone");
Smartphone iphone = new Iphone("654321", "Modelo 2", "222222", 64);
iphone.Ligar();
iphone.ReceberLigacao();

iphone.InstalarAplicativo("YouTube");