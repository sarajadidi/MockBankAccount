using System;
namespace MockBankAccount
{
	public class SamBankAccount
	{
		public SamBankAccount()
		{
		}

        private double balance = 1000;

        public void Deposit(double amount)
        {
            balance = amount;
        }

        public void Withdraw(double amount)
        {
            balance = amount;
        }

        public string GetBalance()
        {
            return $"${balance}";
        }
    }
}

