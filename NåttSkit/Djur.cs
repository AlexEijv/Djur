using System;
using System.Collections.Generic;

public class Djuret
{
  private int hunger;
  private int boredom;
  private List<string> words = new List<string>() {"Tjena brorsan!"};
  private bool isAlive;
  public string name;

  public Djuret()
  {
    isAlive = true;
  }

  public void Feed()
  {
    Console.WriteLine($" [{name}] Dammar och blir mätt");
    hunger -= 2;
    if (hunger < 0)
    {
      hunger = 0;
    }
  }

  public void Hi()
  {
    int wordNum = Random.Shared.Next(words.Count);
    Console.WriteLine($" [{name}] säger: {words[wordNum]}");
    ReduceBoredom();
  }

  public void Teach(string word)
  {
    Console.WriteLine($" [{name}] lärde sig: {word}");
    words.Add(word);
    ReduceBoredom();
  }

  public void Tick()
  {
    hunger++;
    boredom++;
    if (hunger > 10 || boredom > 10)
    {
      isAlive = false;
    }
  }

  public void PrintStats()
  {
    Console.WriteLine($"Name: {name} || Hunger: {hunger} || Boredom: {boredom} || Vocabulary: {words.Count} words");
  }

  public bool GetAlive()
  {
    return isAlive;
  }

  public void ReduceBoredom()
  {
    Console.WriteLine($" [{name}] är inte uttråkad!");

    boredom -= 2;
    if (boredom < 0)
    {
      boredom = 0;
    }
  }
}