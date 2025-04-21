using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
Console.WriteLine("Número do Nokia: " + nokia.Numero);
Console.WriteLine("Modelo do Nokia: " + nokia.Modelo);
Console.WriteLine("IMEI do Nokia: " + nokia.IMEI);
Console.WriteLine("Memória do Nokia: " + nokia.Memoria + "GB");

nokia.Numero = "40028922"; // Alterando o número do Nokia
Console.WriteLine("Novo número do Nokia: " + nokia.Numero);

nokia.Ligar(); 
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp"); 



Console.WriteLine("-------------------------------------------------------------");

Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
Console.WriteLine("Número do iPhone: " + iphone.Numero);
Console.WriteLine("Modelo do iPhone: " + iphone.Modelo);
Console.WriteLine("IMEI do iPhone: " + iphone.IMEI);  
Console.WriteLine("Memória do iPhone: " + iphone.Memoria + "GB");

iphone.Numero = "89224002"; // Alterando o número do Iphone
Console.WriteLine("Novo número do Iphone: " + iphone.Numero);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");