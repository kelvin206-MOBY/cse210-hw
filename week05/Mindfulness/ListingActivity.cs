using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
        : base("Listing Activity",
        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();

        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        List<string> answers = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");

            string answer = Console.ReadLine();

            if (DateTime.Now < endTime && !string.IsNullOrWhiteSpace(answer))
            {
                answers.Add(answer);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {answers.Count} items.");

        EndMessage();
    }
}