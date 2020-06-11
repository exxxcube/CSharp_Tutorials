using System;
using System.Collections.Generic;
using System.Text;

namespace SealingAClass
{
    public class BankAccount
    {
        // Withdrawal -- You can withdraw any amount up to the
        // balance; return the amount withdrawn
        public virtual void Withdraw(decimal withdrawal)
        {
            Console.WriteLine("invokes BankAccount.Withdraw()");
        }
    }
    public sealed class SavingsAccount : BankAccount
    {
        public override void Withdraw(decimal withdrawal)
        {
            Console.WriteLine("invokes SavingsAccount.Withdraw()");
        }
    }
    public class SpecialSaleAccount : SavingsAccount //Error
    {
        override public void Withdraw(decimal withdrawal)
        {
            Console.WriteLine("invokes SpecialSaleAccount.Withdraw()");
        }
    }
}
