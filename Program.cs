using DesafioPOO.Models;

Iphone iphone = new Iphone("(11) 99919-2299", "iPhone X", "aaaaa", 256);
Console.WriteLine(iphone);
iphone.Ligar();
iphone.InstalarAplicativo("Epic Games Store");
iphone.ExibirAplicativosInstalados();

Console.WriteLine("\n---\n");

Nokia nokia = new Nokia("(22) 99433-4434", "Nokia C21", "aaaaa", 256);
Console.WriteLine(nokia);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
nokia.ExibirAplicativosInstalados();