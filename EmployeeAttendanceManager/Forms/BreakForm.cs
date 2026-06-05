using EmployeeAttendanceManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EmployeeAttendanceManager.Forms
{
    public partial class BreakForm : Form
    {
        MainForm MF { get; set; }
        DataAccess da = new DataAccess();

        public BreakForm(MainForm mF)
        {
            InitializeComponent();
            MF = mF;
        }

        private void BreakForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBreakIn_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "")
            {
                MessageBox.Show("Write Employee ID");
                return;
            }

            bool result = da.BreakIn(txtEmpId.Text);

            if (result)
            {
                MessageBox.Show("Break In Success");
                txtEmpId.Text = "";
            }
            else
            {
                MessageBox.Show("Break In is not possible");
            }
        }

        private void btnBreakOut_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "")
            {
                MessageBox.Show("write Employee ID");
                return;
            }

            bool result = da.BreakOut(txtEmpId.Text);

            if (result)
            {
                MessageBox.Show("Break Out success");
                txtEmpId.Text = "";
            }
            else
            {
                MessageBox.Show("Break Out is not possible");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MF.Show();
            this.Hide();
        }
    }
}
