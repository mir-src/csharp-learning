using System;
namespace BankAccountSystem;

class Program
{
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

        Console.WriteLine("\n Type any key to go back to Menu...");
        Console.ReadKey();
    }
}

/// class BankAccounts  
/// account name (string) public 
/// account balance (int) private 
/// account frozen (bool) private

/// Add money - Withdraw money - Transfer money between two accounts 
/// Remove account - Create account - Toggle frozen account switch 

/// Display menu and options