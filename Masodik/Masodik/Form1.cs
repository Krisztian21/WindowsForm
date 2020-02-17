using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Masodik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Double.Parse(textBox2.Text);
            double b = Double.Parse(textBox3.Text);
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            double ker = a + b + c;
            double ter = a * b / 2;
            string kiiras = $"C oldal: {c:F2}\nKerület: {ker:F2}\nTerület: {ter:F2}";
            textBox1.Text = kiiras;

        }
    }
}
