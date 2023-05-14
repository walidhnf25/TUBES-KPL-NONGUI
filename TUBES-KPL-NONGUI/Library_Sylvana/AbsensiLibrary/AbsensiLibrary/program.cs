using AbsensiLibrary;

class Program
{
    static void Main()
    {
        Absensi absensi = new Absensi();
        absensi.TambahPeserta("Sylvana Rheina");
        absensi.TambahPeserta("Sherentina Rhany");
        absensi.CetakDaftarPeserta();
        // Output:
        // Daftar Peserta Absensi:
        // Sylvana Rheina
        // Sherentina Rhany

        absensi.Absen("John Sena");
        absensi.Absen("Marie Johnson");
        // Output:
        // John Sena telah melakukan absen.
        // Marie Johnson tidak terdaftar dalam daftar peserta.
    }
}
