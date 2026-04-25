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
            if (CheckFrozen() == "valid" && ValidateAmount(amount) == "valid")
            {
                Balance += amount;
                Console.WriteLine("Money added succesfully.");
            }
            else
            {
                Console.WriteLine("Couldn't add money.");
            }
        }

        public void Withdraw(int amount)
        {
            if (CheckFrozen() == "valid" && ValidateAmount(amount) == "valid" && CheckWithdraw(amount) == "valid")
            {
                Balance -= amount;
                Console.WriteLine("Money withdrawn succesfully.");
            }
            else
            {
                Console.WriteLine("Couldn't withdraw money.");
            }
        }
        public int Transfer(int amount)
        {
            if (CheckFrozen() == "valid" && CheckWithdraw(amount) == "valid")
            {
                return amount; 
            }
            else
            {
                return 0;
            }
        }
        public void SwitchState()
        {
            Frozen = !Frozen;
        }

        private string ValidateAmount(int amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Invalid amount");
                return "invalid";
            }
            else
            {
                return "valid";
            }
        }

        private string CheckWithdraw(int amount)
        {
            if (Balance < amount)
            {
                return "invalid";
            }
            else
            {
                return "valid";
            }
        }

        private string CheckFrozen()
        {
            if (Frozen)
            {
                Console.WriteLine("Can't procced. Account is frozen.");
                return "invalid";
            }
            else
            {
                return "valid";
            }
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
                    string c2Name = Helpers.ReadString();
                    Bank c2Found = bankList.Find(a => a.Name == c2Name);

                    if (c2Found == null)
                    {
                        Console.WriteLine("The entered account doesn't exist");
                        break;
                    }
                    var removed = bankList.RemoveAll(a => a.Name == c2Name);
                    Console.WriteLine("Bank Account deleted succesfully.");

                    break;
                case "3":
                    Console.Write("Enter account name: ");
                    string c3Name = Helpers.ReadString();
                    Console.WriteLine();

                    Bank c3Found = bankList.Find(a => a.Name == c3Name);
                    if (c3Found == null)
                    {
                        Console.WriteLine("The entered account doesn't exist");
                        break;
                    }

                    Console.Write("Enter amount to deposit: ");
                    int c3Amount = Helpers.ReadInt();
                    c3Found.AddMoney(c3Amount);

                    break;
                case "4":
                    Console.Write("Enter account name: ");
                    string c4Name = Helpers.ReadString();
                    Console.WriteLine();

                    Bank c4Found = bankList.Find(a => a.Name == c4Name);
                    if (c4Found == null)
                    {
                        Console.WriteLine("The entered account doesn't exist");
                        break;
                    }
                    Console.Write("Enter amount to withdraw: ");
                    int c4Amount = Helpers.ReadInt();
                    c4Found.Withdraw(c4Amount);

                    break;
                case "5":
                    break;
                case "6":
                    Console.Write("Enter account name: ");
                    string c6Name = Helpers.ReadString();
                    Console.WriteLine();

                    Bank c6Found = bankList.Find(a => a.Name == c6Name);
                    if (c6Found == null)
                    {
                        Console.WriteLine("Account doesn't exist.");
                        break;
                    }
                    else
                        c6Found.SwitchState();

                    Console.WriteLine($"Frozen Status: {c6Found.Frozen}");
                    
                    break;
                case "7":
                    foreach (Bank account in bankList)
                    {
                        Console.WriteLine($"Account: {account.Name} | Balance: {account.Balance} | Frozen Status: {account.Frozen}");
                    }
                    break;
                case "8":
                    return;
            }
        Console.WriteLine("\n Type any key to go back to Menu...");
        Console.ReadKey();
        }
    }
}