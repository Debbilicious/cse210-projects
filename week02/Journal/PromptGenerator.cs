using System;
using System.Collections.Generic;

public class PromptGenerator
{
    Random random = new Random();
    public List<string> _prompts = new List<string>
    {
        "Who was the most interesting person you met today?",
        "What are you grateful for today?",
        "Describe a challenging moment you faced recently.",
        "How did you see the hand of the Lord in your life today?",
        "What is a goal you want to achieve this week?",
        "Reflect on a happy memory from your childhood.",
        "What is something new you learned today?",
        "How do you feel right now and why?",
        "Write about a person who inspires you.",
        "What is a place you would like to visit and why?",
        "Describe your perfect day.",
        "What are three things that made you smile today?"
    };
    public string GetRandomPrompt()
    {
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}