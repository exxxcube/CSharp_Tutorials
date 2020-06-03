using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace SimpleSavingsAccount
{
    // BankAccount -- Simulate a bank account, each of which
    // carries an account ID (which is assigned
    // on creation) and a balance.
    internal class BankAccount // The base class
    {
        // Bank accounts start at 1000 and increase sequentially.
        public static int _nextAccountNumber = 1000;
        // Maintain the account number and balance for each object.
        public int _accountNumber;
        public decimal _balance;
        // Init -- Initialize a bank account with the next account ID and the
        // specified initial balance (default to zero).
        public void InitBankAccount()
        {
            InitBankAccount(0);
        }
        public void InitBankAccount(decimal initialBalance)
        {
            _accountNumber = ++_nextAccountNumber;
            _balance = initialBalance;
        }
        // Balance property.
        public decimal Balance { get { return _balance; } }
        // Deposit -- any positive deposit is allowed.
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                _balance += amount;
        }
        // Withdraw -- You can withdraw any amount up to the
        // balance; return the amount withdrawn.
        public decimal Withdraw(decimal withdrawal)
        {
            if (Balance <= withdrawal)
                withdrawal = Balance;
            _balance -= withdrawal;
            return withdrawal;
        }
        // ToString - Stringify the account.
        public string ToBankAccountString()
        {
            return String.Format("{0} - {1:C}", _accountNumber, Balance);
        }
    }
    // SavingsAccount -- A bank account that draws interest
    internal class SavingsAccount : BankAccount // The subclass
    {        
        public decimal _interestRate;
        // InitSavingsAccount -- Input the rate expressed as a
        // rate between 0 and 100.
        public void InitSavingsAccount(decimal interestRate)
        {
            InitSavingsAccount(0, interestRate);
        }
        public void InitSavingsAccount(decimal initialBalance, decimal interestRate)
        {
            InitBankAccount(initialBalance); // Note call to base class.
            this._interestRate = interestRate / 100;
        }
        // AccumulateInterest -- Invoke once per period.
        public void AccumulateInterest()
        {
            _balance = Balance + (decimal)(Balance * _interestRate);
        }
        // ToString -- Stringify the account.
        public string ToSavingsAccountString()
        {
            return String.Format("{0} ({1}%)", ToBankAccountString(), _interestRate * 100);
        }
    }
    #region Gaining access to BankAccount by using containment
    // The idea of containment in object-oriented programming is the idea that
    // an outer class contains an instance of another class and
    // allows access to the contained object through its own methods.
    // Aggregation is one form of containment where the contained object can
    // exist independently from the outer object.

    // SavingsAccount -- A bank account that draws interest
    internal class SavingsAccount_  // Notice the underscore: this isn’t
    {                               // the SavingsAccount class.

        public BankAccount _bankAccount;    // Notice this, the contained BankAccount.                
        public decimal _interestRate;
        // InitSavingsAccount -- Input the rate expressed as a
        // rate between 0 and 100.
        public void InitSavingsAccount(BankAccount bankAccount, decimal interestRate)
        {            
            this._bankAccount = bankAccount;
            this._interestRate = interestRate / 100;
        }
        // AccumulateInterest -- Invoke once per period.
        public void AccumulateInterest()
        {
            _bankAccount._balance += (_bankAccount.Balance * _interestRate);
        }
        // Deposit -- Any positive deposit is allowed.
        public void Deposit(decimal amount)
        {
            // Delegate to the contained BankAccount object.
            _bankAccount.Deposit(amount);
        }
        // Withdraw -- You can withdraw any amount up to the
        // balance; return the amount withdrawn.
        public double Withdraw(decimal withdrawal)
        {
            return (double)_bankAccount.Withdraw(withdrawal);
        }
    }
    #endregion
    public class SimpleSavingsAccountClass
    {
        #region An example of IS_A relationship
        // DirectDeposit -- Deposit my paycheck automatically.
        private static void DirectDeposit(BankAccount ba, decimal pay)
        {
            ba.Deposit(pay);
        }
        #endregion
        public static void SimpleSavingsAccountClassMain()
        {            
            // Create a bank account and display it.
            BankAccount ba = new BankAccount();
            ba.InitBankAccount(100M); // M suffix indicates decimal.
            #region An example of IS_A relationship            
            DirectDeposit(ba, 100M);
            #endregion
            Console.WriteLine("Account {0}", ba.ToBankAccountString());
            // Now a savings account
            SavingsAccount sa = new SavingsAccount();
            sa.InitSavingsAccount(100M,12.5M);
            #region An example of IS_A relationship 
            DirectDeposit(sa, 100M);
            #endregion            
            sa.AccumulateInterest();
            Console.WriteLine("Account {0}",sa.ToSavingsAccountString());
            // Wait for user to acknowledge the results.
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
