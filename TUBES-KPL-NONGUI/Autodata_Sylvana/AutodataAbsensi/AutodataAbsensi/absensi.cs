using System;
using System.Collections.Generic;

class Program
{
    static List<string> absensi = new List<string>();

    static void Main(string[] args)
    {
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("=== Sistem Autodata Absensi ===");
            Console.WriteLine("1. Daftar Absensi");
            Console.WriteLine("2. Proses Absen");
            Console.WriteLine("3. Keluar");
            Console.Write("Pilihan Anda: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    DaftarAbsensi();
                    break;
                case "2":
                    ProsesAbsen();
                    break;
                case "3":
                    isRunning = false;
                    break;
                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void DaftarAbsensi()
    {
        Console.WriteLine("=== Daftar Absensi ===");
        Console.WriteLine("Absensi hari ini:");
        if (absensi.Count == 0)
        {
            Console.WriteLine("Belum ada absensi.");
        }
        else
        {
            foreach (string nama in absensi)
            {
                Console.WriteLine(nama);
            }
        }
    }

    static void ProsesAbsen()
    {
        Console.WriteLine("=== Proses Absen ===");
        Console.Write("Masukkan nama: ");
        string nama = Console.ReadLine();

        absensi.Add(nama);
        Console.WriteLine("Absen berhasil dilakukan untuk: " + nama);
    }
}
