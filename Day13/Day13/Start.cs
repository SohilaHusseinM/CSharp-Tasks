using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day13
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailedView detailedView = new DetailedView();

            // Show the DetailedView form
            detailedView.Show();

            // Optionally hide or close the current StartForm
            this.Hide(); // or this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GridView gridView = new GridView();

            // Show the DetailedView form
            gridView.Show();

            // Optionally hide or close the current StartForm
            this.Hide(); // or this.Close();
        }
    }
}
