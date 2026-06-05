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
    public partial class HistoryForm : Form
    {
        MainForm MF { get; set; }
        DataAccess da = new DataAccess();

        public HistoryForm(MainForm mF)
        {
            InitializeComponent();
            MF = mF;
            LoadHistory();
        }

        private void LoadHistory()
        {
            dgvHistory.DataSource = da.GetAttendanceHistory();
        }

        private void HistoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MF.Show();
            this.Hide();
        }
    }
}
