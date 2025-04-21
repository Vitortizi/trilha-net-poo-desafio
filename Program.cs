using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 32);
Console.WriteLine("Número do Nokia: " + nokia.Numero);
nokia.Ligar(); 
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp"); 

Console.WriteLine(); // Adicionando uma linha em branco para separar as saídas

Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 128);
Console.WriteLine("Número do iPhone: " + iphone.Numero);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");