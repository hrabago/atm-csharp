					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
		
        myusr = User("hector", "password")
        ATM myATM = new ATM("hector","password");
		
		//double bal = myATM.getBalance();
		
		Console.WriteLine(myATM.getBalance());
	}
}

public class User{
	
	private String name;
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

    public void addToBalance(Double deposit_amount)
    {
        balance = balance + deposit_amount;

    }

}

public class ATM
    {
	


        private User usr;
        private String pw;
		private User Usr;
	
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

        public ATM(User user)
        {
        //User constructor


        // load database from csv file



        }

        //String constructor

        public void login(User user)
        {
        
        // Authenticate user login
        
        }
        public void logout()
        {

        // log-out

        }


        public double getBalance()
        {
            return this.usr.getBalance();

			//return 0.00 ;

        }
        public void withdrawCash()
        {
            //decrease user balance


        }
        public void depositFunds(Double amount)
        {
        // increase user balance

            //bills_100 += amount / 100 
            //amount = amount / 100

            //bills_50 += amount  50
            //amount = amount % 50

            //bills_20 += amount % 20
            //amount = amount % 20

            //bills_10 += amount % 10
            //amount = amount % 10

            //bills_5 += amount % 5
            //amount = amount % 5

            //bills_1 += amount 


            this.usr.addToBalance(amount);

        }
	
	public static void Main()
	{
		
	}

 }