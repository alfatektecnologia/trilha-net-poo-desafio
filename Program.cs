using DesafioPOO.Models;

Console.Clear();
Console.WriteLine("Testando o Smarphone NOKIA:");
Nokia nokia = new Nokia("32 991234 9900","Nokia Xtreme","1234567890",32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Receita Federal");

Console.WriteLine("\n");

Console.WriteLine("Testando o Smarphone IPHONE:");
Iphone iphone = new Iphone("84 991234 9900","Iphone 10","0987654321",128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Onlyfans");

Console.WriteLine("\n");
Console.WriteLine("Final do desafio!");
Console.WriteLine("\n");