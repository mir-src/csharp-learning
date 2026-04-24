using System;
namespace BankAccountSystem;

class Program
{
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
        Bank account = new Bank("Cornelia", 100);
        Bank secondAccount = new Bank("Iulian", 100);
        Console.WriteLine(account.Name);
        Console.WriteLine(account.Balance);
        Console.WriteLine(account.Frozen);

        Console.WriteLine("---------");
        account.AddMoney(200);
        Console.WriteLine(account.Balance);

        account.SwitchState();
        account.SwitchState();

        try
        {
            account.Withdraw(600);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        Console.WriteLine(account.Balance);

        Console.WriteLine($"Name: {account.Name} | {account.Balance}");
        Console.WriteLine($"Name: {secondAccount.Name} | {secondAccount.Balance}");

        try
        {
            account.Transfer(200);
            account.Withdraw(200);
            secondAccount.AddMoney(200);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Name: {account.Name} | {account.Balance}");
        Console.WriteLine($"Name: {secondAccount.Name} | {secondAccount.Balance}");

        


        




        
        /*
        Console.Clear();
        Console.WriteLine("---Bank System---");
        Console.WriteLine("1. Create Account");
        Console.WriteLine("2. Remove Account");
        Console.WriteLine("3. Add Money");
        Console.WriteLine("4. Withdraw Money");
        Console.WriteLine("5. Transfer Money");
        Console.WriteLine("6. Freeze or Unfreeze Account");
        Console.WriteLine("7. Quit Menu");

        Console.WriteLine("\n Type any key to go back to Menu...");
        Console.ReadKey();
        */
    }
}

/// class BankAccounts  
/// account name (string)  
/// account balance (int)  
/// account frozen (bool) 

/// Add money - Withdraw money - Transfer money between two accounts 
/// Remove account - Create account - Toggle frozen account switch 

/// Display menu and options