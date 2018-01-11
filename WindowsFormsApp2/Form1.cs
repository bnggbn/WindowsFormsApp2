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
            this.jondiscount.Items.Add("無");
            this.jondiscount.Items.Add("95折");
            this.jondiscount.SelectedIndex = 1;

        }
    

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class discount
        {
            public string dis_off;
            public float dis_value;
        }
        
    }
}
