using System.Collections.Generic;

namespace KehadiranLibrary
{
    public class Kehadiran
    {
        public static double HitungPresentaseKehadiran(List<Mahasiswa> daftarMahasiswa)
        {
            double totalKehadiran = 0;
            foreach (Mahasiswa mhs in daftarMahasiswa)
            {
                totalKehadiran += mhs.Kehadiran;
            }
            double presentaseKehadiran = totalKehadiran / (daftarMahasiswa.Count * 16) * 100;
            return presentaseKehadiran;
        }
    }

    public class Mahasiswa
    {
        public string Nama { get; set; }
        public int Kehadiran { get; set; }
    }
}
