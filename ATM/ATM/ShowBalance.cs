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
        public ShowBalance()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            TaskPage tp = new TaskPage();
            tp.Show();
            this.Close();
        }
    }
}
