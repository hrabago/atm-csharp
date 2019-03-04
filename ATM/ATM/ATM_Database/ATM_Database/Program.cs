using System;
using System.IO;
using System.Security.Cryptography;


namespace ATM_Database
{
    public class Program
    {

        //public StringBuilder csv = new StringBuilder();
        //public static string userName ="maddy";
        //public static string passWord = "pass";
        //public static float balance = 0.0f;
        char[] splitWith = { ' ', ',', '{', '}', ';' };
        string line;
        string bal;

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

        public string FetchBalance(string filepath, string username, string password)
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
                            bal = data[2];
                        }
                        else
                        {
                            Console.WriteLine("wrong password");
                            bal =  "wrong password";
                        }
                    }
                    Console.WriteLine("username does not exist";
                    bal =  "username does not exist";
                }
            }
            return bal;
        }

        public void UpdateBalance(string filepath,string username, string password, float balance)
        {
          

            using (StreamReader sr = new StreamReader(filepath))
            {
                while((line = sr.ReadLine())!= null)
                {
                    string[] data = line.Split(splitWith);
                    if(data[0] == username)
                    {
                        if(data[1] == GetStringSha256Hash(password))
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

        public void AddNewUser(string database, string username, string password)
        {
            //if database doesnt exist
            string path = "/Users/madelineplacik/Projects/database.txt";
            if (!File.Exists(path))
            {
                //add username pw and balance
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("{Username, Password, Balance};");
                    sw.WriteLine("{" + username + ", " + GetStringSha256Hash(password) + ", " + 0.00 + "}; ");
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
                        using (StreamWriter sw = File.AppendText(path))
                        {
                            sw.WriteLine("{" + username + ", " + GetStringSha256Hash(password) + ", " + 0.00 + "}; ");
                        }
                    }

                }
            }
        }

        static void Main(string[] args)
        {

            ////write to new file
            //string path = "/Users/madelineplacik/Projects/database.txt";
            //if (!File.Exists(path))
            //{
            //    //add username pw and balance
            //    using (StreamWriter sw = File.CreateText(path))
            //    {
            //        sw.WriteLine("{Username, Password, Balance};");
            //        sw.WriteLine("{" + userName + ", " + GetStringSha256Hash(passWord) + ", " + balance + "}; ");
            //    }

            //}

            ////append to file that already exists
            //if (File.Exists(path))
            //{
            //    //if username doesnt exist, add it 
            //    using(StreamReader sr = new StreamReader(path))
            //    {
            //        string contents = sr.ReadToEnd();
            //        if (!contents.Contains(userName))
            //        {
            //            using (StreamWriter sw = File.AppendText(path))
            //            {
            //                sw.WriteLine("{" + userName + ", " + GetStringSha256Hash(passWord) + ", " + balance + "}; ");
            //            }
            //        }

            //    }

            //}
     
        }
    }
}
