using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static Day13.ConnectionBase;
namespace Day13
{
    public partial class DetailedView : Form
    {
        SqlCommand sqlCmd;
        DataTable DT;
        SqlDataAdapter DA;
        BindingSource bindingSource;
        public DetailedView()
        {
            InitializeComponent();
            Load_data();
        }
        private void Load_data()
        {
            sqlCmd = new SqlCommand("select * from Employee", SqlCN);
            DT = new();
            DA = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(DA);//save updates(insert+delete+updates)
            DA.UpdateCommand = commandBuilder.GetUpdateCommand();
            DA.InsertCommand = commandBuilder.GetInsertCommand();
            DA.DeleteCommand = commandBuilder.GetDeleteCommand();

            DA.Fill(DT);
            bindingSource = new BindingSource(DT, "");
            //complex Data Binding
            lstEmp.DataSource = bindingSource;
            lstEmp.DisplayMember = "fname";
            lstEmp.ValueMember = "emp_id";

            //simple Data Binding
            emp_id_txt.DataBindings.Add("Text", bindingSource, "emp_id");
            fname_txt.DataBindings.Add("Text", bindingSource, "fname");
            lname_txt.DataBindings.Add("Text", bindingSource, "lname");

            minit_cmb.DataBindings.Add("Text", bindingSource, "minit");
            for (char i = 'A'; i <= 'Z'; i++) minit_cmb.Items.Add(i);

            //pub_id
            pub_id_cmb.DataBindings.Add("Text", bindingSource, "pub_id");
            pub_id_cmb.DataSource = FData("select pub_id from publishers");
            pub_id_cmb.ValueMember = "pub_id";

            //job_id
            job_id_cmb.DataBindings.Add("Text", bindingSource, "job_id");
            job_id_cmb.DataSource = FData("select job_id from jobs");
            job_id_cmb.ValueMember = "job_id";

            //jon_lvl
            job_lvl_UDlst.DataBindings.Add("Text", bindingSource, "job_lvl");
            StoredExc(job_id_cmb.Text);//intialize min and max
            //hire_date
            hire_date.DataBindings.Add("Text", bindingSource, "hire_date");
        }
        private DataTable FData(string sqlc)
        {
            SqlCommand cmd = new SqlCommand(sqlc, SqlCN);
            DataTable table = new DataTable();
            SqlDataAdapter DAdp = new SqlDataAdapter(cmd);
            DAdp.Fill(table);

            return table;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DetailedView_Load(object sender, EventArgs e)
        {

        }

        private void lstEmp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StoredExc(String job_id)
        {
            int.TryParse(job_id, out int jobId);

            using (SqlCommand cmd = new SqlCommand("GetMinMax", SqlCN))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@job_id", jobId);

                DataTable MMDT = new();
                SqlDataAdapter MMDA = new SqlDataAdapter(cmd);

                // Fill the DataTable with the results of the stored procedure
                MMDA.Fill(MMDT);

                if (MMDT.Rows.Count > 0)
                {
                    // Assume the first row contains the min and max values
                    int minLvl = Convert.ToInt32(MMDT.Rows[0]["min_lvl"]);
                    int maxLvl = Convert.ToInt32(MMDT.Rows[0]["max_lvl"]);

                    // Set the minimum and maximum values for the NumericUpDown control
                    job_lvl_UDlst.Minimum = minLvl;
                    job_lvl_UDlst.Maximum = maxLvl;

                }

            }
        }
        /*
        create proc GetMinMax @job_id int
        as 
        select min_lvl, max_lvl from jobs
        where job_id = @job_id
        */

        private void lstEmp_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            StoredExc(this.job_id_cmb.Text);

        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            bindingSource.MoveNext();
        }

        private void Prevbtn_Click(object sender, EventArgs e)
        {
            bindingSource.MovePrevious();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            bindingSource.EndEdit();//To make sure that we ended the updates
            try
            {
                DA.Update(DT);//return number of rows afected
                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void minit_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void job_id_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            StoredExc(job_id_cmb.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }
    }
}
