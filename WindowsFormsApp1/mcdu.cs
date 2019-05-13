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
    public partial class Mcdu : Form
    {
        public Mcdu()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel_init.Visible = false;
            panel_fpln.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            panel_fpln.Visible = false;
            panel_init.Visible = true;
        }
    }
}
