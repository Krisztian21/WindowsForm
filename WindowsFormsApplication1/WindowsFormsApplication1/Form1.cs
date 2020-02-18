using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string szo = textBox1.Text;
            int szam = Int32.Parse(textBox2.Text);
            if(szam>szo.Length||szam<=0)
            {
                textBox3.Text = "Hosszabb/Rövidebb mint a szó karakter hossza.";
            }
            else if(szam==szo.Length)
            {
                string elso = szo.Substring(0, szo.Length-1);
                string masodik = szo.Substring(szo.Length-1).ToUpper();
                string kimenet = elso + masodik;
                textBox3.Text = kimenet;
            }
            else if (szam < szo.Length&& szam > 1)
            {
                string elso = szo.Substring(0, szam - 1);
                string masodik = szo.Substring(szam-1, 1).ToUpper();
                string harmadik = szo.Substring(szam);
                string kimenet = elso + masodik + harmadik;
                textBox3.Text = kimenet;
            }
        }
    }
}
