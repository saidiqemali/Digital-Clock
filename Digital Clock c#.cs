using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer_click(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.ToString("hh:mm");
            seconds.Text = DateTime.Now.ToString("ss");
            date.Text = DateTime.Now.ToString("dd mm yyyy");
            seconds.Location = new Point(time.Location.X + time.Width, seconds.Location.Y);

        }
    }
}
