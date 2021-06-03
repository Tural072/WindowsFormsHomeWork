using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHomeWork
{
    public partial class Form1 : Form
    {
        Timer timer = new Timer();
        public Form1()
        {
            InitializeComponent();
            bakuBtn.BackColor = Color.FromArgb(200, 200, 200);
            bakuBtn.ForeColor = Color.DarkCyan;
            londonBtn.BackColor = Color.FromArgb(200, 200, 200);
            londonBtn.ForeColor = Color.DarkCyan;
            clockLbl.BackColor = Color.FromArgb(200,200,200);
            clockLbl.ForeColor = Color.DarkCyan;
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            clockLbl.Text = DateTime.Now.ToLongTimeString();
        }

        private void Timer_Tick_London(object sender, EventArgs e)
        {
            clockLbl.Text = DateTime.Now.AddHours(4).ToLongTimeString();
        }

        private void bakuBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Baku;
            timer.Tick += Timer_Tick;
            timer.Interval = 1000;
            timer.Start();
        }

        private void londonBtn_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.London;
            timer.Tick += Timer_Tick_London;
            timer.Interval = 1000;
            timer.Start();
        }

    }
}
