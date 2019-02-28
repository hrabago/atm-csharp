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
        public Withdraw()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            TaskPage tp = new TaskPage();
            tp.Show();
            this.Close();
        }

        private void withdraw__Click(object sender, EventArgs e)
        {
            VanishingScreen vs = new VanishingScreen();
            vs.
            vs.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
