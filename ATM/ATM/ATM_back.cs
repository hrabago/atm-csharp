using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		// Frank: Create ATM object and populate with loggedOut clients
        ATM_Object myATM = new ATM_Object();
		User userHector =  new User("hector", "passwordH");
		User userFrank = new User("frank", "passwordF");
        User userMaddy = new User("maddy", "passwordM");
		 
		myATM.addNewUser("hector", userHector);
		myATM.addNewUser("frank", userFrank);
		myATM.addNewUser("maddy", userMaddy);
	}
}

public class User{
	
	public String name;
    private String pw;
	private bool loggedIn;
	private int balance;
	// Tupples of the form: (date, deposit/withdrawal, amount, balance after transaction)
	private List<(DateTime, string, string, string)> list = new List<(DateTime, string, string, string)>(); 
	
	// Default Constructor
	public User(String user, String password){
		name = user;
		pw = password;
		loggedIn = false;
		balance = 100;
	}
	
	// Toggle LoggedIn Status (decides whether parameters can be accessed)
	public bool authUser(){
		
		return true;
	}
	
	 // Get the user's current balance
	 public double getBalance()
     {
			return balance;
      }

    public void addToBalance(int deposit_amount)
    {
        balance += deposit_amount;

    }
	public void subFromBalance(int deposit_amount)
    {
        balance -= deposit_amount;

    }

}

public class ATM_Object
    {
        private Dictionary<string, User> atmUsers = new Dictionary<string, User>();
		private User currentUser;
	
		private int bills_1 = 0;
		private int bills_5 = 0;
		private int bills_10 = 0;
		private int bills_20 = 500;
		private int bills_50 = 0;
		private int bills_100 = 0;

        //User constructor
        public ATM_Object(){
            //User constructor	
        }

		public void addNewUser(string name, User user)
		{
			atmUsers.Add(name, user);	
		}
	
		// Authenticate user login
        public void login(String name, String password)
        {
        	currentUser = atmUsers[name];
        }
	
		// Clear current active user
        public void logout()
        {
			currentUser = null;
        }

		// Retrives current logged in user balance
        public double getCurrentUserBalance()
        {
            return this.currentUser.getBalance();
        }
		
		//decrease user balance
        public void withdrawFunds(int amount)
        {
            this.currentUser.subFromBalance(amount);
			bills_100 -= amount / 100;
			amount = amount % 100;
			bills_50 -= amount / 50;
			amount %= 50;
			bills_20 -= amount / 20;
			amount %= 20;
			bills_10 -= amount / 10;
			amount %= 10;
			bills_5 -= amount / 5;
			amount %= 5;
			bills_1 -= amount;
        }
	
        public void depositFunds(int amount)
        {
			this.currentUser.addToBalance(amount);
			bills_100 += amount / 100;
			amount = amount % 100;
			bills_50 += amount / 50;
			amount %= 50;
			bills_20 += amount / 20;
			amount %= 20;
			bills_10 += amount / 10;
			amount %= 10;
			bills_5 += amount / 5;
			amount %= 5;
			bills_1 += amount;
        }
	
	public static void Main()
	{
		
	}

 }