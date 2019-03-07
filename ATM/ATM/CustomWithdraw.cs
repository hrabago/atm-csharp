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
    public partial class CustomWithdraw : Form
    {
        ATM_Object myATM;
        public CustomWithdraw(ATM_Object theATM)
        {
            InitializeComponent();
            myATM = theATM;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String amountText = this.textBox1.Text;
            int val = 0;
            bool result = int.TryParse(amountText, out val);
            if (result)
            {
                int amount = Int32.Parse(amountText);
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
            } else
            {
                MessageBox.Show("Please only input integers", "Invalid Withdraw Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
            }
            return;
        }

        private void CustomWithdraw_Load(object sender, EventArgs e)
        {

        }
    }
}
