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
        public TaskPage()
        {
            InitializeComponent();
        }

        private void viewBalance_Click(object sender, EventArgs e)
        {
            ShowBalance sb = new ShowBalance();
            sb.Show();
            this.Close();
        }

        private void TaskPage_Load(object sender, EventArgs e)
        {

        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            Withdraw wd = new Withdraw();
            wd.Show();
            this.Close();
        }

        private void depositFunds_Click(object sender, EventArgs e)
        {
            Deposit dp = new Deposit();
            dp.Show();
            this.Close();
        }
    }
}
