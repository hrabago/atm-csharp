using System;
using System.Collections.Generic;

namespace ATM
{
    // Written By Hector and Frank
    public class User
    {
        // Written by Hector
        public String name;
        private String pw;
        private int balance;

        // Tupples of the form: (date, deposit/withdrawal, amount, balance after transaction)
       // private List<(DateTime, string, string, string)> list = new List<(DateTime, string, string, string)>();

        // Written by Hector
        // Default Constructor
        public User(String user, String password, int startingBalance)
        {
            name = user;
            pw = password;
            balance = startingBalance;
        }

        // Toggle LoggedIn Status (decides whether parameters can be accessed)
        public bool authUser()
        {
            return true;
        }

        // Written by Hector
        // Get the user's current balance
        public int getBalance()
        {
            return balance;
        }

        // Written by Frank
        public String getPassword()
        {
            return pw;
        }

        // Written by Frank
        public void addToBalance(int deposit_amount)
        {
            balance += deposit_amount;

        }

        // Written by Frank
        public void subFromBalance(int deposit_amount)
        {
            balance -= deposit_amount;

        }

    }
}