using System;
using System.Linq;


namespace ATM.src
{
	class Program 
	{

		public static void Main(string[] args)
		{
			User user1 = new User(0001, "Faith Olusegun", "faitholusegun60@gmail.com", "user123456", 120000, MatchesAvailable.ManUtd_vs_Chelsea);
			//User should view all available matchs
			ViewMatches();

			//Then Check my balance see if You have enough to book a ticket...
			user1.UserBalance();
		}
	}
}