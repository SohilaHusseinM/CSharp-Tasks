namespace DAY12
{
    public partial class Form1 : Form
    {
        Form3 frm = new();
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Lime;
            this.ResizeEnd += (sender, e) => this.Opacity = 1;
            button1.Click += (sender, e) => frm.Show(); 
         }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
