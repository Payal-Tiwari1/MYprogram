//int numberOfApples = 12;
//decimal pricePerApple = 0.35M;
//Console.WriteLine($"{numberOfApples} apples cost {pricePerApple
//*
//numberOfApples:C}");

//string firstname = "Omar";
//string lastname = "Rudberg";
//string fullname = firstname + " " + lastname;

//string fullname = $"{firstname} {lastname}";

//Console.Write("Type your first name and press ENTER: ");
//string firstName = Console.ReadLine();
//Console.Write("Type your age and press ENTER: ");
//string age = Console.ReadLine();
//Console.WriteLine($"Hello {firstName}, you look good for {age}.");

/*using static System.Console;

Console.WriteLine("Hello");
Console.WriteLine("Welcome");

WriteLine("Hello");
WriteLine("Welcome");*/

Console.WriteLine("Press any key combination: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
arg0: key.Key,
arg1: key.KeyChar,
arg2: key.Modifiers);
