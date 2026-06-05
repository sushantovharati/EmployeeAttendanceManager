using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EmployeeAttendanceManager.Database
{
    public class DataAccess
    {
        private string con = CreateDB.Conn;

        public void AddEmployee(string employeeId, string name, string department)
        {
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "insert into Employees (EmployeeId, Name, Department) values (@eid, @name, @dept)";
                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dept", department);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAllEmployees()
        {
            var table = new DataTable();
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "select Id, EmployeeId, Name, Department from Employees";
                var data = cmd.ExecuteReader();
                table.Load(data);
            }
            return table;
        }

        public void UpdateEmployee(string id, string employeeId, string name, string department)
        {
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "update Employees set EmployeeId=@eid, Name=@name, Department=@dept where Id=@id";
                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dept", department);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteEmployee(string id)
        {
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = "delete from Employees where Id=@id";
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetAttendanceHistory()
        {
            var table = new DataTable();
            table.Columns.Add("Name");
            table.Columns.Add("Date");
            table.Columns.Add("Check In");
            table.Columns.Add("Check Out");
            table.Columns.Add("Total Break");

            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();
                cmd.CommandText = @"select e.Name, a.Date, a.CheckInTime, a.CheckOutTime, a.Id from Attendance a 
                join Employees e on a.EmployeeId = e.EmployeeId order by a.Date desc";
                var data = cmd.ExecuteReader();

                while (data.Read())
                {
                    string attendanceId = data["Id"].ToString();
                    string totalBreak = GetTotalBreakTime(conn, attendanceId);

                    table.Rows.Add(
                        data["Name"].ToString(),
                        data["Date"].ToString(),
                        data["CheckInTime"].ToString(),
                        data["CheckOutTime"].ToString(),
                        totalBreak
                    );
                }
            }
            return table;
        }

        private string GetTotalBreakTime(SqliteConnection conn, string attendanceId)
        {
            var cmd = conn.CreateCommand();
            cmd.CommandText = "select BreakStartTime, BreakEndTime from Breaks where AttendanceId=@aid and BreakEndTime is not null";
            cmd.Parameters.AddWithValue("@aid", attendanceId);
            var data = cmd.ExecuteReader();

            TimeSpan total = TimeSpan.Zero;
            while (data.Read())
            {
                TimeSpan start = TimeSpan.Parse(data["BreakStartTime"].ToString());
                TimeSpan end = TimeSpan.Parse(data["BreakEndTime"].ToString());
                total += end - start;
            }

            if (total == TimeSpan.Zero)
            {
                return "-";
            }
            else
            {
                return total.ToString(@"hh\:mm\:ss");
            }
        }

        public bool CheckIn(string employeeId)
        {
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                string today = DateTime.Now.ToString("yyyy-MM-dd");

                cmd.CommandText = "select count(*) from Attendance where EmployeeId=@eid and Date=@date";
                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@date", today);
                long count = (long)cmd.ExecuteScalar();

                if (count > 0) return false;

                cmd.CommandText = "insert into Attendance (EmployeeId, Date, CheckInTime) values (@eid, @date, @time)";
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool CheckOut(string employeeId)
        {
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                string today = DateTime.Now.ToString("yyyy-MM-dd");

                cmd.CommandText = "select Id, CheckOutTime from Attendance where EmployeeId=@eid and Date=@date";
                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@date", today);
                var data = cmd.ExecuteReader();

                if (!data.Read()) return false;

                string checkOutTime = data["CheckOutTime"].ToString();
                string attendanceId = data["Id"].ToString();
                data.Close();

                if (!string.IsNullOrEmpty(checkOutTime)) return false;

                cmd.CommandText = "update Attendance set CheckOutTime=@time where Id=@id";
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@id", attendanceId);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool BreakIn(string employeeId)
        {
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                string today = DateTime.Now.ToString("yyyy-MM-dd");

                cmd.CommandText = "select Id from Attendance where EmployeeId=@eid and Date=@date";
                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@date", today);
                var data = cmd.ExecuteReader();

                if (!data.Read()) return false;

                string attendanceId = data["Id"].ToString();
                data.Close();

                cmd.CommandText = "select count(*) from Breaks where AttendanceId=@aid";
                cmd.Parameters.AddWithValue("@aid", attendanceId);
                long breakCount = (long)cmd.ExecuteScalar();

                if (breakCount >= 3) return false;

                cmd.CommandText = "select count(*) from Breaks where AttendanceId=@aid and BreakEndTime is null";
                long activeBreak = (long)cmd.ExecuteScalar();

                if (activeBreak > 0) return false;

                cmd.CommandText = "insert into Breaks (AttendanceId, BreakStartTime) values (@aid, @time)";
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"));
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        public bool BreakOut(string employeeId)
        {
            using (var conn = new SqliteConnection(con))
            {
                conn.Open();
                var cmd = conn.CreateCommand();

                string today = DateTime.Now.ToString("yyyy-MM-dd");

                cmd.CommandText = "select Id from Attendance where EmployeeId=@eid and Date=@date";
                cmd.Parameters.AddWithValue("@eid", employeeId);
                cmd.Parameters.AddWithValue("@date", today);
                var data = cmd.ExecuteReader();

                if (!data.Read()) return false;

                string attendanceId = data["Id"].ToString();
                data.Close();

                cmd.CommandText = "select Id from Breaks where AttendanceId=@aid and BreakEndTime is null";
                cmd.Parameters.AddWithValue("@aid", attendanceId);
                data = cmd.ExecuteReader();

                if (!data.Read()) return false;

                string breakId = data["Id"].ToString();
                data.Close();

                cmd.CommandText = "update Breaks set BreakEndTime=@time where Id=@id";
                cmd.Parameters.AddWithValue("@time", DateTime.Now.ToString("HH:mm:ss"));
                cmd.Parameters.AddWithValue("@id", breakId);
                cmd.ExecuteNonQuery();
                return true;
            }
        }
    }
}
