using System;

namespace ATM
{
    public class User
    {

        public String name;
        private String pw;
        private bool loggedIn;
        private int balance;
        // Tupples of the form: (date, deposit/withdrawal, amount, balance after transaction)
        private List<(DateTime, string, string, string)> list = new List<(DateTime, string, string, string)>();

        // Default Constructor
        public User(String user, String password)
        {
            name = user;
            pw = password;
            loggedIn = false;
            balance = 100;
        }

        // Toggle LoggedIn Status (decides whether parameters can be accessed)
        public bool authUser()
        {

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
}