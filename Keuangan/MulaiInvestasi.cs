using System;

namespace Keuangan
{
    public class MulaiInvestasi : SortirUang
    {
        double penghasilan;
        double pengeluaran;
        double cicilDanrat;
        public double investasi;
        
        public MulaiInvestasi()
        {

        }

        public MulaiInvestasi(double penghasilan, double pengeluaran, double cicilDanrat)
        {
            this.penghasilan = penghasilan;
            this.pengeluaran = pengeluaran;
            this.cicilDanrat = cicilDanrat;
        }

        public void hitung()
        {
            investasi = 0.5*(penghasilan-pengeluaran-cicilDanrat);
            Console.WriteLine("Uang yang dapat diinvestasikan yaitu {0} per bulan", investasi);
            Console.WriteLine("Kamu dapat memulai dari reksadana, emas, atau saham.");
            Console.WriteLine();
        }

    }
}