namespace MyProject1
{
    internal class Program
    {
        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name + "\nI am from SayHi() method...");
        }

        static int Add(int num1, int num2)
        { 
            int result = num1 + num2;
            return result;
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            //Print a triangle on console
            /*Console.WriteLine("  /|");
            Console.WriteLine("   / |");
            Console.WriteLine("  /  |");
            Console.WriteLine(" /   |");
            Console.WriteLine("/____|");*/


            //Variables
            /*string charactorName = "Payal";
            int age;
            age = 40;
            Console.Write("My name is " + charactorName);
            Console.WriteLine(" and having age of " + age);
            age = 30;
            Console.WriteLine("Your name is "+ charactorName + " and having age of " + age);*/


            //Data Types in C#
            /*string phrase = "Payal Tiwari";
            char grade = 'A';
            int age = 30;
            //float,double,decimal  --> least accurate to more accurate
            double gpa = 3.2;
            bool isMale = false;

            Console.WriteLine($"Data Types\nstring:{phrase}\nchar:{grade}\nint:{age}\ndouble:{gpa}\nbool:{isMale}");*/



            //Working with String
            /*string phrase = "Payal Tiwari";
            Console.WriteLine(phrase);
            Console.WriteLine(phrase.Length);
            Console.WriteLine(phrase.ToUpper());
            Console.WriteLine(phrase.ToLower());
            Console.WriteLine(phrase.Contains("Tiwari"));
            Console.WriteLine(phrase.Contains("yal"));
            Console.WriteLine(phrase[0]);
            Console.WriteLine(phrase[2]);
            Console.WriteLine(phrase.IndexOf("Tiwari"));
            Console.WriteLine(phrase.Substring(2,5));*/



            //Working with numbers

            /*int num = 10;
            num++;
            Console.WriteLine(num);
            num--;
            Console.WriteLine(num);
            Console.WriteLine(5);
            Console.WriteLine(5 + 3);
            Console.WriteLine(5 - 3);
            Console.WriteLine(5 * 3);
            Console.WriteLine(5 / 3);
            Console.WriteLine(5 % 3);
            Console.WriteLine(5 + 3 * 2);
            Console.WriteLine((5 + 3) * 2);
            //Math methods
            num = 4;
            Console.WriteLine(num);
            Console.WriteLine(Math.Min(4,56));
            Console.WriteLine(Math.Max(4,56));
            Console.WriteLine(Math.Pow(2,3));
            Console.WriteLine(Math.Abs(-49));
            Console.WriteLine(Math.Round(4.6));
            Console.WriteLine(Math.Round(4.3));*/

            //Getting Input From User

            /*Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your age: ");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " your age is " + age);*/


            //Basic Calculations
            //with integer input
            /*Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{num1} + {num2}= {num1 + num2}");
            Console.WriteLine("{0} + {1} = {2}", num1, num2,num1 +num2 );

            //when the number is double
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0} + {1} = {2}", num1,num2,num1 +num2 );*/



            //Building a Mad Libs Game 

            /*string color, pluralNoun, celebrity;
            Console.Write("Enter the color: ");     //Red
            color = Console.ReadLine();
            Console.Write("Enter the pluralNoun: "); //Sky
            pluralNoun = Console.ReadLine();
            Console.Write("Enter the celebrity: ");  //You
            celebrity = Console.ReadLine();
            Console.WriteLine("Rose is " + color + "\n" + 
                pluralNoun + " is Blue \n" +
                "But how are " + celebrity + "...!");*/



            //Arrays and the input hardcoded and also taking from user

            /*int[] luckyNumber = { 11, 22, 33, 44, 55 };
            for (int i = 0; i < luckyNumber.Length; i++)
            {
                Console.WriteLine($"Your {i + 1} number in this string is " + luckyNumber[i]);
            }

            string[] friends = new string[5];
            for (int i = 0; i < friends.Length; i++)
            {
                Console.Write($"Enter the {i + 1} friend name: ");
                friends[i] = Console.ReadLine();
            }
            Console.WriteLine("Your 5 Friends Are:-");
            for (int i = 0; i < friends.Length; i++)
            {
                Console.WriteLine($"{i+1}: {friends[i]}");
            }*/



            //Call Methods
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            SayHi(name);

            Console.Write("Enter the number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int result = Add(num1, num2);
            Console.WriteLine($"{num1} + {num2} = {result}");


        }
    }
}
