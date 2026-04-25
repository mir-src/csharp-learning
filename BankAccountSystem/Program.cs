using System;
namespace BankAccountSystem;

class Program
{
    class Helpers
    {
        public static int ReadInt()
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var output)) return output;
                else
                {
                    Console.WriteLine("Invalid number (int).");
                }
            }
        }
        public static string ReadString()
        {
            while (true) {
                var stringVar = Console.ReadLine();
                if (!string.IsNullOrEmpty(stringVar)) return stringVar;
                else
                {
                    Console.WriteLine("You didn't type anything. (Invalid string)");
                }
            }
        }
    }
    class Bank
    {
        public string Name { get; private set; }
        public int Balance { get; private set; }
        public bool Frozen { get; private set; }

        public Bank(string name, int balance, bool frozen = false)
        {
            Name = name;
            Balance = balance;
            Frozen = frozen;
        }

        public void AddMoney(int amount)
        {
            CheckFrozen();
            ValidateAmount(amount);
            Balance += amount;
        }

        public void Withdraw(int amount)
        {
            CheckFrozen();
            ValidateAmount(amount);
            CheckWithdraw(amount);
            Balance -= amount;
        }
        public int Transfer(int amount)
        {
            CheckFrozen();
            CheckWithdraw(amount);
            return amount; 
        }
        public void SwitchState()
        {
            Frozen = !Frozen;
        }

        private void ValidateAmount(int amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Invalid Amount");
        }

        private void CheckWithdraw(int amount)
        {
            if (Balance < amount)
                throw new ArgumentException("Insufficient funds");
        }

        private void CheckFrozen()
        {
            if (Frozen)
                throw new InvalidOperationException("Account is frozen");
        }

    }
    public static void Main(string[] args)
    {
        List<Bank> bankList = new List<Bank>();

        while (true) { 
            Console.Clear();
            Console.WriteLine("---Bank System---");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. Remove Account");
            Console.WriteLine("3. Add Money");
            Console.WriteLine("4. Withdraw Money");
            Console.WriteLine("5. Transfer Money");
            Console.WriteLine("6. Freeze or Unfreeze Account");
            Console.WriteLine("7. Show Accounts");
            Console.WriteLine("8. Quit Menu");

            string choice = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Enter a valid option.");
                continue;
            }
            switch (choice)
            {
                case "1":
                    Console.Write("Enter Account Name: ");
                    string c1Name = Helpers.ReadString();
                    Console.WriteLine();

                    Console.Write("Enter Balance: ");
                    int c1Balance = Helpers.ReadInt();
                    Console.WriteLine();

                    bankList.Add(new Bank(c1Name, c1Balance));
                    Console.WriteLine($"Bank Account: {c1Name} | Created");
                    Console.WriteLine($"Initial Balance: {c1Balance}");
                    break;
                case "2":
                    Console.Write("Enter Account Name: ");
                    string c2Name = Console.ReadLine();
                    Bank c2Found = bankList.Find(a => a.Name == c2Name);
                    if (c2Name == null)
                    {
                        break;
                    }
                    if (c2Found == null)
                    {
                        Console.WriteLine("The entered account doesn't exist");
                        break;
                    }
                    var removed = bankList.RemoveAll(a => a.Name == c2Name);
                    Console.WriteLine("Bank Account deleted succesfully.");

                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
                case "7":
                    break;
                case "8":
                    return;
            }
        Console.WriteLine("\n Type any key to go back to Menu...");
        Console.ReadKey();
        }
    }
}