//TimesTable(7);

//decimal taxToPay = CalculateTax(amount: 1000, twoLetterReginalCode: "FR");
//WriteLine($"You must to pay {taxToPay} in tax.");



static void RunCardinalToOrdinal()
{
    for (int number = 1; number <= 150; number++)
    {
        Write($"{CardinalToOrdinal(number)} ");
    }
    WriteLine();
}

RunCardinalToOrdinal();

static void RunFibImperative()
{
    for (int i = 1; i <= 30; i++)
    {
        WriteLine("The {0} term of the Fibonacci sequence is {1:N0}.",
        arg0: CardinalToOrdinal(i),
        arg1: FibImperative(term: i));
    }
}


