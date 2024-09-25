using System;
using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;

namespace ClassAndObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Buku buku = new Buku("Halo halo bandung", "Megawati", 1999);
            buku.TampilkanInfo();

            Mobil mobil = new Mobil("Toyota", "Avanza", 2028);
            mobil.TampilkanSpesifikasi();

            Laptop laptop = new Laptop("HP", "Intel i2", 16, 1027);
            laptop.TampilkanSpesifikasi();

            Sepeda sepeda = new Sepeda("Racing", "Mountain Bike", 14.5);
            sepeda.TampilkanInformasi();

            Kalkulator kalkulator = new Kalkulator();
            Console.WriteLine($"Penjumlahan: {kalkulator.Tambah(10, 50)}");
            Console.WriteLine($"Pengurangan: {kalkulator.Kurang(10, 20)}");
            Console.WriteLine($"Perkalian: {kalkulator.Kali(10, 5)}");
            Console.WriteLine($"Pembagian: {kalkulator.Bagi(10, 30)}");
        }
    }
}
