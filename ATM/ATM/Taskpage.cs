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
    public partial class TaskPage : Form
    {
        ATM_Object myATM;
        public TaskPage(ATM_Object theATM)
        {
            myATM = theATM;
            InitializeComponent();
            
        }
        public TaskPage()
        {
            InitializeComponent();

        }
        private void viewBalance_Click(object sender, EventArgs e)
        {
            ShowBalance sb = new ShowBalance(myATM);
            sb.Owner = this;
            //this.Visible = false;
            //sb.ShowDialog();
            sb.Show();
            this.Hide();
        }

        private void TaskPage_Load(object sender, EventArgs e)
        {

        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw(myATM);
            wd.Show();
            this.Close();
        }

        private void depositFunds_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit(myATM);
            dp.Show();
            this.Close();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            myATM.logout();
            Welcome wel = new Welcome();
            wel.Show();
            this.Close();
        }
    }
}
