using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Elso
{
    public partial class Urlap : Form
    {
        public string belepeoszoveg = "Ahsoka";
        public Urlap()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void BemenoSzoveg(object sender, EventArgs e)
        {
            
        }

        private void KimenoSzoveg(object sender, EventArgs e)
        {

        }

        private void ModositoGomb(object sender, EventArgs e)
        {
            String modosithatoSzoveg = Bemeno.Text;
            Kimeno.Text = modosithatoSzoveg.ToUpper();
            //this.Close();
            //MessageBox.Show("Éljen a 13SZF", "Ez egy üdvözlő üzenet!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            /*if (button1.Visible)
            {
                button1.Visible = false;
                button2.Visible = true;
            }
            else if(button2.Visible)
            {
                button1.Visible = true;
                button2.Visible = false;
            }*/
            button1.Visible = !button1.Visible;
            //saját próbálkozás
            /*if(modosithatoSzoveg=="Anakin"|| modosithatoSzoveg == "Anakin Skywalker")
            {
                Kimeno.Text = "Obi-Wan Kenobi";
                Szoveg.Text = "Ahsoka";
            }
            else if(modosithatoSzoveg == "Obi-Wan" || modosithatoSzoveg == "Obi-Wan Kenobi")
            {
                Kimeno.Text = "Qui-Gon Jinn";
                Szoveg.Text = "Anakin Skywalker";
            }
            else if (modosithatoSzoveg == "Qui-Gon" || modosithatoSzoveg == "Qui-Gon Jinn")
            {
                Kimeno.Text = "Dooku Gróf";
                Szoveg.Text = "Obi-Wan Kenobi";
            }
            else if (modosithatoSzoveg == "Yoda" || modosithatoSzoveg == "Yoda Mester")
            {
                Szoveg.Text = "Dooku Gróf";
            }*/
        }

        private void Szoveg1(object sender, EventArgs e)
        {

        }

        private void Urlap_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = "The Clone Wars";
            //Gomb.Visible = false;
        }

        private void Urlap_MouseLeave(object sender, EventArgs e)
        {
            this.Text = belepeoszoveg;
            //Gomb.Visible = true;
        }

        private void Urlap_Load(object sender, EventArgs e)
        {
            this.Text = belepeoszoveg.ToUpper();
        }

        private void Urlap_TextChanged(object sender, EventArgs e)
        {
            Random rmd = new Random();
            int szam = rmd.Next(5);
            switch(szam)
            {
                case 0:
                {
                   this.BackColor = Color.Lime;
                   break;
                }
                case 1:
                    {
                        this.BackColor = Color.Purple;
                        break;
                    }
                case 2:
                    {
                        this.BackColor = Color.Orange;
                        break;
                    }
                case 3:
                    {
                        this.BackColor = Color.Gold;
                        break;
                    }
                case 4:
                    {
                        this.BackColor = Color.Chocolate;
                        break;
                    }
                case 5:
                    {
                        this.BackColor = Color.Gray;
                        break;
                    }
            }
        }

        private void Urlap_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void Modositogomb1(object sender, EventArgs e)
        {
            if (Gomb.Enabled)
            {
                Gomb.Enabled = false;
            }
            else
            {
                Gomb.Enabled = true;
            }
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            int szelesseg = this.Size.Width - button2.Width - 10;
            int magassag = this.Size.Height - button2.Height - 10;
            Random rnd = new Random();
            int x = rnd.Next(szelesseg);
            int y = rnd.Next(magassag);
            button2.Location = new Point(x, y);
            //button2.Location = new Point(0, 0);
            //this.Close();
        }
    }
}