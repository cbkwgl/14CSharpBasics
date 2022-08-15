using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Importing a new class file
using _14CSharpBasics.Classes;

namespace _14CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[] { 1, 2, 3, 6, 7 };
            var result = simpleMath.Add(numbers);
            Console.WriteLine(result);

            //Object Definition -> this is how you refer to a class
            BankAccount bankAccount = new BankAccount();
            Console.WriteLine(bankAccount.Balance);
            bankAccount.AddToBalance(134);
            Console.WriteLine(bankAccount.Balance);

            BankAccount bankAccount2 = new BankAccount(300);
            Console.WriteLine(bankAccount2.Balance);
            bankAccount2.AddToBalance(134);
            Console.WriteLine(bankAccount2.Balance);

            ChildBankAccount childBankAccount = new ChildBankAccount();
            Console.WriteLine(childBankAccount.Balance);
            childBankAccount.AddToBalance(134);
            Console.WriteLine(childBankAccount.Balance);

            ChildBankAccount childBankAccount2 = new ChildBankAccount();
            Console.WriteLine(childBankAccount2.Balance);
            childBankAccount2.AddToBalance(534);
            Console.WriteLine(childBankAccount2.Balance);

        }
    }
    class simpleMath
    {
        public static double Add(double n1, double n2)
        {
            return n1 + n2;
        }

        public static double Add(double[] numbers)
        {
            double Result = 0;
            foreach (double number in numbers)
            {
                Result += number;
            }
            return Result;

        }
    }
}
