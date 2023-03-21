using System;
namespace BankEncapsulation
{
	public class BankAccount
	{
		public BankAccount()
		{
		}

		private double _balance = 0;

		public void Deposit(double amount)
		{
			_balance += amount; //_balance = _balanca + amount;
			Console.WriteLine("Deposit Accepted");
		}

		public void GetBalance()
		{
			Console.WriteLine($"Current Account Balance:");
			Console.WriteLine($"${_balance}");
		}

		//public double GetBalance()
		//{
		//	return _balance;
		//}
	}
}

