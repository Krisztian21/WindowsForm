using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Harmadik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Int32.Parse(textBox1.Text);
            int y = Int32.Parse(textBox1.Text);
            if(x >= 0 && x < this.Size.Width - 10 && y >= 0 && y < this.Size.Height - 10)
            {
                button1.Location = new Point(x, y);
                label3.Visible = false;
                label4.Visible = false;
            }
            else
            {
                label3.Visible = true;
                label4.Visible = false;
            }
        }
    }
}
