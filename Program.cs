using DesafioPOO.Models;

Iphone iph = new("245555555555", "Iphone com botão", 1235468796, 256);
iph.Ligar();
iph.InstalarAplicativo("Instagram");
iph.ReceberLigacao();
Console.WriteLine("");
Console.WriteLine("");
Nokia nk =new Nokia("24777777777", "Tijolão", 541248796, 16);
nk.Ligar();
nk.InstalarAplicativo("Facebook");
nk.ReceberLigacao();