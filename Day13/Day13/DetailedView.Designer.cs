namespace Day13
{
    partial class DetailedView
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
            label1 = new Label();
            emp_id_txt = new TextBox();
            job_lvl_UDlst = new NumericUpDown();
            lstEmp = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label4 = new Label();
            fname_txt = new TextBox();
            lname_txt = new TextBox();
            job_id_cmb = new ComboBox();
            pub_id_cmb = new ComboBox();
            hire_date = new DateTimePicker();
            minit_cmb = new ComboBox();
            nextbtn = new Button();
            Prevbtn = new Button();
            Savebtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)job_lvl_UDlst).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(175, 45);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "emp_id";
            label1.Click += label1_Click;
            // 
            // emp_id_txt
            // 
            emp_id_txt.Location = new Point(262, 38);
            emp_id_txt.Name = "emp_id_txt";
            emp_id_txt.Size = new Size(125, 27);
            emp_id_txt.TabIndex = 1;
            // 
            // job_lvl_UDlst
            // 
            job_lvl_UDlst.Location = new Point(392, 188);
            job_lvl_UDlst.Name = "job_lvl_UDlst";
            job_lvl_UDlst.Size = new Size(150, 27);
            job_lvl_UDlst.TabIndex = 2;
            // 
            // lstEmp
            // 
            lstEmp.FormattingEnabled = true;
            lstEmp.Location = new Point(681, 13);
            lstEmp.Name = "lstEmp";
            lstEmp.Size = new Size(241, 424);
            lstEmp.TabIndex = 3;
            lstEmp.SelectedIndexChanged += lstEmp_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(458, 114);
            label2.Name = "label2";
            label2.Size = new Size(53, 20);
            label2.TabIndex = 4;
            label2.Text = "Lname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 114);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 5;
            label3.Text = "Minit";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(305, 279);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 7;
            label5.Text = "hire_date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(43, 274);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 8;
            label6.Text = "pub_id";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(333, 190);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 9;
            label7.Text = "Job_lvl";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(46, 190);
            label8.Name = "label8";
            label8.Size = new Size(51, 20);
            label8.TabIndex = 10;
            label8.Text = "Job_id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 114);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 11;
            label4.Text = "Fname";
            // 
            // fname_txt
            // 
            fname_txt.Location = new Point(82, 111);
            fname_txt.Name = "fname_txt";
            fname_txt.Size = new Size(125, 27);
            fname_txt.TabIndex = 12;
            // 
            // lname_txt
            // 
            lname_txt.Location = new Point(517, 111);
            lname_txt.Name = "lname_txt";
            lname_txt.Size = new Size(125, 27);
            lname_txt.TabIndex = 13;
            // 
            // job_id_cmb
            // 
            job_id_cmb.FormattingEnabled = true;
            job_id_cmb.Location = new Point(103, 187);
            job_id_cmb.Name = "job_id_cmb";
            job_id_cmb.Size = new Size(151, 28);
            job_id_cmb.TabIndex = 15;
            job_id_cmb.SelectedIndexChanged += job_id_cmb_SelectedIndexChanged;
            // 
            // pub_id_cmb
            // 
            pub_id_cmb.FormattingEnabled = true;
            pub_id_cmb.Location = new Point(103, 271);
            pub_id_cmb.Name = "pub_id_cmb";
            pub_id_cmb.Size = new Size(151, 28);
            pub_id_cmb.TabIndex = 16;
            // 
            // hire_date
            // 
            hire_date.Location = new Point(392, 274);
            hire_date.Name = "hire_date";
            hire_date.Size = new Size(250, 27);
            hire_date.TabIndex = 17;
            // 
            // minit_cmb
            // 
            minit_cmb.FormattingEnabled = true;
            minit_cmb.Location = new Point(295, 110);
            minit_cmb.Name = "minit_cmb";
            minit_cmb.Size = new Size(71, 28);
            minit_cmb.TabIndex = 18;
            minit_cmb.SelectedIndexChanged += minit_cmb_SelectedIndexChanged;
            // 
            // nextbtn
            // 
            nextbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextbtn.ForeColor = Color.Black;
            nextbtn.Location = new Point(448, 363);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(94, 29);
            nextbtn.TabIndex = 19;
            nextbtn.Text = "Next";
            nextbtn.UseVisualStyleBackColor = true;
            nextbtn.Click += nextbtn_Click;
            // 
            // Prevbtn
            // 
            Prevbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Prevbtn.Location = new Point(175, 363);
            Prevbtn.Name = "Prevbtn";
            Prevbtn.Size = new Size(94, 29);
            Prevbtn.TabIndex = 20;
            Prevbtn.Text = "Prev";
            Prevbtn.UseVisualStyleBackColor = true;
            Prevbtn.Click += Prevbtn_Click;
            // 
            // Savebtn
            // 
            Savebtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Savebtn.Location = new Point(935, 396);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(94, 29);
            Savebtn.TabIndex = 21;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = true;
            Savebtn.Click += Savebtn_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 22;
            button1.Text = "Go Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DetailedView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 449);
            Controls.Add(button1);
            Controls.Add(Savebtn);
            Controls.Add(Prevbtn);
            Controls.Add(nextbtn);
            Controls.Add(minit_cmb);
            Controls.Add(hire_date);
            Controls.Add(pub_id_cmb);
            Controls.Add(job_id_cmb);
            Controls.Add(lname_txt);
            Controls.Add(fname_txt);
            Controls.Add(label4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstEmp);
            Controls.Add(job_lvl_UDlst);
            Controls.Add(emp_id_txt);
            Controls.Add(label1);
            Name = "DetailedView";
            Text = "DetailedView";
            Load += DetailedView_Load;
            ((System.ComponentModel.ISupportInitialize)job_lvl_UDlst).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox emp_id_txt;
        private NumericUpDown job_lvl_UDlst;
        private ListBox lstEmp;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label4;
        private TextBox fname_txt;
        private TextBox lname_txt;
        private ComboBox job_id_cmb;
        private ComboBox pub_id_cmb;
        private DateTimePicker hire_date;
        private ComboBox minit_cmb;
        private Button nextbtn;
        private Button Prevbtn;
        private Button Savebtn;
        private Button button1;
    }
}