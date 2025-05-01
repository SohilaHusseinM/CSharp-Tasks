using System.Diagnostics;
using BLL.Entities;
using BLL.EntityLists;
using BLL.EntityManagers;

namespace EmployeeFormAppl
{
    public partial class frmEmployeeGridView : Form
    {
        public frmEmployeeGridView()
        {
            InitializeComponent();
        }

        EmployeeList employees = new EmployeeList();
        BindingSource empBindingSource;

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                employees = EmployeeManager.SelectAllEmployees();
                empBindingSource = new BindingSource(employees, "");
                dataGridView1.DataSource = empBindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach(Employee emp in employees)
            {
                Trace.WriteLine($"Employee with Id{emp.emp_id} State{emp.State}");
            }
        }
    }
}
