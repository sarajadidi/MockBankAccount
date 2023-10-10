using System;
namespace MockBankAccount
{
	public class SamBankAccount
	{
		public SamBankAccount()
		{
		}

        private double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double withdrawl)
        {
            balance -= withdrawl;
        }

        public string GetBalance()
        {
            return $"${balance}";
        }
    }
}

