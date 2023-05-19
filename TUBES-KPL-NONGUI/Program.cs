using System;
using System.Collections.Generic;

namespace TUBES_KPL_NONGUI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            SystemNotifikasi attendanceSystem = new SystemNotifikasi();

            Console.WriteLine("Sistem Presensi");
            Console.WriteLine("----------------");

            while (true)
            {
                Console.WriteLine("Pilih opsi:");
                Console.WriteLine("1. Tandai kehadiran");
                Console.WriteLine("2. Notifikasi Absen");
                Console.WriteLine("3. Analisis Presensi");
                Console.WriteLine("4. Keluar");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    Console.WriteLine("Masukkan ID mahasiswa:");
                    string studentId = Console.ReadLine();

                    Console.WriteLine("Apakah mahasiswa hadir? (y/n)");
                    string presenceInput = Console.ReadLine();
                    bool isPresent = presenceInput.ToLower() == "y";

                    attendanceSystem.MarkAttendance(studentId, isPresent);
                    Console.WriteLine("Kehadiran mahasiswa berhasil ditandai.");
                    Console.WriteLine();
                }
                else if (input == "2")
                {
                    Console.WriteLine("Notifikasi Absen Mahasiswa");
                    Console.WriteLine("-------------");

                    attendanceSystem.AlertAbsentStudents();

                    Console.WriteLine();
                }
                else if (input == "3")
                {
                    Console.WriteLine("Analisis Presensi");
                    Console.WriteLine("-----------------");

                    Console.WriteLine("Masukkan kehadiran dalam bentuk angka (1: hadir, 0: absen) dipisahkan oleh spasi:");
                    string attendanceInput = Console.ReadLine();
                    string[] attendanceArray = attendanceInput.Split(' ');

                    List<bool> attendanceList = new List<bool>();
                    foreach (string attendance in attendanceArray)
                    {
                        bool isPresent = attendance == "1";
                        attendanceList.Add(isPresent);
                    }

                    AnalisisPresensi analisisPresensi = new AnalisisPresensi(attendanceList);

                    double attendancePercentage = analisisPresensi.GetAttendancePercentage();
                    Console.WriteLine("Persentase Kehadiran: {0}%", attendancePercentage);

                    bool isImproving = analisisPresensi.IsAttendanceImproving();
                    string attendanceImprovementStatus = isImproving ? "Ya" : "Tidak";
                    Console.WriteLine("Apakah kehadiran meningkat dalam 3 kali pertemuan terakhir? " + attendanceImprovementStatus);

                    Console.WriteLine();
                }
                else if (input == "4")
                {
                    Console.WriteLine("Terima kasih telah menggunakan Sistem Presensi.");
                    break;
                }
                else
                {
                    Console.WriteLine("Input tidak valid. Silakan masukkan pilihan yang benar.");
                    Console.WriteLine();
                }
            }
        }
    }
}
