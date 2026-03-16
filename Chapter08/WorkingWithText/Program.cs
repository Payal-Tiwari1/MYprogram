
//Getting the length of a string
string city = "Nagpur";
WriteLine($"{city} is {city.Length} charactor length.");


//Getting the characters of a string
WriteLine($"First charactor is {city[0]} and Fouth charactor is {city[3]}.");


//Splitting a string
string cities = "Paris,Tehran,Chennai,Sydney,New York,Medellín";
string[] citiesArray = cities.Split(',');

WriteLine($"the length of the array is {citiesArray.Length}.");
foreach(string item in citiesArray)
{
    WriteLine(item);
}



//Getting part of a string
string fullName = "Payal Tiwari";

int indexOfSpace  = fullName.IndexOf(' ');
string firstName = fullName.Substring(startIndex: 0,length: indexOfSpace);
string lastName = fullName.Substring(startIndex: indexOfSpace + 1);

WriteLine($"Original Name: {fullName}");
WriteLine($"Swapped Name: {lastName} {firstName}");


//Checking a string for content
string company = "Microsoft";
bool startsWithM = company.StartsWith("M");
bool containsN = company.Contains("N");
WriteLine($"Company name starts with M:{startsWithM}, Containing N:{containsN}");


/*Add statements to take an array of string values and combine them back together into a single
string variable with separators using the Join method*/
string recombined = string.Join(" , ", citiesArray);
WriteLine(recombined);

/* use positioned parameters and interpolated string formatting syntax to
output the same three variables twice*/
string fruitName = "Orange";
decimal price = 200M;
DateTime when = DateTime.Today;

WriteLine($"Interpolated: The price of {fruitName} is {price:C} on {when}");
WriteLine(string.Format("String.Format: The price of {0} is {1:C} on {2:dddd}", arg0:fruitName, arg1:price, arg2:when));

