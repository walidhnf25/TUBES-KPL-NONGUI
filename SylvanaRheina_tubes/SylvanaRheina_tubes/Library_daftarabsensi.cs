using System;
using System.Collections.Generic;

namespace AbsensiLibrary
{
    public class Absensi
    {
        private Dictionary<string, Action> absensiData;

        public Absensi()
        {
            absensiData = new Dictionary<string, Action>()
            {
                { "masuk", AbsenMasuk },
                { "keluar", AbsenKeluar }
            };
        }

        public void MulaiAbsensi()
        {
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
}
