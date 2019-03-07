using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class Withdraw : Form
    {

        public ATM_Object myATM;
        public Withdraw(ATM_Object theATM)
        {
            InitializeComponent();

            myATM = theATM;
        }

        private void back_Click(object sender, EventArgs e)
        {
            TaskPage tp = new TaskPage(myATM);
            tp.Show();
            this.Close();
        }

        private void withdraw__Click(object sender, EventArgs e)
        {
        }

        // Withdraw 20 quick button
        private void button1_Click(object sender, EventArgs e)
        {
            int amount = 20;
            Console.WriteLine("WithDrawing : " + amount);
            int currentBalance = myATM.getCurrentUserBalance();
            if (currentBalance >= amount)
            {
                int lastBal = myATM.getCurrentUserBalance();
                myATM.withdrawFunds(amount);
                Console.WriteLine(myATM.getCurrentUserBalance());
                VanishingScreen vs = new VanishingScreen(lastBal, myATM);
                this.Hide();
                vs.Show();
            }
            else
            {
                MessageBox.Show("Invalid Withdraw Amount", "Invalid Withdraw Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // Withdraw 40 quick button
        private void button9_Click(object sender, EventArgs e)
        {
            int amount = 40;
            Console.WriteLine("WithDrawing : " + amount);
            int currentBalance = myATM.getCurrentUserBalance();
            if (currentBalance >= amount)
            {
                int lastBal = myATM.getCurrentUserBalance();
                myATM.withdrawFunds(amount);
                Console.WriteLine(myATM.getCurrentUserBalance());
                VanishingScreen vs = new VanishingScreen(lastBal, myATM);
                this.Hide();
                vs.Show();
            }
            else
            {
                MessageBox.Show("Invalid Withdraw Amount", "Invalid Withdraw Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // Withdraw 60 quick button
        private void button5_Click(object sender, EventArgs e)
        {
            int amount = 60;
            Console.WriteLine("WithDrawing : " + amount);
            int currentBalance = myATM.getCurrentUserBalance();
            if (currentBalance >= amount)
            {
                int lastBal = myATM.getCurrentUserBalance();
                myATM.withdrawFunds(amount);
                Console.WriteLine(myATM.getCurrentUserBalance());
                VanishingScreen vs = new VanishingScreen(lastBal, myATM);
                this.Hide();
                vs.Show();
            }
            else
            {
                MessageBox.Show("Invalid Withdraw Amount", "Invalid Withdraw Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // Withdraw 100 quick button
        private void button4_Click_1(object sender, EventArgs e)
        {
            int amount = 100;
            Console.WriteLine("WithDrawing : " + amount);
            int currentBalance = myATM.getCurrentUserBalance();
            if (currentBalance >= amount)
            {
                int lastBal = myATM.getCurrentUserBalance();
                myATM.withdrawFunds(amount);
                Console.WriteLine(myATM.getCurrentUserBalance());
                VanishingScreen vs = new VanishingScreen(lastBal, myATM);
                this.Hide();
                vs.Show();
            }
            else
            {
                MessageBox.Show("Invalid Withdraw Amount", "Invalid Withdraw Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // Withdraw 200 quick button
        private void button2_Click(object sender, EventArgs e)
        {
            int amount = 200;
            Console.WriteLine("WithDrawing : " + amount);
            int currentBalance = myATM.getCurrentUserBalance();
            if (currentBalance >= amount)
            {
                int lastBal = myATM.getCurrentUserBalance();
                myATM.withdrawFunds(amount);
                Console.WriteLine(myATM.getCurrentUserBalance());
                VanishingScreen vs = new VanishingScreen(lastBal, myATM);
                this.Hide();
                vs.Show();
            }
            else
            {
                MessageBox.Show("Invalid Withdraw Amount", "Invalid Withdraw Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        // Withdraw Custom Amount
        private void button3_Click(object sender, EventArgs e)
        {
            CustomWithdraw vs = new CustomWithdraw(myATM);
            vs.Show();
            this.Close();
        }

        private void Withdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
