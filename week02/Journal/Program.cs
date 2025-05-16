class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        string prompt = promptGen.GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        Entry newEntry = new Entry
        {
            _date = DateTime.Now.ToString("MM/dd/yyyy"),
            _prompt = prompt,
            _text = response
        };

        myJournal.AddEntry(newEntry);
        myJournal.DisplayJournal();
    }
}