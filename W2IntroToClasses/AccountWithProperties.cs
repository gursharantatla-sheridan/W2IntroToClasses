using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2IntroToClasses
{
    public class AccountWithProperties
    {
		private double _balance;

		public double Balance
		{
			get { return _balance; }
			private set 
			{
				if (value < 0)
					throw new Exception("Amount cannot be less than zero");

				_balance = value; 
			}
		}

        public AccountWithProperties(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (amount > Balance)
                throw new Exception("Amount cannot be more than the balance");

            Balance -= amount;
        }
    }
}
