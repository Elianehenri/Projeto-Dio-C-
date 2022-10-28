using DesafioPOO.Models;


Console.WriteLine("Smartphone Nokia:");
Nokia n1= new Nokia("4954871236","N12","17171717",128);
Console.WriteLine(n1.Numero);
n1.Ligar();
n1.ReceberLigacao();
n1.InstalarAplicativo("Whatsapp");


Iphone i1 = new Iphone("48172598745", "16", "25871525836",512 );
Console.WriteLine(i1.Numero);
i1.Ligar();
i1.ReceberLigacao();
i1.InstalarAplicativo("Instagram");
