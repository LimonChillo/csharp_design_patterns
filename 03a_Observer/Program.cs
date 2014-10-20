using System;

namespace bsp03
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			var Account1 = new Account ("Herbert");
			var Account2 = new Account ("Anton");
			var Account3 = new StudentAccount ("David");

			Account1.deposit (12898.09);
			Account2.deposit (17379.09);

			Account1.withDraw (722.09);
			Account2.withDraw (797.09);

			Console.WriteLine(Account1.getBalance ());
			Console.WriteLine(Account2.getBalance ());

			try
			{
				Account3.deposit (722.09);
				Account3.withDraw (797.09);
			}
			catch(InvalidOperationException e) 
			{
				Console.WriteLine ("this was Expected  " + e.Message);
			}



			Manager m = Manager.getInstance ();

			m.addAccount (Account1);
			m.addAccount (Account2);
			m.addAccount (Account3);

			m.printAllAccounts ();

		}
	}
}
