//int a = 3;
//int b = a++;
//WriteLine($"a is {a}, b is {b}");

//int c = 3;
//int d = ++c; // increment c before assigning it
//WriteLine($"c is {c}, d is {d}");

//int e = 11;
//int f = 3;
//WriteLine($"e is {e}, f is {f}");
//WriteLine($"e + f = {e + f}");
//WriteLine($"e - f = {e - f}");
//WriteLine($"e * f = {e * f}");
//WriteLine($"e / f = {e / f}");
//WriteLine($"e % f = {e % f}");




//string[] names = { "Payal", "Sonal", "Durgesh" };

//foreach (string name in names)
//{
//    WriteLine($"Your name is {name} and having length of {name.Length} charactors.", name);
//}


//string[] names;

//names = new string[3];
//WriteLine("Enter first name:");
//names[0] = ReadLine();
//WriteLine("Enter second name:");
//names[1] = ReadLine();
//WriteLine("Enter third name:");
//names[2] = ReadLine();

//foreach (string name in names)
//{
//    WriteLine(name);
//}


// One Dimentional array input from user.....
//string[] names;
//names = new string[3];
//WriteLine("Enter first name:");
//names[0] = ReadLine();
//WriteLine("Enter second name:");
//names[1] = ReadLine();
//WriteLine("Enter third name:");
//names[2] = ReadLine();
//for (int i = 0; i <= names.Length; i++)
//{
//    WriteLine(names[i]);
//}




//Multidimentional array
//using System.Data;
//string[,] grid1 = new[,] // two dimensions
//{
//{ "Alpha", "Beta", "Gamma", "Delta" },
//{ "Anne", "Ben", "Charlie", "Doug" },
//{ "Aardvark", "Bear", "Cat", "Dog" }
//};
//for (int row = 0; row <= grid1.GetUpperBound(0); row++)
//{
//    for (int col = 0; col <= grid1.GetUpperBound(1); col++)
//    {
//        WriteLine($"Row {row},Column {col} : {grid1[row, col]}");
//    }
//}



//Jagged Array...
//string[][] jagged = new[] // array of string arrays
//{
//new[] { "Alpha", "Beta", "Gamma" },
//new[] { "Anne", "Ben", "Charlie", "Doug" },
//new[] { "Aardvark", "Bear" }
//};
//for (int row = 0; row <= jagged.GetUpperBound(0); row++)
//{
//    for (int col = 0; col <= jagged[row].GetUpperBound(0); col++)
//    {
//        WriteLine($"Row {row}, Column {col}: {jagged[row][col]}");
//    }
//}



//Rounding numbers....
//double[] doubles = new[]
//{ 9.49, 9.5, 9.51, 10.49, 10.5, 10.51 };
//foreach (double n in doubles)
//{
//    WriteLine(format:
//    "Math.Round({0}, 0, MidpointRounding.AwayFromZero) is {1}",
//    arg0: n,
//    arg1: Math.Round(value: n, digits: 0,
//    mode: MidpointRounding.AwayFromZero));
//}


//Converting from any type to a string
//int number = 12;
//WriteLine(number.ToString());
//bool boolean = true;
//WriteLine(boolean.ToString());
//DateTime now = DateTime.Now;
//WriteLine(now.ToString());
//object me = new();
//WriteLine(me.ToString());


//Converting from a binary object to a string
// allocate array of 128 bytes
//byte[] binaryObject = new byte[128];
//// populate array with random bytes
//Random.Shared.NextBytes(binaryObject);
//WriteLine("Binary Object as bytes:");
//for (int index = 0; index < binaryObject.Length; index++)
//{
//    Write($"{binaryObject[index]:X} ");
//}
//WriteLine();
//// convert to Base64 string and output as text
//string encoded = ToBase64String(binaryObject);
//WriteLine($"Binary Object as Base64: {encoded}");

//Avoiding exceptions using the TryParse method
//Write("How many apple are there? ");
//string? input = ReadLine();

//if (int.TryParse(input, out int count))
//{
//    WriteLine($"There are {count} apples.");
//}
//else
//{
//    WriteLine("I could not parse the input.");
//}



//Try-catch
Write("What is your age? ");
string? input = ReadLine();   // 👈 yahin declare hua

try
{
    int age = int.Parse(input!);
    WriteLine($"You are {age} years old.");
}
catch (FormatException)
{
    WriteLine("Please enter numbers only.");
}
catch (Exception ex)
{
    WriteLine(ex.Message);
}



