/*namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}


namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number:");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine("Addition: a + b = " + c);
        }
    }
}*/

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Calculate");
            a = int.Parse(Console.ReadLine()); 
            string option = (Console.ReadLine()); 
            b = int.Parse(Console.ReadLine());
            /*Console.WriteLine("What do you want to do");
            Console.WriteLine("-----------------------");
            Console.WriteLine("+ Addition");
            Console.WriteLine("- Substration");
            Console.WriteLine("* Multiplication");
            Console.WriteLine("/ Division");
            Console.WriteLine("-----------------------");
            string option = (Console.ReadLine());*/
            switch (option)
            {
                case ("+"): c = a + b;
                    Console.WriteLine($"{a} + {b} = {c}");
                    break;
                case ("-"): c = a - b;
                    Console.WriteLine(c);
                    break;
                case ("*"): c = a * b;
                    Console.WriteLine(c);
                    break;
                case ("/"): c = a / b;
                    Console.WriteLine(c);
                    break;
            }
        }
    }
}