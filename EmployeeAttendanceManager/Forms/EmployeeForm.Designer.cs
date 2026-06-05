namespace EmployeeAttendanceManager.Forms
{
    partial class EmployeeForm
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
            panel1 = new Panel();
            btnClear = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            txtDept = new TextBox();
            txtEmpName = new TextBox();
            txtEmpId = new TextBox();
            lblEmpDept = new Label();
            lblEmpName = new Label();
            lblEmpId = new Label();
            panel2 = new Panel();
            dgvAllEmp = new DataGridView();
            panel3 = new Panel();
            label1 = new Label();
            btnBack = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAllEmp).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnClear);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnUpdate);
            panel1.Controls.Add(btnAdd);
            panel1.Controls.Add(txtDept);
            panel1.Controls.Add(txtEmpName);
            panel1.Controls.Add(txtEmpId);
            panel1.Controls.Add(lblEmpDept);
            panel1.Controls.Add(lblEmpName);
            panel1.Controls.Add(lblEmpId);
            panel1.Location = new Point(12, 85);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 195);
            panel1.TabIndex = 0;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.Gray;
            btnClear.Font = new Font("Segoe UI", 12F);
            btnClear.Location = new Point(620, 133);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(116, 50);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Font = new Font("Segoe UI", 12F);
            btnDelete.Location = new Point(484, 133);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(116, 50);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.SteelBlue;
            btnUpdate.Font = new Font("Segoe UI", 12F);
            btnUpdate.Location = new Point(345, 133);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(116, 50);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Green;
            btnAdd.Font = new Font("Segoe UI", 12F);
            btnAdd.Location = new Point(207, 133);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtDept
            // 
            txtDept.Font = new Font("Segoe UI", 12F);
            txtDept.Location = new Point(444, 88);
            txtDept.Name = "txtDept";
            txtDept.Size = new Size(307, 34);
            txtDept.TabIndex = 6;
            // 
            // txtEmpName
            // 
            txtEmpName.Font = new Font("Segoe UI", 12F);
            txtEmpName.Location = new Point(444, 49);
            txtEmpName.Name = "txtEmpName";
            txtEmpName.Size = new Size(307, 34);
            txtEmpName.TabIndex = 5;
            // 
            // txtEmpId
            // 
            txtEmpId.Font = new Font("Segoe UI", 12F);
            txtEmpId.Location = new Point(444, 10);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(307, 34);
            txtEmpId.TabIndex = 4;
            // 
            // lblEmpDept
            // 
            lblEmpDept.AutoSize = true;
            lblEmpDept.Font = new Font("Segoe UI", 15F);
            lblEmpDept.Location = new Point(194, 86);
            lblEmpDept.Name = "lblEmpDept";
            lblEmpDept.Size = new Size(148, 35);
            lblEmpDept.TabIndex = 3;
            lblEmpDept.Text = "Department";
            // 
            // lblEmpName
            // 
            lblEmpName.AutoSize = true;
            lblEmpName.Font = new Font("Segoe UI", 15F);
            lblEmpName.Location = new Point(194, 47);
            lblEmpName.Name = "lblEmpName";
            lblEmpName.Size = new Size(198, 35);
            lblEmpName.TabIndex = 2;
            lblEmpName.Text = "Employee Name";
            // 
            // lblEmpId
            // 
            lblEmpId.AutoSize = true;
            lblEmpId.Font = new Font("Segoe UI", 15F);
            lblEmpId.Location = new Point(194, 10);
            lblEmpId.Name = "lblEmpId";
            lblEmpId.Size = new Size(156, 35);
            lblEmpId.TabIndex = 1;
            lblEmpId.Text = "Employee ID";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvAllEmp);
            panel2.Location = new Point(12, 286);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 219);
            panel2.TabIndex = 1;
            // 
            // dgvAllEmp
            // 
            dgvAllEmp.AllowUserToAddRows = false;
            dgvAllEmp.AllowUserToDeleteRows = false;
            dgvAllEmp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAllEmp.Location = new Point(3, 3);
            dgvAllEmp.Name = "dgvAllEmp";
            dgvAllEmp.ReadOnly = true;
            dgvAllEmp.RowHeadersWidth = 51;
            dgvAllEmp.Size = new Size(952, 214);
            dgvAllEmp.TabIndex = 0;
            dgvAllEmp.CellClick += dgvAllEmp_CellClick;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Location = new Point(15, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(958, 67);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(375, 46);
            label1.TabIndex = 0;
            label1.Text = "Employee Management";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.Location = new Point(12, 511);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnBack);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "EmployeeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployeeForm";
            FormClosed += EmployeeForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAllEmp).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtDept;
        private TextBox txtEmpName;
        private TextBox txtEmpId;
        private Label lblEmpDept;
        private Label lblEmpName;
        private Label lblEmpId;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private Panel panel2;
        private DataGridView dgvAllEmp;
        private Panel panel3;
        private Label label1;
        private Button btnBack;
    }
}