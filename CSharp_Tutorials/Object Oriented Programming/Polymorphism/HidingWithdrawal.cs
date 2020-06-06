using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace HidingWithdrawal
{
    // BankAccount -- A very basic bank account
    public class BankAccount
    {
        protected decimal _balance;
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }
        public decimal Balance { get { return _balance; } }
        public decimal Withdraw(decimal amount)
        {
            // Good practice means avoiding modifying an input parameter.
            // Modify a copy.
            decimal amountToWithdraw = amount;
            if (amountToWithdraw > Balance)
                amountToWithdraw = Balance;
            _balance -= amountToWithdraw;
            return amountToWithdraw;
        }
    }
    // SavingsAccount -- A bank account that draws interest
    public class SavingsAccount : BankAccount
    {
        public decimal _interestRate;
        // SavingsAccount -- Input the rate expressed as a
        // rate between 0 and 100.
        public SavingsAccount(decimal initialBalance, decimal interestRate) : base(initialBalance)
        {
            _interestRate = interestRate / 100;
        }
        // AccumulateInterest -- Invoke once per period.
        public void AccumulateInterest()
        {
            _balance = Balance + (Balance * _interestRate);
        }
        // Withdraw -- You can withdraw any amount up to the
        // balance; return the amount withdrawn.
        public new decimal Withdraw(decimal withdrawal)
        {
            // Take the $1.50 off the top.
            base.Withdraw(1.5M);
            // Now you can withdraw from what’s left.
            return base.Withdraw(withdrawal);
        }
    }
    public class HidingWithdrawalClass
    {
        public static void MakeAWithdrawal(BankAccount ba, decimal amount)
        {
            // This is an example of Polymorphism
            // which  refers to the general ability to decide which method to
            // invoke at runtime.
            if (ba is SavingsAccount) // use is keyword
            {
                //SavingsAccount sa = (SavingsAccount)ba;
                //sa.Withdraw(amount);
                //or you can use this code below
                ((SavingsAccount)ba).Withdraw(amount);
            }
            else
            {
                ba.Withdraw(amount);
            }
        }
        public static void HidingWithdrawalMain()
        {
            BankAccount ba;
            SavingsAccount sa;
            // Create a bank account, withdraw $100, and
            // display the results.
            ba = new BankAccount(200M);
            MakeAWithdrawal(ba, 100M);
            // Try the same trick with a savings account.
            sa = new SavingsAccount(200M, 12);
            MakeAWithdrawal(sa, 100M);
            // Display the resulting balance.
            Console.WriteLine("When invoked directly:");
            Console.WriteLine("BankAccount balance is {0:C}",ba.Balance);
            Console.WriteLine("SavingsAccount balance is {0:C}",sa.Balance);
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
