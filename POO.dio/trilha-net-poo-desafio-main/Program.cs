using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando Nokia");
Smartphone nokia = new Nokia("0116", "Tijolo", "Gus123", 1234 );
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Testando Iphone");
Smartphone iphone = new Iphone("1914", "14 Pro", "Cris123", 4321);
iphone.Ligar();
iphone.InstalarAplicativo("Snapchat");