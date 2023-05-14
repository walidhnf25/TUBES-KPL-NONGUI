using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;
using Newtonsoft.Json;

namespace TUBES_KPL_NONGUI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Membaca file konfigurasi JSON
            string json = File.ReadAllText("D:\\Praktek Smstr 4\\KPL\\KPL_Tubes\\KPL_Tubes\\JadwalKuliah.json");

            // Deserialisasi JSON menjadi objek JadwalKuliah
            JadwalKuliah jadwal = System.Text.Json.JsonSerializer.Deserialize<JadwalKuliah>(json);

            // Menampilkan jadwal kuliah seluruhnya
            jadwal.TampilkanJadwal();

            // Mencari jadwal kuliah berdasarkan hari
            Console.Write("Masukkan hari: ");
            string hari = Console.ReadLine();
            jadwal.CekJadwal(hari);

            Console.ReadLine();
        }
    }
}