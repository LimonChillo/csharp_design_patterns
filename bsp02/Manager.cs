using System;
using System.Collections.Generic;


namespace bsp02
{
	class Manager
	{
		private static Manager instance;

		private List<Account> allAccounts = new List<Account> ();

		private Manager ()
		{

		}


		public static Manager getInstance()
		{
			if (instance == null) 
			{
				instance = new Manager ();
			}
			return instance;
		}

		public void addAccount(Account a)
		{
			allAccounts.Add (a);
		}

		public void removeAccount(Account a)
		{
			allAccounts.Remove (a);
		}
		public void printAllAccounts()
		{
			foreach (Account a in allAccounts)
				Console.WriteLine (a.getName () + " " + a.getBalance ());
		}
		

	}
}

