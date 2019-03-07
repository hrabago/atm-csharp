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
    public partial class VanishingScreen : Form
    {
        ATM_Object myATM;
        int prevBal;
        public VanishingScreen(int lastBal, ATM_Object theATM)
        {
            InitializeComponent();
            myATM = theATM;
            prevBal = lastBal;
            this.previous_balance.Text = lastBal.ToString();
            this.current_balance.Text = theATM.getCurrentUserBalance().ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskPage tp = new TaskPage(myATM);
            this.Hide();
            tp.Show();
            
        }

        private void VanishingScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
