using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dolgozat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /*List<string> nev = new List<string>();
        List<int> igazolt = new List<int>();
        List<int> igazolatlan = new List<int>();
        int db = 0;
        int db1 = 0;*/
        List<Tanulo> Lista = new List<Tanulo>();

        private void button1_Click(object sender, EventArgs e)
        {
            /*for(int i=0; i<nev.Count; i++)
            {
                if(nev[i]=="" && igazolt[i]==0 && igazolatlan[i]==0)
                {
                    nev.Add(textBox1.Text);
                    db = Convert.ToInt32(textBox2.Text);
                    db1 = Convert.ToInt32(textBox3.Text);
                    igazolt.Add(db);
                    igazolatlan.Add(db1);
                }
                else if(nev[i]!=textBox1.Text)
                {
                    nev.Add(textBox1.Text);
                    if (textBox1.Text ==nev[i] && textBox2.Text != "" && textBox3.Text != "")
                    {
                        db = Convert.ToInt32(textBox2.Text);
                        db1 = Convert.ToInt32(textBox3.Text);
                        igazolt.Add(db);
                        igazolatlan.Add(db1);
                    }
                    else if(textBox1.Text == nev[i] && textBox2.Text != "" && textBox3.Text == "")
                    {
                        db = Convert.ToInt32(textBox2.Text);
                        igazolt.Add(db);
                    }
                    else if (textBox1.Text == nev[i] && textBox2.Text == "" && textBox3.Text != "")
                    {
                        db1 = Convert.ToInt32(textBox3.Text);
                        igazolatlan.Add(db1);
                    }
                    else if(igazolt[i]!=0)
                    {
                        igazolt[i] += db;
                    }
                    else if (igazolatlan[i] != 0)
                    {
                        igazolatlan[i] += db1;
                    }
                    this.textBox1.Clear();
                    this.textBox2.Clear();
                    this.textBox3.Clear();
                }
            }*/

            string nev = textBox1.Text;
            string igazolt = textBox2.Text;
            string igazolatlan = textBox3.Text;
            Tanulo tan = new Tanulo(nev, igazolt, igazolatlan);
            Lista.Add(tan);
            comboBox1.Items.Add(tan);
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*for (int i = 0; i < nev.Count; i++)
            {
                if (textBox4.Text == nev[i])
                {
                    label7.Text = Convert.ToString(igazolt[i]);
                    label8.Text = Convert.ToString(igazolatlan[i]);
                }
            }*/
            foreach (var item in Lista)
            {
                if (comboBox1.SelectedItem.ToString()==item.Nev)
                {
                    label7.Text = item.Igazolt;
                    label8.Text = item.Igazolatlan;
                }
            }
        }
    }
}
