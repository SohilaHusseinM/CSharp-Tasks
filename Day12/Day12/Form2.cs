using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAY12;

namespace DAY12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.Size;
            button3.Click += (sender, e) => this.Close();
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Rich Text Files|*.rtf|Text Files|*.txt";
            saveFileDialog1.InitialDirectory = "D:";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionColor = fontDialog1.Color;
            }
        }
        Form4 frm = new();

        private void button6_Click(object sender, EventArgs e)
        {
            frm.Show();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.AppendText("this text box".ToUpper());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (
            MessageBox.Show("Are You Sure You Want to Exit ?(Y|N)", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
