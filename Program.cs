using DesafioPOO.Models;


Nokia n1 = new Nokia("999999999", "A0", "356303486094384", 16);
n1.InstalarAplicativo("Candy Crush");
n1.Ligar();
n1.ReceberLigacao();

Console.WriteLine("---------------------------------");
Iphone i1 = new Iphone("988888888", "15 pro max", "356303487228718", 32);
i1.InstalarAplicativo("Pou");
i1.Ligar();
i1.ReceberLigacao();