using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string match1Result = txtMatch1.Text.Trim().ToLower();
            string match2Result = txtMatch2.Text.Trim().ToLower();

            if (match1Result == "win" && match2Result == "win")
            {
                txtTitle.Text = "Champion";
            }
            else if (match1Result == "win" || match2Result == "win")
            {
                txtTitle.Text = "Attacker";
            }
            else
            {
                txtTitle.Text = "Sportsman";
            }
        }
    }
}
