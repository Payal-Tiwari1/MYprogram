namespace basic_concept_of_c_
{
    class Program
    {
        static void Main(string[] args)
        {
            emp e1 = new emp();
            e1.set_i(50);

            Console.WriteLine(e1.get_i());
            //  Console.WriteLine(sizeof(emp));  this is not possible in C#
            //  Console.WriteLine(sizeof(e1));      this is not possible in C#
        }
    }
}
