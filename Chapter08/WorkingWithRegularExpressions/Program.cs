using System.Text.RegularExpressions;   //Regex


    public partial class Program
    {

        private static void Main(string[] args)
        {
            //Checking for digits entered as text
            Write("Enter your age: ");
            string input = ReadLine()!;  //null-forgiving
           // Regex ageChecker = new Regex(digitsOnlyText);
            Regex csv1 = new(commaSeparatorText);

        if (csv1.IsMatch(input))
            {
                WriteLine("Welcome");
            }
            else
            {
                WriteLine($"This is not a valid age {input}");
            }



            /* to store a complex comma-separated string variable, and then split it in a
            dumb way using the Split method*/

            // C# 1 to 10: Use escaped double-quote characters \"
            // string films = "\"Monsters, Inc.\",\"I, Tonya\",\"Lock, Stock and Two Smoking Barrels\"";
            // C# 11 or later: Use """ to start and end a raw string literal

            string films = """
"Monsters, Inc.","I, Tonya","Lock, Stock and Two Smoking Barrels"
""";
            WriteLine($"Films to split: {films}");
            string[] filmsDumb = films.Split(',');
            WriteLine("Splitting with string.Split method:");
            foreach (string film in filmsDumb)
            {
                WriteLine(film);
            }

            //regular expression to split and write the film titles in a smart way

            Regex csv = new(
            "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
            MatchCollection filmsSmart = csv.Matches(films);
            WriteLine("Splitting with regular expression:");
            foreach (Match film in filmsSmart)
            {
                WriteLine(film.Groups[2].Value);
            }
        }
    }
