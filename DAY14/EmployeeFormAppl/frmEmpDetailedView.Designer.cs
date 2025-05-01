namespace EmployeeFormAppl
{
    partial class frmEmpDetailedView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            empId = new TextBox();
            job_lvl = new NumericUpDown();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)job_lvl).BeginInit();
            SuspendLayout();
            // 
            // empId
            // 
            empId.Location = new Point(75, 108);
            empId.Name = "empId";
            empId.Size = new Size(125, 27);
            empId.TabIndex = 0;
            // 
            // job_lvl
            // 
            job_lvl.Location = new Point(75, 208);
            job_lvl.Name = "job_lvl";
            job_lvl.Size = new Size(150, 27);
            job_lvl.TabIndex = 1;
            job_lvl.ValueChanged += job_lvl_ValueChanged;
            // 
            // button1
            // 
            button1.Location = new Point(659, 363);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 2;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmEmpDetailedView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(job_lvl);
            Controls.Add(empId);
            Name = "frmEmpDetailedView";
            Text = "frmEmpDetailedView";
            ((System.ComponentModel.ISupportInitialize)job_lvl).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox empId;
        private NumericUpDown job_lvl;
        private Button button1;
    }
}