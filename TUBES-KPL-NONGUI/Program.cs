using System;
using System.Collections.Generic;

namespace TUBES_KPL_NONGUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SystemNotifikasi attendanceSystem = new SystemNotifikasi();
            attendanceSystem.MarkAttendance("student1", true); // student1 is present
            attendanceSystem.MarkAttendance("student2", false); // student2 is absent
            attendanceSystem.MarkAttendance("student3", true); // student3 is present

            attendanceSystem.AlertAbsentStudents();

            List<bool> attendanceData = new List<bool> { true, true,false, true, true, true , true, true , true, true };
            AnalisisPresensi analisisPresensi = new AnalisisPresensi(attendanceData);
            Console.WriteLine("Persentase Hadir: {0}", analisisPresensi.GetAttendancePercentage());
            Console.WriteLine("Apakah mahasiswa selalu hadir? {0}", analisisPresensi.IsAttendanceImproving() ? "Ya" : "Tidak");
            

        }
    }



}
