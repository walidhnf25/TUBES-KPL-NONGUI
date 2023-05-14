using System;
using AbsensiLibrary;

namespace AttendanceProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Inisialisasi objek automata dan library absensi
            AttendanceAutomaton automaton = new AttendanceAutomaton();
            Absensi absensi = new Absensi();

            // Tes automata absensi
            automaton.ProcessAttendance(true, false, "John Doe");   // Hadir
            automaton.ProcessAttendance(false, false, "John Doe");  // Absen
            automaton.ProcessAttendance(true, true, "John Doe");    // Terlambat
            automaton.ProcessAttendance(true, false, "John Doe");   // Hadir lagi

            // Cetak daftar hadir dari library absensi
            absensi.DaftarAbsensi();

            Console.ReadLine();
        }
    }
}
