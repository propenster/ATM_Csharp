using System;


namespace ATM.AtM_Csharp
{

	//List of all available matches as Enum... 
//Will be refactored to a single class later...

public Enum matchesAvailable = 
{ 
	ManUtd_vs_Chelsea, 
	Wolvesburg_vs_Tottenham, 
	Arsenal_vs_Liverpool, 
	NewCastle_vs_Burnley, 
	ManCity_vs_Leicester

};


class User{

/** private long UserId;
// private string FullName;
// private string Email;
// private string Password;
// private decimal UserBalance;
// public Enum MatchesAvailable = { ManUtd_vs_Chelsea, Wolvesburg_vs_Tottenham, Arsenal_vs_Liverpool, NewCastle_vs_Burnley, ManCity_vs_Leicester


// }

//List<Match> matches;

public User(long id, string fullName, string email, string password, decimal balance) 
{
	this.UserId = id;
	this.FullName = fullName;
	this.Email = email;
	this.Password = password;
	this.UserBalance = BalanceProperty;

}

*/

public long UserId{ get; set;}
public string FullName{ get; set;}
public string Email{ get; set; }
public string Password { get; set; }
public decimal BalanceProperty
{
	if(UserBalance < 0){
	UserBalance = 0; }
	return UserBalance = value;
}
public MatchesAvailable { get; set; }

//User-level Methods downl here..
public static void viewMatches()
{
	foreach(Enum  match in  matchhesAvailable)
	{
		Console.WriteLine(match);
	}

}

public void BookTicket(string matchId, int quantity)
{
	CONST TICKET_PRICE = 1000
	Console.Write("You will be charged NGN {0} for booking a ticket of Match {1} ", this.BalanceProperty-(TICKET_PRICE*quantity), matchId);
}

public void fundMyAccount(decimal Amount)
{
	if(!(Amount<0))
	{
		BalanceProperty +=Amount;
	}
	else
	{
		Console.WriteLine("Error 000211XX: !Deposit Failed! You cannot deposit an amount less than NGN1:00");
	}


}

@override
public void ToString()
{
	// ToString method implementation Here!....
}

}
}
}
