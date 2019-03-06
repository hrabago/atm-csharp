using System;
using System.IO;
using System.Security.Cryptography;


namespace ATM
{
    public class Database
    {

        //public StringBuilder csv = new StringBuilder();
        //public static string userName ="maddy";
        //public static string passWord = "pass";
        //public static float balance = 0.0f;
        static char[] splitWith = { ' ', ',', '{', '}', ';' };
        static string line;
        static string bal;

        internal static string GetStringSha256Hash(string text)
        {
            if (String.IsNullOrEmpty(text))
                return String.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", String.Empty);
            }
        }

        public static ATM_Object loadUsersFromDatabase()
        {
            ATM_Object tempATM = new ATM_Object();
            var filepath = "./../../atm_database.txt";
            using (StreamReader sr = new StreamReader(filepath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (!data[0].Equals("Username"))
                    {
                        User tempUser = new User(data[0], data[1], Int32.Parse(data[2]));
                        tempATM.addNewUser(data[0], tempUser);
                    }       
                }
            }
            return tempATM;
        }

        public static string FetchBalance(string username, string password)
        {
            var filepath = "./../../atm_database.txt";
            using (StreamReader sr = new StreamReader(filepath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    Console.WriteLine("data is: " + data[0]);
                    if (data[0].Equals(username))
                    {
                        Console.WriteLine("Checked : " + username);
                        Console.WriteLine("real password : " + data[1]);
                        Console.WriteLine("stored : " + GetStringSha256Hash(password));
                        if (data[1].Equals(GetStringSha256Hash(password)))
                        {
                            Console.WriteLine("Inside If " + username);
                            return data[2];
                        }
                        else
                        {
                            Console.WriteLine("wrong password");
                            bal = "wrong password";
                        }
                    }
                    Console.WriteLine("username does not exist");
                    bal = "username does not exist";
                }
            }
            return bal;
        }

        public void UpdateBalance(string filepath, string username, string password, float balance)
        {


            using (StreamReader sr = new StreamReader(filepath))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(splitWith);
                    if (data[0] == username)
                    {
                        if (data[1] == GetStringSha256Hash(password))
                        {
                            data[3] = balance.ToString();
                        }
                        else
                        {
                            Console.WriteLine("wrong password");
                        }
                    }
                    Console.WriteLine("username does not exist");
                }

            }
        }

        public static void AddNewUser(string username, string password, int balance)
        {
            //if database doesnt exist
            string path = "./../../atm_database.txt";
            if (!File.Exists(path))
            {
                //add username pw and balance
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("{Username, Password, Balance};");
                    sw.WriteLine(username + ", " + GetStringSha256Hash(password) + ", " + balance);
                }
            }
            //add to existing database
            if (File.Exists(path))
            {
                //if username doesnt exist, add it 
                using (StreamReader sr = new StreamReader(path))
                {
                    string contents = sr.ReadToEnd();
                    if (!contents.Contains(username))
                    {
                        using (StreamWriter sw = new StreamWriter(path, true))
                        {
                            sw.WriteLine("{" + username + ", " + GetStringSha256Hash(password) + ", " + 0.00 + "}; ");
                        }
                    }

                }
            }
        }

    }
}
