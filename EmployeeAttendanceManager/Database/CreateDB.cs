using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeAttendanceManager.Database
{
    public class CreateDB
    {
        public static string Conn = "Data Source=EmpAttMS.db";

        public void CreateTables()
        {
            using (var con = new SqliteConnection(Conn))
            {
                con.Open();

                var cmd = con.CreateCommand();

                cmd.CommandText = @"create table if not exists Employees( 
                        Id integer primary key autoincrement,
                        EmployeeId text not null,
                        Name text not null,
                        Department text not null )";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"create table if not exists Attendance (
                        Id integer primary key autoincrement,
                        EmployeeId text not null,
                        Date text not null,
                        CheckInTime text,
                        CheckOutTime text )";
                cmd.ExecuteNonQuery();

                cmd.CommandText = @"create table if not exists Breaks (
                        Id integer primary key autoincrement,
                        AttendanceId integer not null,
                        BreakStartTime text,
                        BreakEndTime text )";
                cmd.ExecuteNonQuery();

            }
        }
    }
}
