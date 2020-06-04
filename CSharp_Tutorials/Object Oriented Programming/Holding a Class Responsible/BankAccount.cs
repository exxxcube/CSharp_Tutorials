using SimpleSavingsAccount;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace CSharp_Tutorials.Object_Oriented_Programming.Holding_a_Class_Responsible
{
    #region BankAccountMain using double data type
    //// BankAccount -- Create a bank account using a double variable
    //// to store the account balance (keep the balance in a private
    //// variable to hide its implementation from the outside world).
    //// Note: Until you correct it, this program fails to compile
    //// because Main() refers to a private member of class BankAccount.
    //class BankAccountMain
    //{
    //    public static void BackAccountProg()
    //    {
    //        //Console.WriteLine("This program doesn’t compile in its present state.");
    //        // Open a bank account.
    //        Console.WriteLine("Create a bank account object");
    //        BankAccount ba = new BankAccount();
    //        ba.InitBankAccount();
    //        // Make a deposit.
    //        double deposit = 123.454;
    //        Console.WriteLine("Depositing {0:C}", deposit);
    //        ba.Deposit(deposit);
    //        // Account balance
    //        Console.WriteLine("Account = {0}", ba.GetString());
    //        // Here’s the problem.
    //        double fractionalAddition = 0.002;
    //        Console.WriteLine("Adding {0:C}", fractionalAddition);
    //        ba.Deposit(fractionalAddition);
    //        Console.WriteLine("Resulting account = {0}", ba.GetString());
    //        // Resulting balance
    //        //// Accessing the balance via the Deposit() method is okay --
    //        //// Deposit() has access to all the data members.
    //        //ba.Deposit(10);
    //        //// Accessing the data member directly is a compile-time error.
    //        //Console.WriteLine("Just in case you get this far the following is "
    //        //                   + "supposed to generate a compile error");
    //        //ba._balance += 10;                     // This is a compile error
    //        // Wait for user to acknowledge the results.
    //        Console.WriteLine("Press Enter to terminate...");
    //        Console.Read();
    //    }
    //}
    //// BankAccount -- Define a class that represents a simple account
    //public class BankAccount
    //{
    //    private static int _nextAccountNumber = 1000;
    //    private int _accountNumber;
    //    // Maintain the balance as a double variable.
    //    private double _balance;
    //    // Init -- Initialize a bank account with the next
    //    // account id and a balance of 0.
    //    public void InitBankAccount()
    //    {
    //        _accountNumber = ++_nextAccountNumber;
    //        _balance = 0.0;
    //    }
    //    // GetBalance -- Return the current balance.
    //    public double GetBalance()
    //    {
    //        return _balance;
    //    }
    //    // AccountNumber
    //    public int GetAccountNumber()
    //    {
    //        return _accountNumber;
    //    }
    //    public void SetAccountNumber(int accountNumber)
    //    {
    //        this._accountNumber = accountNumber;
    //    }
    //    // Deposit -- Any positive deposit is allowed.
    //    public void Deposit(double amount)
    //    {
    //        if (amount > 0.0)
    //            _balance += amount;
    //    }
    //    // Withdraw -- You can withdraw any amount up to the
    //    // balance; return the amount withdrawn.
    //    public double Withdraw(double withdrawal)
    //    {
    //        if (_balance <= withdrawal)
    //            withdrawal = _balance;
    //        _balance -= withdrawal;
    //        return withdrawal;
    //    }
    //    // GetString -- Return the account data as a string.
    //    public string GetString()
    //    {
    //        string s = String.Format("#{0} = {1:C}", GetAccountNumber(), GetBalance());
    //        return s;
    //    }
    //}
    #endregion
    #region BankAccountMain modified using Decimal.Round
    class DecimalBankAccount
    {
        public static void DecimalBankAccountProg()
        {
            int value = BankAccount.NextAccountNumber; // NextAccountNumber is a static property
            // Open a bank account.
            Console.WriteLine("Create a bank account object");
            BankAccount ba = new BankAccount();
            // Set the account number property.
            ba.AccountNumber = 1001;
            ba.InitBankAccount();
            // Make a deposit.
            double deposit = 123.454;
            Console.WriteLine("Depositing {0:C}", deposit);
            ba.Deposit(deposit);
            // Account balance
            Console.WriteLine("Account = {0}", ba.GetString());
            // Here’s the problem.
            double fractionalAddition = 0.002;
            Console.WriteLine("Adding {0:C}", fractionalAddition);
            ba.Deposit(fractionalAddition);
            // Get both properties.
            //Console.WriteLine("#{0} = {1:C}",ba.AccountNumber,ba.Balance);
            Console.WriteLine("Resulting account = #{0} = {1:C}", ba.AccountNumber, ba.Balance);
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
    // BankAccount -- Define a class that represents a simple account.
    public class BankAccount
    {
        private static int _nextAccountNumber = 1000;
        // NextAccountNumber is an example of static Property
        public static int NextAccountNumber { get { return _nextAccountNumber; } }
        private int _accountNumber;
        // Maintain the balance as a double variable.
        private decimal _balance;
        // Init -- Initialize a bank account with the next
        // account id and a balance of 0.
        public void InitBankAccount()
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = 0;
        }
        public double Balance // This Example is a Balance property
        {                     // Property begins in Capital letter
            get { return (double)_balance; }
        }
        // TIP
        // Use properties to access class data members, even from methods in the same class.
        public int GetAccountNumber         // This Example is a GetAccountNumber property
        {                                   // Property begins in Capital letter
            get { return _accountNumber; }
        }       
        public int AccountNumber            // No parentheses here.
        {
            get { return _accountNumber; }  // The “read” part. Curly braces and semicolon.
            set { _accountNumber = value; } // The “write” part. ‘value’ is a keyword.
        }
        // Deposit -- Any positive deposit is allowed.
        public void Deposit(double amount)
        {
            if (amount > 0.0)
            {
                // Round off the double to the nearest cent before depositing.
                decimal temp = (decimal)amount;
                temp = Decimal.Round(temp, 2);
                _balance += temp;
            }
        }
        // Withdraw -- You can withdraw any amount up to the
        // balance; return the amount withdrawn.
        public double Withdraw(double withdrawal)
        {
            // Convert to decimal and work with the decimal version.
            decimal decWithdrawal = (decimal)withdrawal;
            if (_balance <= decWithdrawal)
                decWithdrawal = _balance;
            _balance -= decWithdrawal;
            return (double)decWithdrawal; // Return a double.
        }
        // GetString -- Return the account data as a string.
        public string GetString()
        {
            string s = String.Format("#{0} = {1:C}", GetAccountNumber, Balance);
            return s;
        }
    }    
    #endregion
}
