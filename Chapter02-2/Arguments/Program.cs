/*namespace Arguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, World!");
            WriteLine($"There are {args.Length} arguments.");
        }
    }
}*/

/*using System;

if (args.Length < 3)
{
    WriteLine("You must specify two colors and cursor size, e.g.");
    WriteLine("dotnet run red yellow 50");
    return;
}

ForegroundColor = (ConsoleColor)Enum.Parse(
    typeof(ConsoleColor),
    args[0],
    ignoreCase: true);

BackgroundColor = (ConsoleColor)Enum.Parse(
    typeof(ConsoleColor),
    args[1],
    ignoreCase: true);

CursorSize = int.Parse(args[2]);

try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");
}

WriteLine("Console settings applied successfully!");
WriteLine($"There are {args.Length} arguments.");*/

/*using static System.Console;

WriteLine("Start");

await DoWorkAsync();

WriteLine("End");

async Task DoWorkAsync()
{
    WriteLine("Working...");
    await Task.Delay(3000); // 3 seconds
    WriteLine("Work finished");
}*/

HttpClient client = new();
HttpResponseMessage response =
await client.GetAsync("http://www.apple.com/");
WriteLine("Apple's home page has {0:N0} bytes.",
response.Content.Headers.ContentLength);