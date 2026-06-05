namespace EmployeeAttendanceManager.Forms
{
    partial class AttendanceForm
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
            label1 = new Label();
            panel2 = new Panel();
            BtnBack = new Button();
            btnCheckOut = new Button();
            btnCheckIn = new Button();
            txtEmpId = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 67);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(402, 46);
            label1.TabIndex = 0;
            label1.Text = "Attendance Management";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnBack);
            panel2.Controls.Add(btnCheckOut);
            panel2.Controls.Add(btnCheckIn);
            panel2.Controls.Add(txtEmpId);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 456);
            panel2.TabIndex = 1;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Gainsboro;
            BtnBack.Location = new Point(0, 420);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 36);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Back";
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // btnCheckOut
            // 
            btnCheckOut.BackColor = Color.LightCoral;
            btnCheckOut.Font = new Font("Segoe UI", 12F);
            btnCheckOut.Location = new Point(519, 136);
            btnCheckOut.Name = "btnCheckOut";
            btnCheckOut.Size = new Size(167, 55);
            btnCheckOut.TabIndex = 3;
            btnCheckOut.Text = "Check Out";
            btnCheckOut.UseVisualStyleBackColor = false;
            btnCheckOut.Click += btnCheckOut_Click;
            // 
            // btnCheckIn
            // 
            btnCheckIn.BackColor = Color.DarkSeaGreen;
            btnCheckIn.Font = new Font("Segoe UI", 12F);
            btnCheckIn.Location = new Point(284, 136);
            btnCheckIn.Name = "btnCheckIn";
            btnCheckIn.Size = new Size(167, 55);
            btnCheckIn.TabIndex = 2;
            btnCheckIn.Text = "Check In";
            btnCheckIn.UseVisualStyleBackColor = false;
            btnCheckIn.Click += btnCheckIn_Click;
            // 
            // txtEmpId
            // 
            txtEmpId.Font = new Font("Segoe UI", 15F);
            txtEmpId.Location = new Point(446, 49);
            txtEmpId.Name = "txtEmpId";
            txtEmpId.Size = new Size(240, 41);
            txtEmpId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(284, 52);
            label2.Name = "label2";
            label2.Size = new Size(156, 35);
            label2.TabIndex = 0;
            label2.Text = "Employee ID";
            // 
            // AttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "AttendanceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AttendanceForm";
            FormClosed += AttendanceForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnCheckOut;
        private Button btnCheckIn;
        private TextBox txtEmpId;
        private Label label2;
        private Button BtnBack;
    }
}