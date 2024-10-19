using DesafioPOO.Models;


Console.WriteLine("__________________");
Console.WriteLine("______Iphone______\n");
Iphone iphone = new Iphone
( "75994398",
  "Iphone 14",
  "22445",
  120
);

iphone.TurnOn();
Console.WriteLine($"Your number is {iphone.Number}");
iphone.downloadingApp("Intagram");
Console.WriteLine("__________________\n\n\n\n");



Console.WriteLine("_________________");
Console.WriteLine("______Nokia______");
Nokia nokia = new Nokia
( "75964398",
  "Nokia Ones",
  "34523",
  250
);

nokia.TurnOn();
Console.WriteLine($"Your number is {nokia.Number}");
nokia.downloadingApp("WhatsApp");
Console.WriteLine("__________________");