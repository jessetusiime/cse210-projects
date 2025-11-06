public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void display()
    {
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryText}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine();
    }
}