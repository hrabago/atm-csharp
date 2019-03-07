using System;
using System.Collections.Generic;

namespace ATM
{
    // Written by Hector and Frank
    // The backend integration with the Front-end (referring to object values, 
    // taking in and parsing withdraw/deposit values, and reflecting Front end actions
    // with backend objects) was done by Hector, Frank, and Maddy
    public class ATM_Object
    {
        // Written by Frank
        private Dictionary<string, User> atmUsers = new Dictionary<string, User>();
        private User currentUser;

        // Written by Hector
        private int bills_1 = 0;
        private int bills_5 = 0;
        private int bills_10 = 0;
        private int bills_20 = 500;
        private int bills_50 = 0;
        private int bills_100 = 0;

        //User constructor
        public ATM_Object()
        {
            //User constructor	
        }

        // Written by Frank
        public void addNewUser(string name, User user)
        {
            atmUsers.Add(name, user);
        }

        // Written By Frank
        public bool login(String name, String password)
        {
            String hash = Database.GetStringSha256Hash(password);
            if (hash.Equals(atmUsers[name].getPassword()))
            {
                currentUser = atmUsers[name];
                return true;
            } else
            {
                return false;
            }
        }

        // Written by Hector
        // Clear current active user
        public void logout()
        {
            currentUser = null;
        }

        // Written by Hector
        // Retrives current logged in user balance
        public int getCurrentUserBalance()
        {
            return this.currentUser.getBalance();
        }

        // Written By Frank
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

        // Written By Frank
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

    }
}