namespace EmployeeAttendanceManager.Forms
{
    partial class BreakForm
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
            panel2 = new Panel();
            btnBack = new Button();
            btnBreakOut = new Button();
            btnBreakIn = new Button();
            txtEmpId = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnBack);
            panel2.Controls.Add(btnBreakOut);
            panel2.Controls.Add(btnBreakIn);
            panel2.Controls.Add(txtEmpId);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(958, 456);
            panel2.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Gainsboro;
            btnBack.Location = new Point(3, 417);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 36);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // btnBreakOut
            // 
            btnBreakOut.BackColor = Color.LightCoral;
            btnBreakOut.Font = new Font("Segoe UI", 12F);
            btnBreakOut.Location = new Point(519, 136);
            btnBreakOut.Name = "btnBreakOut";
            btnBreakOut.Size = new Size(167, 55);
            btnBreakOut.TabIndex = 3;
            btnBreakOut.Text = "Break Out";
            btnBreakOut.UseVisualStyleBackColor = false;
            btnBreakOut.Click += btnBreakOut_Click;
            // 
            // btnBreakIn
            // 
            btnBreakIn.BackColor = Color.DarkSeaGreen;
            btnBreakIn.Font = new Font("Segoe UI", 12F);
            btnBreakIn.Location = new Point(284, 136);
            btnBreakIn.Name = "btnBreakIn";
            btnBreakIn.Size = new Size(167, 55);
            btnBreakIn.TabIndex = 2;
            btnBreakIn.Text = "Break In";
            btnBreakIn.UseVisualStyleBackColor = false;
            btnBreakIn.Click += btnBreakIn_Click;
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
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(958, 67);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(336, 9);
            label1.Name = "label1";
            label1.Size = new Size(312, 46);
            label1.TabIndex = 0;
            label1.Text = "Break Management";
            // 
            // BreakForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "BreakForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BreakForm";
            FormClosed += BreakForm_FormClosed;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnBreakOut;
        private Button btnBreakIn;
        private TextBox txtEmpId;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private Button btnBack;
    }
}