using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBES_KPL_NONGUI
{
    public class SystemNotifikasi
    {
        private Dictionary<string, bool> attendanceData;
        private Dictionary<bool, string> attendanceStatus;

        public SystemNotifikasi()
        {
            attendanceData = new Dictionary<string, bool>();
            attendanceStatus = new Dictionary<bool, string> {
            { true, "Hadir" },
            { false, "absen" }
        };
        }

        public void MarkAttendance(string studentId, bool isPresent)
        {
            attendanceData[studentId] = isPresent;
        }

        public void AlertAbsentStudents()
        {
            foreach (KeyValuePair<string, bool> studentAttendance in attendanceData)
            {
                string studentId = studentAttendance.Key;
                bool isPresent = studentAttendance.Value;
                string attendanceStatusMsg = attendanceStatus[isPresent];
                Console.WriteLine("Notifikasi Absen {0}: anda {1} dari kelas hari ini.", studentId, attendanceStatusMsg);
                // You could also send an email or text message to the student here
            }
        }
    }
}
