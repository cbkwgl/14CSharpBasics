using _14CSharpBasics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14CSharpBasics.Classes
{
    public class BankAccount : IInformation
    {
        private double balance;
        public double Balance
        {
            get { return balance; }
            protected set
            {
                if (value > 0)
                    balance = value;
                else
                    balance = 0;
            }
        }

        public BankAccount()
        {
            Balance = 71;
        }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        //Method Overloading: syntax will stay as is -> public double AddToBalance
        //Method Overriding: syntax will refer it as virtual
        public virtual double AddToBalance(double BalanceToBeAdded)
        {
            Balance += BalanceToBeAdded;
            return Balance;
        }

        public string GetInformation()
        {
            return $"Your Current Balance is: {Balance:c}";
        }
    }
    //Inheritance
    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 7;
        }
        public override double AddToBalance(double BalanceToBeAdded)
        {
            if(BalanceToBeAdded < 530)
            {
                return base.AddToBalance(BalanceToBeAdded);
            }
            else
            {
                return 0;
            }
        }
    }
}
