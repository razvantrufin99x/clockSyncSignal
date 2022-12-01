using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clockSyncSignal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int i = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = 10*i++;
            panel1.Visible = true;
            panel3.Visible = false;
            panel2.Left = 10 * i;
            if (i >= 10) { i = 0;
                panel1.Visible = false;
                panel3.Visible = true;
                Thread.Sleep(50);
            }

        }
    }
}
