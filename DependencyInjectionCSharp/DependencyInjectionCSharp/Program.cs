using System.Security.Principal;

namespace DependencyInjectionCSharp
{
    //// In this example, the Account class is tightly coupled with the SavingAccount and CurrentAccount classes.
    //class SavingAccount
    //{
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine("This is a saving account.");
    //    }
    //}

    //class CurrentAccount
    //{
    //    public void PrintDetails()
    //    {
    //        Console.WriteLine("This is a current account.");
    //    }
    //}

    //class Account
    //{
    //    SavingAccount savingAccount = new SavingAccount();
    //    CurrentAccount currentAccount = new CurrentAccount();

    //    public void PrintDetails()
    //    {
    //        savingAccount.PrintDetails();
    //        currentAccount.PrintDetails();
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Account account = new Account();
    //        account.PrintDetails();
    //        Console.ReadLine();
    //    }
    //}


    //// In this example, the Account class is loosely coupled with the ISavingAccount and ICurrentAccount interfaces.
    //// Constructor Injection Example
    //internal class Program
    //{
    //    public interface IAccount
    //    {
    //        void PrintDetails();
    //    }

    //    class SavingAccount : IAccount
    //    {
    //        public void PrintDetails()
    //        {
    //            Console.WriteLine("This is a saving account.");
    //        }
    //    }
    //    class CurrentAccount : IAccount
    //    {
    //        public void PrintDetails()
    //        {
    //            Console.WriteLine("This is a current account.");
    //        }
    //    }

    //    class Account
    //    {
    //        private IAccount account;

    //        public Account(IAccount account)  //Parameterisized constructor for dependency injection
    //        {
    //            this.account = account;
    //        }

    //        public void PrintAccounts()
    //        { 
    //            account.PrintDetails();
    //        }

    //    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IAccount ca = new CurrentAccount();
    //        Account a = new Account(ca);
    //        a.PrintAccounts();

    //        IAccount sa = new SavingAccount();
    //        Account a1 = new Account(sa);
    //        a1.PrintAccounts();

    //        Console.ReadLine();

    //    }
    //}


    ////Property Injection Example

    //    public interface IAccount
    //    {
    //        void PrintDetails();
    //    }

    //    class SavingAccount : IAccount
    //    {
    //        public void PrintDetails()
    //        {
    //            Console.WriteLine("This is a saving account.");
    //        }
    //    }
    //    class CurrentAccount : IAccount
    //    {
    //        public void PrintDetails()
    //        {
    //            Console.WriteLine("This is a current account.");
    //        }
    //    }

    //    class Account
    //    {
    //    public IAccount? account { get; set; }

    //        public void PrintAccounts()
    //        {
    //            account?.PrintDetails();
    //        }

    //    }

    //    internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Account sa = new Account();
    //        sa.account = new SavingAccount();
    //        sa.PrintAccounts();

    //        Account ca = new Account();
    //        ca.account = new CurrentAccount();
    //        ca.PrintAccounts();

    //        Console.ReadLine();

    //    }
    //}

    ////Method Injection Example
    public interface IAccount
    {
        void PrintDetails();
    }

    class SavingAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is a saving account.");
        }
    }
    class CurrentAccount : IAccount
    {
        public void PrintDetails()
        {
            Console.WriteLine("This is a current account.");
        }
    }

    class Account
    {
        public void PrintAccounts(IAccount account)
        {
            account.PrintDetails();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Account sa = new Account();
            sa.PrintAccounts(new SavingAccount());

            Account ca = new Account();
            ca.PrintAccounts(new CurrentAccount());

            Console.ReadLine();

        }
    }
}

