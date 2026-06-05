namespace EmployeeAttendanceManager.Forms
{
    partial class HistoryForm
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
            dgvHistory = new DataGridView();
            btnBack = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHistory).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 67);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(326, 46);
            label1.TabIndex = 0;
            label1.Text = " Attendance History ";
            // 
            // panel2
            // 
            panel2.Controls.Add(dgvHistory);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 402);
            panel2.TabIndex = 2;
            // 
            // dgvHistory
            // 
            dgvHistory.AllowUserToAddRows = false;
            dgvHistory.AllowUserToDeleteRows = false;
            dgvHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHistory.Location = new Point(3, 3);
            dgvHistory.Name = "dgvHistory";
            dgvHistory.ReadOnly = true;
            dgvHistory.RowHeadersWidth = 51;
            dgvHistory.Size = new Size(952, 397);
            dgvHistory.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.Location = new Point(12, 505);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // HistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(btnBack);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "HistoryForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HistoryForm";
            FormClosed += HistoryForm_FormClosed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHistory).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private DataGridView dgvHistory;
        private Button btnBack;
    }
}