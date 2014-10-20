using System;
using System.Collections.Generic;


namespace bsp03
{
	class Account
	{

		protected string name;
		protected  double money = 0;

		public Account (string name)
		{
			this.name = name;
		}
			
		public void deposit(double d)
		{
			money += d;
		}

		public virtual void withDraw(double d)
		{
			money -= d;
		}
		public double getBalance()
		{
			return money;
		}
		public string getName()
		{
			return name;
		}


	}
}

