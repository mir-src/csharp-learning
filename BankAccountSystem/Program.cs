using System;
namespace BankAccountSystem;

class Program
{
    class Helpers
    {
        public static int ReadInt()
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out var output)) return output;
            else throw new ArgumentException("Invalid int");
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
        Console.Clear();
        Console.WriteLine("---Bank System---");
        Console.WriteLine("1. Create Account");
        Console.WriteLine("2. Remove Account");
        Console.WriteLine("3. Add Money");
        Console.WriteLine("4. Withdraw Money");
        Console.WriteLine("5. Transfer Money");
        Console.WriteLine("6. Freeze or Unfreeze Account");
        Console.WriteLine("7. Quit Menu");

        List<Bank> bankList = new List<Bank>();

        while (true) { 
            string choice = Console.ReadLine()?.Trim();
            if (string.IsNullOrEmpty(choice))
            {
                Console.WriteLine("Enter a valid option.");
                continue;
            }
            switch (choice)
            {
                case "1":
                    Console.Write("Enter name of account: ");
                    string c1Name = Console.ReadLine();
                    Console.WriteLine();

                    if (string.IsNullOrEmpty(c1Name))
                    {
                        Console.WriteLine("Invalid account name.");
                        break;
                    }

                    Console.Write("Enter current Balance: ");
                    int c1Input = Helpers.ReadInt();
                    try
                    {
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                        break;
                    }
                    int c1Balance = c1Input;
                    Console.WriteLine();

                    bankList.Add(new Bank(c1Name,c1Balance));
                    Console.WriteLine($"Bank Account: {c1Name} | Created");

                    break;
                case "2":
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
                    return;
            }
            break;
        }

        Console.WriteLine("\n Type any key to go back to Menu...");
        Console.ReadKey();
        
    }
}