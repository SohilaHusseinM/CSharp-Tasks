using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static Day13.ConnectionBase;
namespace Day13
{
    public partial class GridView : Form
    {
        SqlCommand sqlCmd;
        DataTable DT;
        SqlDataAdapter DA;
        public GridView()
        {
            InitializeComponent();
            Load_data();
        }

        private void Load_data()
        {
            sqlCmd = new SqlCommand("select * from titles", SqlCN);
            DT = new();
            DA = new SqlDataAdapter(sqlCmd);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(DA);
            DA.UpdateCommand = commandBuilder.GetUpdateCommand();
            DA.InsertCommand = commandBuilder.GetInsertCommand();
            DA.DeleteCommand = commandBuilder.GetDeleteCommand();

            DA.Fill(DT);
            dataGridView.DataSource = DT;


            //replace forign key col with combo box
            SqlCommand getPupIds = new SqlCommand("select pub_id from publishers", SqlCN);
            DataTable IdsTable = new();
            SqlDataAdapter adapterIds = new SqlDataAdapter(getPupIds);
            adapterIds.Fill(IdsTable);

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn
            {
                HeaderText = "pub_id",
                Name = "pub_id",
                DataSource = IdsTable, // Set the publisher table as the data source
                ValueMember = "pub_id", // The actual value stored in the database
                DisplayMember = "pub_id", // The name displayed in the dropdown
                DataPropertyName = "pub_id", // Bind to the pub_id column in the main table
                DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox,
                AutoComplete = true // Enable autocomplete for better UX
            };
            // Replace the existing pub_id column
            dataGridView.Columns.Remove("pub_id");
            dataGridView.Columns.Add(comboBoxColumn);

        }

        private void GridView_Load(object sender, EventArgs e)
        {



        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void commitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();//To make sure that we ended the updates
            try
            {
                DA.Update(DT);
                MessageBox.Show("Changes saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while saving changes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Start st = new Start();
            st.Show();
            this.Hide();
        }
    }
}
