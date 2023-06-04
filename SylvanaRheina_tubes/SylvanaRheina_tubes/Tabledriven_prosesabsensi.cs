using System;
using System.Collections.Generic;

class Main
{
    private static void absensi(string[] args)
    {
        // Inisialisasi data absensi menggunakan pendekatan "table-driven"
        Dictionary<string, Action> absensiData = new Dictionary<string, Action>()
        {
            { "masuk", AbsenMasuk },
            { "keluar", AbsenKeluar }
        };

        Console.WriteLine("Selamat datang di sistem absensi!");

        while (true)
        {
            Console.WriteLine("\nSilakan pilih opsi absensi:");
            Console.WriteLine("1. Masuk");
            Console.WriteLine("2. Keluar");
            Console.WriteLine("0. Keluar dari program");

            Console.Write("Pilihan Anda: ");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.WriteLine("Terima kasih! Sampai jumpa lagi.");
                break;
            }

            if (absensiData.TryGetValue(input.ToLower(), out Action absensiAction))
            {
                absensiAction();
            }
            else
            {
                Console.WriteLine("Opsi absensi tidak valid. Silakan coba lagi.");
            }
        }
    }

    static void AbsenMasuk()
    {
        // Simulasikan proses absensi masuk di sini
        Console.WriteLine("Anda berhasil melakukan absensi masuk.");
    }

    static void AbsenKeluar()
    {
        // Simulasikan proses absensi keluar di sini
        Console.WriteLine("Anda berhasil melakukan absensi keluar.");
    }
}
