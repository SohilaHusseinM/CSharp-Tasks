using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAY12
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Form2 frm = new();
        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "ABC") && textBox2.Text == "123")
            {
                this.Hide();
                frm.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
