using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUBES_KPL_NONGUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Absensi absensi = new Absensi();

            Console.Write("Masukkan jumlah mahasiswa: ");
            int jumlahMahasiswa = int.Parse(Console.ReadLine());

            for (int i = 0; i < jumlahMahasiswa; i++)
            {
                Console.Write("Masukkan nama mahasiswa: ");
                string nama = Console.ReadLine();
                absensi.TambahMahasiswa(nama);
            }

            Console.Write("Masukkan mata kuliah: ");
            string mataKuliah = Console.ReadLine();

            bool berjalan = true;
            while (berjalan)
            {
                Console.WriteLine("Pilih opsi:");
                Console.WriteLine("1. Tandai kehadiran");
                Console.WriteLine("2. Cetak laporan kehadiran");
                Console.WriteLine("3. Cek kelayakan UTS");
                Console.WriteLine("4. Keluar");

                int opsi = int.Parse(Console.ReadLine());

                switch (opsi)
                {
                    case 1:
                        Console.Write("Masukkan nama mahasiswa: ");
                        string nama = Console.ReadLine();
                        absensi.TandaiKehadiran(nama);
                        break;
                    case 2:
                        absensi.CetakLaporanKehadiran(mataKuliah);
                        break;
                    case 3:
                        absensi.CekKelayakanUTS();
                        break;
                    case 4:
                        berjalan = false;
                        break;
                    default:
                        Console.WriteLine("Opsi tidak valid");
                        break;
                }
            }
        }
    }
}