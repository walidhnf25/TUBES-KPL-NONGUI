using System;
using System.Collections.Generic;

namespace TUBES_KPL_NONGUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AttendanceSystem attendanceSystem = new AttendanceSystem();
            attendanceSystem.MarkAttendance("student1", true); // student1 is present
            attendanceSystem.MarkAttendance("student2", false); // student2 is absent
            attendanceSystem.MarkAttendance("student3", true); // student3 is present

            attendanceSystem.AlertAbsentStudents();
            Console.WriteLine("tes");

        }
    }

   

}
