namespace ConsoleApp2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int i = 10;
            Console.WriteLine("Value of i :"+i);
            public void obj(ref int j)
        {
            j = 101;
            Console.WriteLine("Value of j is " + j);
        }
        obj(ref int i);
            Console.WriteLine("Now value of i :" + i);
        }
    }
}
