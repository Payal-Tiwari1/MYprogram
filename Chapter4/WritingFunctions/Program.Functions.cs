//partial class Program
//{
//    static void TimesTable(byte number, byte size = 12)
//    {
//        WriteLine($"This is the {number} times table with {size} rows:");

//        for (int row = 1; row <= size; row++)
//        {
//            WriteLine($"{row} x {number} = {row * number}");
//        }

//        WriteLine();
//    }
//}


//partial class Program
//{
//    static decimal CalculateTax(decimal amount, string twoLetterReginalCode)
//    {
//        decimal rate = 0.0M;
//        switch(twoLetterReginalCode) 
//        {
//            case "CH":  // Switzerland
//                rate = 0.08M;
//                break;
//            case "DK":  // Denmark
//            case "GB": // United Kingdom
//            case "FR": // France
//                rate = 0.2M;
//                break;
//            case "HU": // Hungary
//                rate = 0.27M;
//                break;
//            case "OR": // Oregon
//            case "AK": // Alaska
//            case "MT": // Montana
//                rate = 0.0M;
//                break;
//            case "ND": // North Dakota
//            case "WI": // Wisconsin
//            case "ME": // Maine
//            case "VA": // Virginia
//                rate = 0.05M;
//                break;
//            case "CA": // California
//                rate = 0.0825M;
//                break;
//            default: // most US states
//                rate = 0.06M;
//                break;
//        }
//        return amount * rate;
//    }
//}



partial class Program
{
    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11: // special cases for 11th to 13th
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }
}


partial class Program
{
    static int FibImperative(int term)
    {
        if (term == 1)
        {
            return 0;
        }
        else if (term == 2)
        {
            return 1;
        }
        else
        {
            return FibImperative(term - 1) + FibImperative(term - 2);
        }
    }
}





