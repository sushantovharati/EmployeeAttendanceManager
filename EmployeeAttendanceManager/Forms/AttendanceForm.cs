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
    public partial class AttendanceForm : Form
    {
        MainForm MF { get; set; }
        DataAccess da = new DataAccess();

        public AttendanceForm(MainForm mF)
        {
            InitializeComponent();
            MF = mF;
        }

        private void AttendanceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "")
            {
                MessageBox.Show("Write Employee Id");
                return;
            }

            bool result = da.CheckIn(txtEmpId.Text);

            if (result)
            {
                MessageBox.Show("Check In Successfull");
                txtEmpId.Text = "";
            }
            else
            {
                MessageBox.Show("Already Checked In");
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "")
            {
                MessageBox.Show("Write Employee ID");
                return;
            }

            bool result = da.CheckOut(txtEmpId.Text);

            if (result)
            {
                MessageBox.Show("Checked Out");
                txtEmpId.Text = "";
            }
            else
            {
                MessageBox.Show("Already Checked In or Checkd Out");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            MF.Show();
            this.Hide();
        }
    }
}
