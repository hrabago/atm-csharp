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
    public partial class ShowBalance : Form
    {
        public ATM_Object myATM;
        public int balance;

        public ShowBalance()
        {
            InitializeComponent();
        }
        public ShowBalance(ATM_Object theATM)
        {
            InitializeComponent();
            myATM = theATM;
            balance = myATM.getCurrentUserBalance();
            this.label2.Text = balance.ToString();


            //   Text = balance.ToString();
        }

        private void back_Click(object sender, EventArgs e)
        {


            //TaskPage tp = new TaskPage(myATM);
            //tp.Show();
            //this.Visible = false;
            //this.Owner.Visible = true;
            this.Owner.Show();

            this.Close();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Welcome wc = new Welcome();
            // string t = wc.temp.ToString();
            
           

            
        }

        private void ShowBalance_Load(object sender, EventArgs e)
        {

        }
    }
}
