using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2IntroToClasses
{
    public class AccountWithMethods
    {
        // field
        private double _balance;

        // constructor
        public AccountWithMethods(double balance)
        {
            _balance = balance;
        }

        // getter / setter
        public double GetBalance()
        {
            return _balance;
        }

        public void SetBalance(double amount)
        {
            _balance = amount;
        }

        // methods
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }
    }
}
