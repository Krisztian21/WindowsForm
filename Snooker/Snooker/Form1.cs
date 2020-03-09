using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Snooker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string elsosor = "";
        List<Versenyzo> versenyzolista = new List<Versenyzo>();

        private void Form1_Load(object sender, EventArgs e)
        {
            int osszegez = 0;
            using (StreamReader sr = new StreamReader("snooker.txt", Encoding.UTF8))
            {
                elsosor = sr.ReadLine();
                while(!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    /*for(int i=0; i<elsosor.Split(';').Length; i++)
                    {
                        listView1.Columns[i].Text = elsosor.Split(';')[i];
                    }*/
                    columnHeader1.Text = elsosor.Split(';')[0];
                    columnHeader2.Text = elsosor.Split(';')[1];
                    columnHeader3.Text = elsosor.Split(';')[2];
                    columnHeader4.Text = elsosor.Split(';')[3];
                    int helyezes = Int32.Parse(sor.Split(';')[0]);
                    string nev = sor.Split(';')[1];
                    string orszag = sor.Split(';')[2];
                    int nyeremeny = Int32.Parse(sor.Split(';')[3]);
                    osszegez += nyeremeny;
                    Versenyzo versenyzo = new Versenyzo(helyezes, nev, orszag, nyeremeny);
                    versenyzolista.Add(versenyzo);
                    ListViewItem lvi = new ListViewItem(helyezes.ToString());
                    lvi.SubItems.Add(nev);
                    lvi.SubItems.Add(orszag);
                    lvi.SubItems.Add(nyeremeny.ToString());
                    listView1.Items.Add(lvi);
                    bool vane = true;
                    foreach(var item in comboBox1.Items)
                    {
                        vane = false;
                        break;
                    }
                    if(vane)
                    {
                        comboBox1.Items.Add(orszag);
                    }
                    label2.Text = "A versenyen:" + Convert.ToString(versenyzolista.Count) + " darab versenyző indult.";
                    label3.Text = $"A versenyzők átlagosan {(double)osszegez / versenyzolista.Count}";
                    Versenyzo ujversenyzo = new Versenyzo();
                    int max = 0;
                    foreach(var item in versenyzolista)
                    { 
                        if(item.Nyeremeny>=max&&item.Orszag=="Kína")
                        {
                            max = item.Nyeremeny;
                            ujversenyzo = item;
                        }
                    }
                    label6.Text = $"Helyezés: {ujversenyzo.Helyezes}\n" +
                                $"Név: { ujversenyzo.Nev}\n" +
                                $"Ország: { ujversenyzo.Orszag}\n" +
                                $"Nyeremény: { ujversenyzo.Nyeremeny}";
                }
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem Item in listView1.SelectedItems)
            {
                listView1.Items.Remove(Item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int osszeg = Int32.Parse(textBox1.Text);
            foreach (ListViewItem item in listView1.Items)
            {
                if(item.SubItems[2].Text!=comboBox1.SelectedItem.ToString()|| Int32.Parse(item.SubItems[3].Text)<osszeg)
                {
                    listView1.Items.Remove(item);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int osszeg = Int32.Parse(textBox1.Text);
            string orszag = textBox2.Text;
            foreach (ListViewItem item in listView1.Items)
            {
                if (Int32.Parse(item.SubItems[3].Text) > osszeg && item.SubItems[2].Text==orszag)
                {
                    listView1.Items.Remove(item);
                }
            }
        }
    }
}
