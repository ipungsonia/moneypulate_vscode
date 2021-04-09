//Nama  : Ipung Sonia Faradhisma
//NIM   : 20/463603/TK/51595
//Prodi : Teknologi Informasi

using System;

namespace Keuangan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t================================");
            Console.WriteLine("\t     WELCOME TO MONEYPULATE     ");
            Console.WriteLine("\t================================");
            Console.WriteLine();

            Console.Write("Hai! Siapa namamu? ");
            string username = Console.ReadLine();

            Console.WriteLine("Berapa penghasilan tetapmu setiap bulan?");
            double masukanBulanan = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Berapa perkiraan pengeluaran setiap bulan?");
            double keluaranBulanan = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("A)Melajang\nB)Menikah(belum memiliki anak)\nC)Menikah(sudah memiliki anak)");
            Console.WriteLine("Apa statusmu sekarang? (A/B/C) ");
            char status = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("\t================================");
            Console.WriteLine("\t    Perhitungan DANA DARURAT    ");
            Console.WriteLine("\t================================");
            DanaDarurat danrat = new DanaDarurat(masukanBulanan, keluaranBulanan, status);
            danrat.hitung();
            Console.WriteLine();

            Console.WriteLine("\t=================================");
            Console.WriteLine("\t   Perhitungan UANG INVESTASI    ");
            Console.WriteLine("\t=================================");
            MulaiInvestasi invest = new MulaiInvestasi(masukanBulanan, keluaranBulanan, danrat.cicilDanrat);
            invest.hitung();
            Console.WriteLine();

            Console.WriteLine("\t================================");
            Console.WriteLine("\t    Perhitungan DANA IMPIAN     ");
            Console.WriteLine("\t================================");
            Console.Write("Apakah kamu memiliki barang impian yang hendak dibeli?(Y/T) ");
            char adaBarang = Convert.ToChar(Console.ReadLine());
            DanaImpian danim = new DanaImpian(masukanBulanan, keluaranBulanan, adaBarang, invest.investasi);

            danim.hitung();
            Console.WriteLine("\n");

            Console.WriteLine("\t================================");
            Quotes kutipan = new Quotes();
            kutipan.showQuotes();
        }
    }
}