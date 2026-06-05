using EmployeeAttendanceManager.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EmployeeAttendanceManager.Forms
{
    public partial class EmployeeForm : Form
    {
        MainForm MF { get; set; }

        DataAccess da = new DataAccess();
        string selectedId = "";

        public EmployeeForm(MainForm mF)
        {
            InitializeComponent();
            LoadEmployees();
            MF = mF;
        }

        private void LoadEmployees()
        {
            dgvAllEmp.DataSource = da.GetAllEmployees();
        }

        private void EmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtEmpId.Text == "" || txtEmpName.Text == "" || txtDept.Text == "")
            {
                MessageBox.Show("Please write all info");
                return;
            }

            da.AddEmployee(txtEmpId.Text, txtEmpName.Text, txtDept.Text);
            MessageBox.Show("Employee Added");
            Clear();
            LoadEmployees();
        }

        private void Clear()
        {
            txtEmpId.Text = "";
            txtEmpName.Text = "";
            txtDept.Text = "";
            selectedId = "";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Select an Employee");
                return;
            }

            da.DeleteEmployee(selectedId);
            MessageBox.Show("Employee Deleted");
            Clear();
            LoadEmployees();

        }

        private void dgvAllEmp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedId = dgvAllEmp.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                txtEmpId.Text = dgvAllEmp.Rows[e.RowIndex].Cells["EmployeeId"].Value.ToString();
                txtEmpName.Text = dgvAllEmp.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                txtDept.Text = dgvAllEmp.Rows[e.RowIndex].Cells["Department"].Value.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId == "")
            {
                MessageBox.Show("Please select an employee");
                return;
            }

            da.UpdateEmployee(selectedId, txtEmpId.Text, txtEmpName.Text, txtDept.Text);
            MessageBox.Show("Employee Updated");
            Clear();
            LoadEmployees();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MF.Show();
            this.Hide();
        }
    }
}
