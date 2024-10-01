﻿
Console.WriteLine("Djurslakt!");

Djur myDjur = new Djur();

Console.WriteLine("Välj ett namn till ditt djur!");
myDjur.name = Console.ReadLine();

Console.WriteLine($"Great! {myDjur.name} is a beautiful name!");
Console.WriteLine("Press any key to continue");
Console.ReadKey();

while (myDjur.GetAlive() == true)
{
  Console.Clear();
  myDjur.PrintStats();
  Console.WriteLine("Now what do you want to do?");
  Console.WriteLine($"1. Teach {myDjur.name} a new word");
  Console.WriteLine($"2. Talk to {myDjur.name}");
  Console.WriteLine($"3. Feed {myDjur.name}");
  Console.WriteLine($"4. Do nothing");

  string doWhat = Console.ReadLine();
  if (doWhat == "1")
  {
    Console.WriteLine("What word?");
    string word = Console.ReadLine();
    myDjur.Teach(word);
  }
  if (doWhat == "2")
  {
    myDjur.Hi();
  }
  if (doWhat == "3")
  {
    myDjur.Feed();
  }
  else
  {
    Console.WriteLine("Doing nothing...");
  }
  myDjur.Tick();
  Console.WriteLine("Press Enter to continue");
  Console.ReadLine();
}

Console.WriteLine($"OH NO! {myDjur.name} is dead!");
Console.WriteLine("Press ENTER to quit");
Console.ReadLine();