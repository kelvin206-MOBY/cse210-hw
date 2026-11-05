using System;
using System.Collections.Generic;

class Program
{
            public static List<string> _prompts = new List<string>
       {
          "Who was the most interesting person you interacted with today?",
          "What was the best part of your day?",
          "How did you see the hand of the Lord in your life today?",
          "What was the strongest emotion you felt today?",
          "If you had one thing you could do over today, what would it be?",
          "What new thing did you learn today?",
          "What made you smile today?"
        };

        public static string GetRandomPrompt()
        {
          Random random = new Random();

          int index = random.Next(_prompts.Count);

          return _prompts[index];
        }

        public static void WriteEntry(Journal journal)
    {
      string prompt = GetRandomPrompt();

      Console.WriteLine(prompt);
      Console.Write("> ");

      string response = Console.ReadLine();

      Entry newEntry = new Entry();

      newEntry._date = DateTime.Now.ToShortDateString();
      newEntry._promptText = prompt;
      newEntry._entryText = response;

      journal._entries.Add(newEntry);
   }

        static void Main(string[] args)
        {

        Journal journal = new Journal();  
        string choice = "";

        while (choice != "5")
{
          Console.WriteLine("\nPlease select one of the following choices:");
          Console.WriteLine("1. Write");
          Console.WriteLine("2. Display");
          Console.WriteLine("3. Load");
          Console.WriteLine("4. Save");
          Console.WriteLine("5. Quit");

          Console.Write("What would you like to do? ");

          choice = Console.ReadLine();

    if (choice == "1")
    {
        WriteEntry(journal);
    }
    else if (choice == "2")
    {
        journal.DisplayAll();
    }
    else if (choice == "3")
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }
    else if (choice == "4")
    {
        Console.Write("Enter filename: ");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }
}

        }
    
}