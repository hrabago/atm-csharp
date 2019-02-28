using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		// Frank: Create ATM object and populate with loggedOut clients
        ATM myATM = new ATM();
		User userHector =  new User("hector", "password");
		 
		myATM.addNewUser("hector", userHector);
		
		//double bal = myATM.getBalance();
		
		//Console.WriteLine(myATM.getBalance());
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

public class ATM
    {
        private Dictionary<string, User> atmUsers = new Dictionary<string, User>();
		private User currentUser;
	
		private int bills_1 = 0;
		private int bills_5 = 0;
		private int bills_10 = 0;
		private int bills_20 = 500;
		private int bills_50 = 0;
		private int bills_100 = 0;


        //private int total = bills_1 ... 


        //User constructor
        public ATM(){
            //User constructor
			
        }

		public void addNewUser(string name, User user)
		{
			atmUsers.Add(name, user);	
		}
	

        //String constructor

        public void login(User user)
        {
        
        // Authenticate user login
        
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