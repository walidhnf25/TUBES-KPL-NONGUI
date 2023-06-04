using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Selamat datang di program absensi!");

        while (true)
        {
            Console.WriteLine("\nSilakan pilih opsi:");
            Console.WriteLine("1. Absensi dengan pendekatan table-driven");
            Console.WriteLine("2. Absensi dengan menggunakan library");
            Console.WriteLine("0. Keluar dari program");

            Console.Write("Pilihan Anda: ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Terima kasih! Sampai jumpa lagi.");
                break;
            }

            if (input == "1")
            {
                TableDrivenAbsensi();
            }
            else if (input == "2")
            {
                LibraryAbsensi();
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid. Silakan coba lagi.");
            }
        }
    }

    static void TableDrivenAbsensi()
    {
        Console.WriteLine("\nAnda memilih absensi dengan pendekatan table-driven.");

        AbsensiTableDriven absensi = new AbsensiTableDriven();

        while (true)
        {
            Console.WriteLine("\nSilakan pilih opsi absensi:");
            Console.WriteLine("1. Masuk");
            Console.WriteLine("2. Keluar");
            Console.WriteLine("0. Kembali ke menu utama");

            Console.Write("Pilihan Anda: ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                break;
            }

            absensi.ProsesAbsensi(input);
        }
    }

    static void LibraryAbsensi()
    {
        Console.WriteLine("\nAnda memilih absensi dengan menggunakan library.");

        AbsensiLibrary.Absensi absensi = new AbsensiLibrary.Absensi();
        absensi.MulaiAbsensi();
    }
}

class AbsensiTableDriven
{
    private readonly Action[] absensiData;

    public AbsensiTableDriven()
    {
        absensiData = new Action[]
        {
            AbsenMasuk,
            AbsenKeluar
        };
    }

    public void ProsesAbsensi(string input)
    {
        if (int.TryParse(input, out int pilihan) && pilihan >= 1 && pilihan <= absensiData.Length)
        {
            absensiData[pilihan - 1].Invoke();
        }
        else
        {
            Console.WriteLine("Opsi absensi tidak valid. Silakan coba lagi.");
        }
    }

    private void AbsenMasuk()
    {
        // Simulasikan proses absensi masuk di sini
        Console.WriteLine("Anda berhasil melakukan absensi masuk.");
    }

    private void AbsenKeluar()
    {
        // Simulasikan proses absensi keluar di sini
        Console.WriteLine("Anda berhasil melakukan absensi keluar.");
    }
}
