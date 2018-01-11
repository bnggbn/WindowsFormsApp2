using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
         string[] Jontype = new string[6];
        string[] Jonmoney = new string[8];
        public Array jonarr = new Array[1000];
        public int i;
        public int j;
        private void enter_Click(object sender, EventArgs e)
        public class Discount

        {
            if (Jontype != null)
            {
                for(i=0; i<=jtyp.Text.Length; i++)
                {
                    Console.WriteLine(jtyp.Text,i);
                    Jontype[i] = jtyp.Text.ToString();
                }
                foreach (string s in Jontype)
                {
                    Console.WriteLine(s);
                }
                MessageBox.Show("品項:" + Jontype[0]+"\n價錢:"+Jonmoney);
                for (j = 0; i <= jmon.Text.Length; j++)
                {
                    Console.WriteLine(jmon.Text, j);
                    Jonmoney[j] = jmon.Text;
                }
                foreach (string s in Jonmoney)
                {
                    Console.WriteLine(s);
                }
                
            }
        }

        private void jtyp_TextChanged(object sender, EventArgs e)
        {
            Jontype[i] = jtyp.Text;
        }

        private void jmon_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - textBox1.Text.Length);
        }
    }
    
}
