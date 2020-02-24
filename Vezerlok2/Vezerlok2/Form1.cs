using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezerlok2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Fekete_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Black;
        }

        private void Piros_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void Kek_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void Zold_CheckedChanged(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void Tizes_CheckedChanged(object sender, EventArgs e)
        {
            int betumeret = 10;
            label1.Font = new Font(label1.Font.Name, betumeret, label1.Font.Style);
        }

        private void TizenEgyes_CheckedChanged(object sender, EventArgs e)
        {
            int betumeret = 11;
            label1.Font = new Font(label1.Font.Name, betumeret, label1.Font.Style);
        }

        private void TizenKettes_CheckedChanged(object sender, EventArgs e)
        {
            int betumeret = 12;
            label1.Font = new Font(label1.Font.Name, betumeret, label1.Font.Style);
        }

        private void TizenNegyes_CheckedChanged(object sender, EventArgs e)
        {
            int betumeret = 14;
            label1.Font = new Font(label1.Font.Name, betumeret, label1.Font.Style);
        }

        private void TizenHatos_CheckedChanged(object sender, EventArgs e)
        {
            int betumeret = 16;
            label1.Font = new Font(label1.Font.Name, betumeret, label1.Font.Style);
        }

        private void TizenNyolcas_CheckedChanged(object sender, EventArgs e)
        {
            int betumeret = 18;
            label1.Font = new Font(label1.Font.Name, betumeret, label1.Font.Style);
        }

        private void FelKover_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void Dolt_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }

        private void AlaHuzott_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Underline);
        }

        private void AtHuzott_CheckedChanged(object sender, EventArgs e)
        {
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Strikeout);
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            textBox1.Text = hScrollBar1.Value.ToString();
            panel2.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            textBox2.Text = hScrollBar2.Value.ToString();
            panel2.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);
        }

        private void hScrollBar3_Scroll(object sender, ScrollEventArgs e)
        {
            textBox3.Text = hScrollBar3.Value.ToString();
            panel2.BackColor = Color.FromArgb(hScrollBar1.Value, hScrollBar2.Value, hScrollBar3.Value);

        }
    }
}
