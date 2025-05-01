using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.EntityManagers;

namespace EmployeeFormAppl
{
    public partial class frmEmpDetailedView : Form
    {
        public frmEmpDetailedView()
        {
            InitializeComponent();
        }
        /*
       create proc [dbo].[UpdateEmpLvl] @emp_id varchar(50),@job_lvl int
  as 
    update employee set job_lvl=@job_lvl where 
	emp_id=@emp_id



*/
        private void button1_Click(object sender, EventArgs e)
        {

            if (EmployeeManager.UpdateEmpLvl(empId.Text, (int)job_lvl.Value))
            {
                this.Text = "updated";
            }
            else this.Text = "Error";

        }

        private void job_lvl_ValueChanged(object sender, EventArgs e)
        {
            job_lvl.Maximum = 250;
        }
    }
}
