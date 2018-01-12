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
        public int j= 176;
        private void enter_Click(object sender, EventArgs e)
        {
            Label[] label = new Label[4];
            label[i] = new Label();
            if (i < 3)
            {
                this.Controls.Add(label[i]);
                label[i].Text = "品項:" + Jontype[i] + "\t金額:" + Jonmoney[i];
                label[i].Location = new System.Drawing.Point(31, j);
                label[i].TabIndex = 9;
                this.label1.Size = new System.Drawing.Size(23, 12);
                i = i + 1;
                j = j + 25;
            }
        }

        private void jtyp_TextChanged(object sender, EventArgs e)
        {
            Jontype[i] = jtyp.Text;
        }

        private void jmon_TextChanged(object sender, EventArgs e)
        {
            Jonmoney[i] = jmon.Text;
        }
    }
    
}
