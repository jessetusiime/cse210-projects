using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "Who was the most interesting person I met today?",
        "What is something you are proud of accomplishing recently?",
        "What was the best part of my day?",
        "List three things that made you smile today.",
        "How did I see the hand of the Lord in my life today?",
        "What is one thing you can do to relieve stress?",
        "What was the strongest emotion I felt today?",
        "What is your favorite way to spend a weekend?",
        "What is your favorite scripture?",
        "If I had one thing I could do over today, what would it be?",
        "What skill would you like to develop this month?",
        "What does happiness mean to you?",
        "What is your favorite movie to watch?",
        "Who is your most influencial person?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}