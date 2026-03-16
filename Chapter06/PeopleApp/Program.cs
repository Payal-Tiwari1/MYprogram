using Packt.Shared;
using PacktLibrary;
//using static System.Runtime.InteropServices.JavaScript.JSType;

/*Person harry = new()
{
    Name = "Harry",
    DateOfBirth = new(year: 2001, month: 3, day: 25)
};

harry.WriteToConsole();

//NON GENERIC LOOK UP COLLECTION

System.Collections.Hashtable lookupObject = new();
lookupObject.Add(key: 1, value: "Payal");
lookupObject.Add(key: 2, value: "Durgesh");
lookupObject.Add(key: 3, value: "Sonal");
lookupObject.Add(key: harry, value: "Jheel");

int key = 2; // look up the value that has 2 as its key
WriteLine(format: "Key {0} has value: {1}",
arg0: key,
arg1: lookupObject[key]);

// look up the value that has harry as its key
WriteLine(format: "Key {0} has value: {1}",
arg0: harry,
arg1: lookupObject[harry]);


// generic lookup collection
Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(key: 1, value: "Alpha");
lookupIntString.Add(key: 2, value: "Beta");
lookupIntString.Add(key: 3, value: "Gamma");
lookupIntString.Add(key: 4, value: "Delta");

WriteLine(format: "Key {0} has value: {1}",
    arg0: 4,
    arg1: lookupIntString[4]);*/



//Delegate



namespace PeopleApp
{
    // Declare delegate inside namespace
    delegate int DelegateWithMatchingSignature(string s);


    partial class Program
    {

        static void Main()
        {
            // Delegate example
            Person p1 = new();

            int answer = p1.MethodIWantToCall("Frog");
            WriteLine($"Normal Call Result: {answer}");

            DelegateWithMatchingSignature d = p1.MethodIWantToCall;

            int answer2 = d("Frog");
            WriteLine($"Delegate Call Result: {answer2}");

            // Event example
            Person harry = new() { Name = "Harry" };

            // Subscribe to event
            harry.Shout += Harry_Shout;
            harry.Shout += Harry_Shout2;



            // Trigger event
            harry.Poke();
            harry.Poke();
            harry.Poke();
            harry.Poke();



            // Create array of Person objects
            Person?[] people =
            {
                null,
                new() { Name = "Simon" },
                new() { Name = "Jenny" },
                new() { Name = "Adam" },
                new() { Name = null },
                new() { Name = "Richard" }
            };

            // Call helper method   (IComparable)
            OutputPeopleNames(people, "Initial list of people:");

            // Sort the array
            Array.Sort(people);

            // Call helper method again
            OutputPeopleNames(people,
                "After sorting using Person's IComparable implementation:");


            // Comparing objects using a separate class (IComparer)

            Array.Sort(people, new PersonComparer());
            OutputPeopleNames(people,
            "After sorting using PersonComparer's IComparer implementation:");


            //Equality of types
            // Value Type (holds value)
            int a = 3;
            int b = 3;
            WriteLine($"a: {a}, b: {b}");
            WriteLine($"a == b: {(a == b)}");

            //Refrence Type (holds address) different object

            Person p = new() { Name = "Kevin" };
            Person p2 = new() { Name = "Kevin" };
            WriteLine($"p1: {p}, p2: {p2}");
            WriteLine($"p1 == p2: {(p == p2)}");

            // same address single object
            Person p3 = p;
            WriteLine($"p3: {p3}");
            WriteLine($"p1 == p3: {(p == p3)}");

            // the compair between object value
            WriteLine($"p1.Name: {p.Name}, p2.Name: {p2.Name}");
            WriteLine($"p1.Name == p2.Name: {(p.Name == p2.Name)}");


            // struct 
            DisplacementVector dv1 = new(3, 5);
            DisplacementVector dv2 = new(-2, 7);
            DisplacementVector dv3 = dv1 + dv2;
            WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X},{ dv3.Y})");

            DisplacementVector dv4 = new();
            WriteLine($"({dv4.X}, {dv4.Y})");

            //Nullable Reference Type (NRT)
            string myName = null;
            string? myName1 = null;


            // Inheriting 
            Employee john = new()
            {
                Name = "John Jones",
                DateOfBirth = new(year: 1990, month: 7, day: 28)
            };
            john.WriteToConsole();

            john.EmployeeCode = "JJ001";
            john.HireDate = new(year: 2014, month: 11, day: 23);
            WriteLine($"{john.Name} was hired on {john.HireDate:dd/MM/yy}"); 

            WriteLine(john.ToString());


            // Polymorphism
            Employee aliceInEmployee = new()
            { Name = "Alice", EmployeeCode = "AA123" };
            Person aliceInPerson = aliceInEmployee;
            aliceInEmployee.WriteToConsole();
            aliceInPerson.WriteToConsole();
            WriteLine(aliceInEmployee.ToString());
            WriteLine(aliceInPerson.ToString());

            //Casting Implicit and explicit
            /*Employee explicitAlice = (Employee)aliceInPerson;   but in future if the call could have been
                                                                Student or any other it will occure the error so we do something 
                                                                diffetent with chacking first*/

            // Using is
            if (aliceInPerson is Employee)
            {
                WriteLine($"{nameof(aliceInPerson)} IS an Employee");
                Employee explicitAlice = (Employee)aliceInPerson;
                // safely do something with explicitAlice
            }

            // Using as
            
            Employee? aliceAsEmployee = aliceInPerson as Employee; // could be null
           
            if (aliceAsEmployee is not null)
            {
                WriteLine($"{nameof(aliceInPerson)} AS an Employee");
                // safely do something with aliceAsEmployee
            }


            // .NET Exception

            try
            {
                john.TimeTravel(when: new(1999, 12, 31));
                john.TimeTravel(when: new(1950, 12, 25));
            }
            catch (PersonException ex)
            {
                WriteLine(ex.Message);
            }

            //Regular Extentions (like emails) String Extentions

            string email1 = "payal@test.com";
            string email2 = "ian&test.com";
            WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email1,
            arg1: StringExtensions.IsValidEmail(email1));
            WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email2,
            arg1: StringExtensions.IsValidEmail(email2));



            WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email1,
            arg1: email1.IsValidEmail());
            WriteLine("{0} is a valid e-mail address: {1}",
            arg0: email2,
            arg1: email2.IsValidEmail());

        }


        

        // Event handler method
        static void Harry_Shout(object? sender, EventArgs e)
        {
            if (sender is Person p)
            {
                WriteLine($"{p.Name} is this angry: {p.AngerLevel}.");
            }
        }


        static void Harry_Shout2(object? sender, EventArgs e)
        {
            if (sender is Person p)
            {
                WriteLine($" Warning! {p.Name} is very angry now! Level: {p.AngerLevel}");
            }
        
        
        
        }


        
    }
}
     


