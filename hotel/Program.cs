using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char ulangi;

            do
            {
                Console.Clear();

                int jumlahTamu, lamaMenginap, jenisKamar;
                double hargaKamar = 0, totalBiaya = 0, diskon = 0, totalBayar = 0;

                Console.WriteLine("Program Menghitung Pembayaran di Hotel");
                Console.WriteLine("=====================================");

                Console.Write("Masukkan Jumlah Tamu : ");
                jumlahTamu = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lama Menginap (dalam hari) : ");
                lamaMenginap = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Pilihan Jenis Kamar:");
                Console.WriteLine("1. Suite (Rp. 1.500.000 per malam)");
                Console.WriteLine("2. Deluxe (Rp. 1.000.000 per malam)");
                Console.WriteLine("3. Standar (Rp. 500.000 per malam)");
                Console.Write("Pilih Jenis Kamar (1/2/3) : ");
                jenisKamar = Convert.ToInt32(Console.ReadLine());

                switch (jenisKamar)
                {
                    case 1:
                        hargaKamar = 1500000;
                        break;
                    case 2:
                        hargaKamar = 1000000;
                        break;
                    case 3:
                        hargaKamar = 500000;
                        break;
                    default:
                        Console.WriteLine("Pilihan tidak valid.");
                        break;
                }

                if (lamaMenginap >= 2 && lamaMenginap <= 3)
                {
                    diskon = hargaKamar * 0.05;
                }
                else if (lamaMenginap >= 4 && lamaMenginap <= 6)
                {
                    diskon = hargaKamar * 0.1;
                }
                else if (lamaMenginap > 7)
                {
                    diskon = hargaKamar * 0.15;
                }

                totalBiaya = hargaKamar * lamaMenginap;
                totalBayar = totalBiaya - diskon;

                Console.WriteLine("\n=====================================");
                Console.WriteLine("Jumlah Tamu         : " + jumlahTamu);
                Console.WriteLine("Lama Menginap (hari): " + lamaMenginap);
                Console.WriteLine("Jenis Kamar         : " + ((jenisKamar == 1) ? "Suite" : (jenisKamar == 2) ? "Deluxe" : "Standar"));
                Console.WriteLine("-------------------------");
                Console.WriteLine("Harga Kamar         : Rp." + hargaKamar);
                Console.WriteLine("Total Biaya         : Rp." + totalBiaya);
                Console.WriteLine("Diskon              : Rp." + diskon);
                Console.WriteLine("-------------------------");
                Console.WriteLine("Total Pembayaran    : Rp." + totalBayar);

                Console.WriteLine("\nIngin menghitung pembayaran lagi? (Y/N) ");
                ulangi = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (ulangi == 'Y' || ulangi == 'y');
        }
    }
}
