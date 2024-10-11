﻿
Console.WriteLine("Djurslakt!");

Djur mittDjur = new Djur();

Console.WriteLine("Välj ett namn till ditt djur!");
mittDjur.name = Console.ReadLine();

Console.WriteLine($"Vadå {mittDjur.name}? Sämsta namnet jag läst!");
Console.WriteLine("Valfri knapp för att fortsätta");
Console.ReadKey();

while (mittDjur.GetAlive() == true)
{
  Console.Clear();
  mittDjur.PrintStats();
  Console.WriteLine("Vad vill du göra?");
  Console.WriteLine($"1. Lära {mittDjur.name} nytt ord");
  Console.WriteLine($"2. Snacka {mittDjur.name}");
  Console.WriteLine($"3. Mata {mittDjur.name}");
  Console.WriteLine($"4. Gör inget");

  string görVad = Console.ReadLine();
  if (görVad == "1")
  {
    Console.WriteLine("Vilket ord?");
    string ord = Console.ReadLine();
    mittDjur.Lär(ord);
  }
  if (görVad == "2")
  {
    mittDjur.Tja();
  }
  if (görVad == "3")
  {
    mittDjur.Mata();
  }
  else
  {
    Console.WriteLine("Gör inget");
  }
  mittDjur.Tick();
  Console.WriteLine("Tryck ENTER för att fortsätta");
  Console.ReadLine();
}

Console.WriteLine($"Haha! {mittDjur.name} dog!");
Console.WriteLine("Tryck ENTER för att avsluta");
Console.ReadLine();