using EmployeeAttendanceManager.Forms;

namespace EmployeeAttendanceManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {

            new EmployeeForm(this).Show();
            this.Hide();
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            new AttendanceForm(this).Show();
            this.Hide();
        }

        private void btnBreak_Click(object sender, EventArgs e)
        {
            new BreakForm(this).Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            new HistoryForm(this).Show();
            this.Hide();
        }
    }
}
