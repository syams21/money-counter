using System;

namespace Uang
{
    class Program
    {
        static void Main(string[] args)
        {
            int seratusRibuan, limaPuluhRibuan, duaPuluhRibuan, sepuluhRibuan, limaRibuan, duaRibuan, seribu, total;
            Console.Write("Masukkan jumlah uang 100 ribuan: ");
            seratusRibuan = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah uang 50 ribuan: ");
            limaPuluhRibuan = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah uang 20 ribuan: ");
            duaPuluhRibuan = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah uang 10 ribuan: ");
            sepuluhRibuan = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah uang 5 ribuan: ");
            limaRibuan = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah uang 2 ribuan: ");
            duaRibuan = int.Parse(Console.ReadLine());
            Console.Write("Masukkan jumlah uang 1 ribu: ");
            seribu = int.Parse(Console.ReadLine());

            total = (seratusRibuan * 100000) + (limaPuluhRibuan * 50000) + (duaPuluhRibuan * 20000) + (sepuluhRibuan * 10000) + (limaRibuan * 5000) + (duaRibuan * 2000) + (seribu * 1000);
            Console.WriteLine("Total uang Anda adalah: Rp " + total);
        }
    }
}
