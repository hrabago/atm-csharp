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
    public partial class Welcome : Form
    {
        ATM_Object myATM;
        public Welcome()
        {
            myATM = new ATM_Object();
            User userHector = new User("hector", "password");
            myATM.addNewUser("hector", userHector);
            myATM.login("hector", "password");
            this.IsMdiContainer = true;
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TaskPage tp = new TaskPage(myATM);
           //this.Hide();
            tp.Show();

            MessageBox.Show("Hey Thief", "What you looking for?", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
