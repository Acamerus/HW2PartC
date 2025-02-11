using System;

class Program {
    static void Main(string[] args) {
      bool running = true;
      string menu = "**************\n" + 
        "Menu:\n" + 
        "1 - New Game\n" + 
        "2 - Load Game\n" + 
        "3 - Options\n" + 
        "4 - Quit\n" + 
        "**************";
      string prompt = "Please select the option: ";
      string invalidPrompt = "Invalid Input. Please select the option again: ";

      bool validSelection = true;
      ConsoleKeyInfo selection = default(ConsoleKeyInfo);
      while(running) {
        Console.Clear();
        Console.WriteLine(menu);
        Console.WriteLine(selection.KeyChar != '\0' ? ("(Previous selection: " + selection.KeyChar + ")") : "");
        Console.Write(validSelection ? prompt : invalidPrompt);
        

        validSelection = true;
        selection = Console.ReadKey();

      

        switch (selection.KeyChar) {
          case '1':
            Console.WriteLine("Selected: " + selection.KeyChar + " - New Game");
            break;
          case '2':
            Console.WriteLine("Selected: " + selection.KeyChar + " - Load Game");
            break;
          case '3':
            Console.WriteLine("Selected: " + selection.KeyChar + " - Options");
            break;
          case '4':
            running = false;
            break;
          default:
            validSelection = false;
            break;
        }
      }
      
      Console.Clear();
      Console.WriteLine("Application successfully quit!");
      Environment.Exit(0);
    }
}