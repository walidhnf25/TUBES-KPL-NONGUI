using System;
using System.Collections.Generic;

namespace AbsensiLibrary
{
    public class Absensi
    {
        private List<string> absensiList;

        public Absensi()
        {
            absensiList = new List<string>();
        }

        public void Absen(string nama)
        {
            absensiList.Add(nama);
            Console.WriteLine("Absen berhasil dilakukan untuk: " + nama);
        }

        public void DaftarAbsensi()
        {
            Console.WriteLine("=== Daftar Absensi ===");
            Console.WriteLine("Absensi hari ini:");
            if (absensiList.Count == 0)
            {
                Console.WriteLine("Belum ada absensi.");
            }
            else
            {
                foreach (string nama in absensiList)
                {
                    Console.WriteLine(nama);
                }
            }
        }
    }
}
