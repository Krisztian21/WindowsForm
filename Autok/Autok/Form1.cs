using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Autok> lista = new List<Autok>();

        private void FelveszBTN_Click(object sender, EventArgs e)
        {
            string rendszam = Rendszam.Text;
            Rendszam.Clear();
            string marka = Marka.Text;
            string tipus = Tipus.Text;
            Tipus.Text="";
            int evjarat = (int)Evszam.Value;
            string uzemanyag = Uzemanyag.SelectedItem.ToString();
            Autok auto = new Autok(rendszam, marka, tipus, evjarat, uzemanyag);
            lista.Add(auto);
        }

        private void ListazBTN_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(var item in lista)
            {
                listBox1.Items.Add(item.Kiir());
            }
        }
    }
}
