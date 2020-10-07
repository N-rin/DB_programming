using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Github_example1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_push_Click(object sender, EventArgs e)
        {
            string year, month, day, underbar;
            year = "1999";
            month = "12";
            day = "31";
            underbar = "_";

            textBox_birth.Text = year +underbar+ month + underbar +day;
        }
    }
}
