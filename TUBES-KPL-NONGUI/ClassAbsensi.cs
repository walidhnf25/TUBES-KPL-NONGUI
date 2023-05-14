using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.Contracts;

namespace TUBES_KPL_NONGUI
{
    public class Absensi
    {
        public List<Mahasiswa> DaftarMahasiswa { get; set; }

        public Absensi()
        {
            DaftarMahasiswa = new List<Mahasiswa>();
        }

        public void TambahMahasiswa(string nama)
        {
            DaftarMahasiswa.Add(new Mahasiswa { Nama = nama, Kehadiran = 0 });
        }

        public void TandaiKehadiran(string nama)
        {
            foreach (Mahasiswa mhs in DaftarMahasiswa)
            {
                if (mhs.Nama == nama)
                {
                    mhs.Kehadiran++;
                    return;
                }
            }
        }

        public void CetakLaporanKehadiran(string mataKuliah)
        {
            Console.WriteLine("Laporan Kehadiran Mata Kuliah " + mataKuliah);
            Console.WriteLine("----------------------------------");
            foreach (Mahasiswa mhs in DaftarMahasiswa)
            {
                Console.WriteLine(mhs.Nama + ": " + mhs.Kehadiran + " kali hadir");
            }
        }

        public void CekKelayakanUTS()
        {
            Console.WriteLine("Mahasiswa yang tidak memenuhi syarat UTS:");
            Console.WriteLine("----------------------------------");
            foreach (Mahasiswa mhs in DaftarMahasiswa)
            {
                if (mhs.Kehadiran < 10)
                {
                    Console.WriteLine(mhs.Nama);
                }
            }
        }
    }
}