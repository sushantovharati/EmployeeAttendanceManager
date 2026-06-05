namespace EmployeeAttendanceManager
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlDashboard = new Panel();
            btnHistory = new Button();
            btnBreak = new Button();
            btnAttendance = new Button();
            btnEmployee = new Button();
            pnlDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // pnlDashboard
            // 
            pnlDashboard.Controls.Add(btnHistory);
            pnlDashboard.Controls.Add(btnBreak);
            pnlDashboard.Controls.Add(btnAttendance);
            pnlDashboard.Controls.Add(btnEmployee);
            pnlDashboard.Location = new Point(1, -1);
            pnlDashboard.Name = "pnlDashboard";
            pnlDashboard.Size = new Size(983, 560);
            pnlDashboard.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(322, 377);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(372, 56);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "Attendance History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnBreak
            // 
            btnBreak.Location = new Point(322, 279);
            btnBreak.Name = "btnBreak";
            btnBreak.Size = new Size(372, 56);
            btnBreak.TabIndex = 2;
            btnBreak.Text = "Break Management";
            btnBreak.UseVisualStyleBackColor = true;
            btnBreak.Click += btnBreak_Click;
            // 
            // btnAttendance
            // 
            btnAttendance.Location = new Point(322, 185);
            btnAttendance.Name = "btnAttendance";
            btnAttendance.Size = new Size(372, 56);
            btnAttendance.TabIndex = 1;
            btnAttendance.Text = "Attendance Management";
            btnAttendance.UseVisualStyleBackColor = true;
            btnAttendance.Click += btnAttendance_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(322, 92);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(372, 56);
            btnEmployee.TabIndex = 0;
            btnEmployee.Text = "Employee Management";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(pnlDashboard);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            pnlDashboard.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlDashboard;
        private Button btnHistory;
        private Button btnBreak;
        private Button btnAttendance;
        private Button btnEmployee;
    }
}
