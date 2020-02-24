using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezerlok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*if (KekSzin.Checked)
            {
                if(Csajok.Checked)
                {
                    textBox1.Text = "A csajok szemei kék színűek.";
                }
                else if (Pasik.Checked)
                {
                    textBox1.Text = "A pasik szemei kék színűek.";
                }
                
            }
            else if (PirosSzin.Checked)
            {
                if (Csajok.Checked)
                {
                    textBox1.Text = "A csajok szemei piros színűek.";
                }
                else if(Pasik.Checked)
                {
                    textBox1.Text = "A pasik szemei piros színűek.";
                }
            }
            else if (ZoldSzin.Checked)
            {
                if (Csajok.Checked)
                {
                    textBox1.Text = "A csajok szemei zöld színűek.";
                }
                else if(Pasik.Checked)
                {
                    textBox1.Text = "A pasik szemei zöld színűek.";
                }*/

            if (Csajok.Checked)
            {
                if (BalLab.Checked)
                {
                    textBox1.Text = "A csaj ballábas.";
                }
                else if (JobbLab.Checked)
                {
                    textBox1.Text = "A csaj jobblábas.";
                }
                else if (FaLab.Checked)
                {
                    textBox1.Text = "A csaj 2 ballábas.";
                }
            }
            else if (Pasik.Checked)
            {
                if (BalLab.Checked)
                {
                    textBox1.Text = "A pasi ballábas.";
                }
                else if (JobbLab.Checked)
                {
                    textBox1.Text = "A pasi jobblábas.";
                }
                else if (FaLab.Checked)
                {
                    textBox1.Text = "A pasi 2 ballábas.";
                }

             }
        }
    }
}
