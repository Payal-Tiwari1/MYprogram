partial class Program
{
    static void Output(string title, IEnumerable<string> collection)
    {
        Console.WriteLine(title);
        foreach (string item in collection)
        {
            Console.WriteLine(item);
        }
    }

    static void OutputPQ<TElement, TPriority>(string title, IEnumerable<(TElement Element, TPriority Priority)> collection)
    {
        Console.WriteLine(title);
        foreach ((TElement, TPriority) item in collection)
        {
            Console.WriteLine($"{item.Item1}: {item.Item2}");
        }
    }
}