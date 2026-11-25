using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectionActivity()
        : base("Reflection Activity",
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different from other times?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience?",
            "What did you learn about yourself?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        StartMessage();

        Random random = new Random();

        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");

        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        List<string> remainingQuestions = new List<string>(_questions);

        while (DateTime.Now < endTime)
        {
            if (remainingQuestions.Count == 0)
            {
                remainingQuestions = new List<string>(_questions);
            }

            int index = random.Next(remainingQuestions.Count);

            Console.WriteLine();
            Console.WriteLine(remainingQuestions[index]);

            remainingQuestions.RemoveAt(index);

            int remaining = (int)Math.Ceiling((endTime - DateTime.Now).TotalSeconds);

            if (remaining > 0)
            {
                ShowSpinner(Math.Min(5, remaining));
            }
        }

        EndMessage();
    }
}