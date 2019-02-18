using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
		ATM myATM = new ATM("hector","password");
		
		//double bal = myATM.getBalance();
		
		Console.WriteLine(myATM.getBalance());
	}
}

public class User{
	
	private String usr;
    private String pw;
	
	private Double balance;

	public User(String user, String password){
	
	}
	
	
	
	public bool authUser(){
		
		return true;
	}
	
	 public double getBalance()
     {


			return balance;

      }

}

public class ATM
    {
	


        private String usr;
        private String pw;
		private User Usr;
	
		private int bills_1 = 0;
		private int bills_5 = 0;
		private int bills_10 = 0;
		private int bills_20 = 500;
		private int bills_50 = 0;
		private int bills_100 = 0;
	
	
        public ATM(String user, String password){
            //constructor

            //sample usr

            usr = user;
            pw = password;
		


			Usr = new User(usr,pw);
			
			
			
        }

        public void login(){
        
        
        
        }
        public void logout()
        {



        }


        public double getBalance()
        {


			return 0.00 ;

        }
        public void withdrawCash()
        {
            //decrease user balance


        }
        public void depositFunds()
        {
           // increase user balance


        }
	
	public static void Main()
	{
		
	}

 }