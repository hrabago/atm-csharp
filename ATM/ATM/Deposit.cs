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
    public partial class Deposit : Form


    {
        public ATM_Object myATM;
        public Deposit(ATM_Object theATM)
        {
            InitializeComponent();
            myATM = theATM;
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            TaskPage tp = new TaskPage(myATM);
            tp.Show();
            this.Close();
        }

        private void deposit__Click(object sender, EventArgs e)
        {
            Console.WriteLine("Depositing : " + this.textBox1.Text);
            String amount = this.textBox1.Text;
            int val = 0;
            bool result = int.TryParse(amount, out val);
            if (result)
            {
                int prevBal = myATM.getCurrentUserBalance();
                myATM.depositFunds(Int32.Parse(amount));
                Console.WriteLine(myATM.getCurrentUserBalance());
                VanishingScreen vs = new VanishingScreen(prevBal, myATM);
                this.Hide();
                vs.Show();
            } else
            {
                MessageBox.Show("Invalid Deposit Amount", "Invalid Deposit Amount", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
