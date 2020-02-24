using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezerlok3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ValasztoGomb_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            string kimeno = textBox3.Text;
            int szam = Int32.Parse(textBox2.Text);
            int negyzetgyok = (int)Math.Floor(Math.Sqrt(szam));
            /*foreach(var items in listBox1.SelectedItems)
            {
                //kimeno = items.ToString()+"\r\n";
                //listBox2.Items.Add(items);
                //comboBox1.Items.Add(items);
            }*/
            for(int i=1; i<=szam; i++)
            {
                if(szam%i==0)
                {
                    listBox1.Items.Add(i);
                    /*if (i.ToString().Contains(kimeno))
                    {
                        comboBox1.Items.Add(i);
                    }*/
                    if (i <= negyzetgyok)
                    {
                        listBox2.Items.Add(i);
                    }
                    else
                    {
                        comboBox1.Items.Add(i);
                    }
                    /*for(int j=2; j<=szam; j++)
                    {
                        if (i * j==szam)
                        {
                            listBox1.Items.Add(i);
                            listBox2.Items.Add(j);
                        }
                    }*/
                }
                if(comboBox1.Items.Count==listBox2.Items.Count)
                {
                    textBox3.Text = "A szám nem négyzetszám";
                }
                else
                {
                    textBox3.Text = "A szám négyzetszám";
                }
            }
            //textBox1.Text = listBox1.SelectedItem.ToString();
        }

        private void HozzaadGomb_Click(object sender, EventArgs e)
        {
            string hozzaad = textBox2.Text;
            listBox1.Items.Add(hozzaad);
        }
    }
}
