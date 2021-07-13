using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace responsiUAS
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek Kostumer
        static List<Kostumer> daftarKostumer = new List<Kostumer>();
        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";
            while (true)
            {
                TampilMenu();
                Console.Write("\nNomor Menu [1 - 4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());
                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        HapusPenjualan();
                        break;

                    case 3:
                        TampilPenjualan();
                        break;

                    case 4: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine("1. Tambah Penjualan");
            Console.WriteLine("2. Hapus Penjualan");
            Console.WriteLine("3. Tampilkan Penjualan");
            Console.WriteLine("4. Keluar");
        }
        static void TambahPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menambahkan Kostumer ke dalam collection
            Console.WriteLine();
            Console.WriteLine("Insert Data Penjualan\n");
            Kostumer Kostumer = new Kostumer();
            Console.Write("Nota                 : ");
            Kostumer.nota = Console.ReadLine();
            Console.Write("Tanggal              : ");
            Kostumer.tanggal = Console.ReadLine();
            Console.Write("Nama                 : ");
            Kostumer.nama = Console.ReadLine();
            Console.Write("Jenis[Tunai/Kredit]  : ");
            Kostumer.jenis = Console.ReadLine();
            Console.Write("Total Uang           : ");
            Kostumer.utang = Convert.ToDouble(Console.ReadLine());
            daftarKostumer.Add(Kostumer);
            Console.WriteLine();
            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void HapusPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menghapus Kostumer dari dalam collection
            int i = -1, hapus = -1;
            Console.WriteLine("Hapus Data Penjualan\n");
            Console.Write("nota : ");
            string kode = Console.ReadLine();
            foreach (Kostumer Kostumer in daftarKostumer)
            {
                i++;
                if (Kostumer.nota == kode)
                {
                    hapus = i;
                }
            }
            if (hapus != -1)
            {
                daftarKostumer.RemoveAt(hapus);
                Console.WriteLine("\nData Penjualan Berhasil dihapus");
            }
            else
            {
                Console.WriteLine("\nnota Penjualan tidak ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();
            // PERINTAH: lengkapi kode untuk menampilkan daftar Kostumer yang ada di dalam collection
            int Urut = 0;
            Console.WriteLine("Data Penjualan\n");
            foreach (Kostumer Kostumer in daftarKostumer)
            {
                Urut++;
                Console.WriteLine("{0}. {1}, {2}, {3:N0}", Urut, Kostumer.nota, Kostumer.tanggal, Kostumer.utang);
            }
            if (Urut < 1)
            {
                Console.WriteLine("Data Penjualan Tidak ada");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}