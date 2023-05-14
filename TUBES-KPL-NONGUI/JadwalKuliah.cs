using System;

public class JadwalKuliah
{
    private string[,] jadwal;

    // Constructor untuk inisialisasi jadwal kuliah
    public JadwalKuliah()
    {
        jadwal = new string[,]
        {
            {"Senin", "08:00-10:00", "PBO", "A1.301"},
            {"Senin", "10:00-12:00", "KPL", "A1.302"},
            {"Selasa", "08:00-10:00", "Basis Data", "A1.303"},
            {"Selasa", "10:00-12:00", "Praktikum KPL", "A1.304"},
            {"Rabu", "08:00-10:00", "Dasar Jaringan Komputer", "A1.301"},
            {"Rabu", "10:00-12:00", "Proting II", "A1.302"},
            {"Kamis", "08:00-10:00", "Pengalaman Pengguna", "A1.303"},
            {"Kamis", "10:00-12:00", "Basis Data", "A1.304"},
            {"Jumat", "08:00-10:00", "Pemrograman Berorientasi Objek", "A1.301"},
            {"Jumat", "10:00-12:00", "KPL", "A1.302"}
        };
    }

    // Method untuk mencari jadwal kuliah berdasarkan hari
    public void CekJadwal(string hari)
    {
        Console.WriteLine("Jadwal kuliah pada hari " + hari + " adalah:");

        for (int i = 0; i < jadwal.GetLength(0); i++)
        {
            if (jadwal[i, 0] == hari)
            {
                Console.WriteLine(jadwal[i, 1] + " - " + jadwal[i, 2] + " - " + jadwal[i, 3]);
            }
        }
    }

    // Method untuk menampilkan seluruh jadwal kuliah
    public void TampilkanJadwal()
    {
        Console.WriteLine("Jadwal kuliah seluruhnya adalah:");

        for (int i = 0; i < jadwal.GetLength(0); i++)
        {
            Console.WriteLine(jadwal[i, 0] + " - " + jadwal[i, 1] + " - " + jadwal[i, 2] + " - " + jadwal[i, 3]);
        }
    }
}