namespace Mahasiswa
{
    public class Mahasiswa
    {
        private string v1;
        private string v2;

        public string? Nama { get; set; }
        public string? Nim { get; set; }
        public string? Hadir { get; set; }
        public List<string>? MataKuliah { get; set; }
        public int? Year { get; set; }

        public Mahasiswa() { }
        public Mahasiswa(string Nama, string Nim, string Hadir, List<String> MataKuliah, int year)
        {
            this.Nama = Nama;
            this.Nim = Nim;
            this.Hadir = Hadir;
            this.Year = year;
            this.MataKuliah = MataKuliah;
        }

        public Mahasiswa(string v1, string v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }
}
