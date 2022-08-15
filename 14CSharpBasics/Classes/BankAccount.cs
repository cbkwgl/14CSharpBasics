using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14CSharpBasics.Classes
{
    public class BankAccount
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

        //Method Overloading
        public double AddToBalance(double BalanceToBeAdded)
        {
            Balance += BalanceToBeAdded;
            return Balance;
        }

        
    }
    //Inheritance
    public class ChildBankAccount : BankAccount
    {
        public ChildBankAccount()
        {
            Balance = 7;
        }
    }
}
