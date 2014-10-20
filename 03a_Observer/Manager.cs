using System;
using System.Collections.Generic;


namespace bsp02
{
	class Manager
	{
		private static Manager instance;

		private List<Account> allAccounts = new List<Account> ();

		private List<IObserver> allObservers = new List<IObserver> ();


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
			notifyObserver (new EventXXX(a));
		}

		public void removeAccount(Account a)
		{
			allAccounts.Remove (a);
			notifyObserver (new EventXXX(a));
		}
		public void printAllAccounts()
		{
			foreach (Account a in allAccounts)
				Console.WriteLine (a.getName () + " " + a.getBalance ());
		}

		public void registerObserver(IObserver o)
		{
			allObservers.Add(o)
		}

		public void removeObserver(IObserver o)
		{
			allObservers.Remove(o)
		}

		public void notifyObservers()
		{
			foreach (IObserver o in allObserver)
			{
				o.update ();x
			}
		}
		

	}
}

