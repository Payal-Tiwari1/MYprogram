namespace Packt.Shared;

public class Person : IComparable<Person?>
{
    // properties
    public string? Name { get; set; }
    public DateTime DateOfBirth { get; set; }

    // method
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
    }

    // overridden methods
    public override string ToString()
    {
        return $"{Name} is a {base.ToString()}";
    }




    public int MethodIWantToCall(string input)
    {
        return input.Length;
    }


    // delegate field
    public event EventHandler? Shout;
    // data field
    public int AngerLevel;
    // method
    public void Poke()
    {
        AngerLevel++;
        if (AngerLevel >= 3)
        {
            // if something is listening...
            if (Shout != null)
            {
                // ...then call the delegate
                Shout(this, EventArgs.Empty);
            }
        }
    }

    // Interface Example (logic) IComparable
    public int CompareTo(Person? other)
    {
        if (other is null) return -1;

        if (Name is null && other.Name is null) return 0;
        if (Name is null) return 1;
        if (other.Name is null) return -1;

        return Name.CompareTo(other.Name);
    }

    // Exception in .NET

    public void TimeTravel(DateTime when)
    {
        if (when <= DateOfBirth)
        {
            throw new PersonException("If you travel back in time to a date earlier than your own birth, then the universe will explode!");
        }
        else
        {
            WriteLine($"Welcome to {when:yyyy}!");
        }
    }
}

