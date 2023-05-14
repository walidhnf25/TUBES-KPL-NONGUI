using System;
using System.Collections.Generic;

namespace AbsensiLibrary
{
    public class Absensi
    {
        private List<string> daftarPeserta;

        public Absensi()
        {
            daftarPeserta = new List<string>();
        }

        public void TambahPeserta(string nama)
        {
            daftarPeserta.Add(nama);
        }

        public void HapusPeserta(string nama)
        {
            daftarPeserta.Remove(nama);
        }

        public void CetakDaftarPeserta()
        {
            Console.WriteLine("Daftar Peserta Absensi:");
            foreach (string peserta in daftarPeserta)
            {
                Console.WriteLine(peserta);
            }
        }

        public void Absen(string nama)
        {
            if (daftarPeserta.Contains(nama))
            {
                Console.WriteLine($"{nama} telah melakukan absen.");
            }
            else
            {
                Console.WriteLine($"{nama} tidak terdaftar dalam daftar peserta.");
            }
        }
    }
}
