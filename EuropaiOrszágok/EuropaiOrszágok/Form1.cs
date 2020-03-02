using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuropaiOrszágok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Dictionary<string> fovarosok = new Dictionary<string>();
        List<string> orszagok = new List<string>();
        List<string> fovarosok = new List<string>();
        Random rmd = new Random();
        int veletlen = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            orszagok.Add("Magyarország");
            fovarosok.Add("Budapest");
            orszagok.Add("Ausztrália");
            fovarosok.Add("Bécs");
            orszagok.Add("Horvátország");
            fovarosok.Add("Zágráv");
            orszagok.Add("Csehország");
            fovarosok.Add("Prága");
            orszagok.Add("Szlovákia");
            fovarosok.Add("Pozsony");
            orszagok.Add("Románia");
            fovarosok.Add("Bukarest");

            veletlen = rmd.Next(fovarosok.Count);
            textBox1.Text = orszagok[veletlen];
            button2.Visible = false;
            button2.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tipfovaros = textBox2.Text;
            if(tipfovaros==fovarosok[veletlen])
            {
                MessageBox.Show("Ügyes vagy!", "Gratulálunk!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button1.Visible = true;
                button1.Enabled = false;
                button2.Visible = true;
                button2.Enabled = false;
                button3.Visible = true;
                button3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Nem talált. Próbáld újra.", "Eredmény.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                button2.Visible = true;
                button2.Enabled = false;
                button2.Visible = true;
                button2.Enabled = true;
                button3.Visible = true;
                button3.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            veletlen = rmd.Next(fovarosok.Count);
            textBox1.Text = orszagok[veletlen];
            button1.Visible = true;
            button1.Enabled = true;
            button2.Visible = true;
            button2.Enabled = true;
            button3.Visible = true;
            button3.Enabled = false;
            int veletlen_2 = veletlen;
            while(veletlen==veletlen_2)
            {
                veletlen_2 = rmd.Next(orszagok.Count);
            }
            textBox1.Text = orszagok[veletlen_2];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
