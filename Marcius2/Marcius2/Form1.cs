using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcius2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            elemszamNUD.Maximum = TopMozi.Items.Count;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FelveszBTN_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "" && evTxt.Text != "")
            {
                string bevitel = $"{szovegTxt.Text} ({evTxt.Text})";
                TopMozi.Items.Add((szovegTxt.Text) + (evTxt.Text));
                elemszamNUD.Maximum = TopMozi.Items.Count;
            }
            else if (szovegTxt.Text == "" && evTxt.Text == "")
            {
                MessageBox.Show("Mindkettő beviteli Mező üres", "Beviteli Mező",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (szovegTxt.Text != "" && evTxt.Text == "")
            {
                MessageBox.Show("A szövegbeviteli mező üres.", "Beviteli Mező",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (szovegTxt.Text == "" && evTxt.Text != "")
            {
                MessageBox.Show("Az évbeviteli mező üres", "Beviteli Mező", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BeszurBTN_Click(object sender, EventArgs e)
        {
            if (szovegTxt.Text != "" && evTxt.Text != "" && (int)elemszamNUD.Value != 0)
            {
                string bevitel = $"{szovegTxt.Text} {evTxt.Text}";
                TopMozi.Items.Insert((int)elemszamNUD.Value - 1, bevitel);
                elemszamNUD.Maximum = TopMozi.Items.Count;
                szovegTxt.Text = "";
                evTxt.Text = "";
            }
        }

        private void TorolBTN_Click(object sender, EventArgs e)
        {
            if(TopMozi.SelectedIndex!=-1)
            {
                TopMozi.Items.Remove(TopMozi.SelectedItems);
                elemszamNUD.Maximum = TopMozi.Items.Count;
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem.", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TorolMindBTN_Click(object sender, EventArgs e)
        {
            TopMozi.Items.Clear();
            elemszamNUD.Maximum = -1;
        }

        private void AtmasolBTN_Click(object sender, EventArgs e)
        {
            if (TopMozi.SelectedIndex != -1)
            {
                if (LatottMoziLV.Items.Contains(TopMozi.SelectedItem))
                {
                    MessageBox.Show("Van ilyen elem.", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LatottMoziLV.Items.Add(TopMozi.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem.", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtmozgatBTN_Click(object sender, EventArgs e)
        {
            if (TopMozi.SelectedIndex != -1)
            {
                if (LatottMoziLV.Items.Contains(TopMozi.SelectedItem))
                {
                    MessageBox.Show("Van ilyen elem.", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LatottMoziLV.Items.Add(TopMozi.SelectedItem);
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt elem.", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void KeresBTN_Click(object sender, EventArgs e)
        {
            if(szovegTxt.Text!="")
                {
                    int index = TopMozi.FindString(szovegTxt.Text);
                    if(index!=-1)
                    {
                        TopMozi.SelectedItems();
                    }
                }
        }
    }
}
