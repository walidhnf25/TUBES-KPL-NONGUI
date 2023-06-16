using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TUBES_KPL_NONGUI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public class AnalisisPresensi
        {
            private List<bool> attendanceData;

            private enum AttendanceStates
            {
                Initial,
                Improving,
                NotImproving
            }

            public AnalisisPresensi(List<bool> attendanceData)
            {
                if (attendanceData == null)
                {
                    throw new ArgumentNullException(nameof(attendanceData), "Attendance data Tidak bisa Bernilai Null.");
                }

                if (attendanceData.Any(value => value != true && value != false))
                {
                    throw new ArgumentException("Data kehadiran berisi nilai yang tidak valid. Hanya True atau False yang diperbolehkan.");
                }

                this.attendanceData = attendanceData;
            }

            public double GetAttendancePercentage()
            {
                int presentCount = attendanceData.Count(isPresent => isPresent);
                double percentage = (double)presentCount / attendanceData.Count * 100;
                return percentage;
            }

            public bool IsAttendanceImproving()
            {
                AttendanceStates currentState = AttendanceStates.Initial;
                int classCount = attendanceData.Count;
                int startIdx = Math.Max(0, classCount - 3); // 3 kelas terakhir
                int presentCountLastThree = attendanceData.GetRange(startIdx, classCount - startIdx).Count(isPresent => isPresent);

                // Memeriksa apakah ada peningkatan kehadiran
                if (presentCountLastThree < 3)
                {
                    return false;
                }

                for (int i = 1; i < classCount; i++)
                {
                    bool isPresent = attendanceData[i];
                    switch (currentState)
                    {
                        case AttendanceStates.Initial:
                            if (isPresent)
                            {
                                currentState = AttendanceStates.Improving;
                            }
                            else
                            {
                                currentState = AttendanceStates.NotImproving;
                            }
                            break;
                        case AttendanceStates.Improving:
                            if (!isPresent)
                            {
                                currentState = AttendanceStates.NotImproving;
                            }
                            break;
                        case AttendanceStates.NotImproving:
                            if (isPresent)
                            {
                                return true;
                            }
                            break;
                    }
                }

                return currentState == AttendanceStates.Improving;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text; // Mendapatkan input dari textBox1
            List<bool> attendanceData = new List<bool>();

            // Memeriksa setiap karakter input dan mengkonversikannya menjadi nilai boolean
            foreach (char c in input)
            {
                if (c == '1')
                {
                    attendanceData.Add(true);
                }
                else if (c == '0')
                {
                    attendanceData.Add(false);
                }
                else
                {
                    MessageBox.Show("Input tidak valid. Masukkan 1 untuk hadir dan 0 untuk absen.");
                    return;
                }
            }

            AnalisisPresensi analisis = new AnalisisPresensi(attendanceData);

            // Menghitung persentase kehadiran
            double percentage = analisis.GetAttendancePercentage();

            // Menampilkan hasil pada label1
            label1.Text = $"Persentase Kehadiran: {percentage}%";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
