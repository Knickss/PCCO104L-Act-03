using System;

class Program {
  public static void Main (string[] args) {
    string input = "";
    string output = "";

    do
    {
      Console.WriteLine ("Enter something:");
      input = Console.ReadLine();
      if (input != "exit")
      {
        output += input + " ";
        Console.WriteLine(output);
      }
    } while (input != "exit");

    Console.WriteLine($"Closing program...");
  }
}


