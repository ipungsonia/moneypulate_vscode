using System;

namespace Keuangan
{
    public class DanaDarurat : SortirUang
    {
        double penghasilan;
        double pengeluaran;
        char status;
        public double danaDarurat;
        public double cicilDanrat;
        public double jangkaDanrat;

        public DanaDarurat()
        {

        }
        
        public DanaDarurat(double penghasilan, double pengeluaran, char status)
        {
            this.penghasilan = penghasilan;
            this.pengeluaran = pengeluaran;
            this.status = status;
        }

        public void hitung()
        {
            if(status is 'A')
            {
                danaDarurat = 6*pengeluaran;
                cicilDanrat = 0.2*penghasilan;
            }
            else if(status is 'B')
            {
                danaDarurat = 9*pengeluaran;
                cicilDanrat = 0.2*penghasilan;
            }
            else if(status is 'C')
            {
                danaDarurat = 12*pengeluaran;
                cicilDanrat = 0.2*penghasilan;
            }
            else
            {
                Console.WriteLine("Input status yang kamu masukkan salah.");
            }

            jangkaDanrat = Math.Ceiling(danaDarurat/cicilDanrat);

            Console.WriteLine("Dana Darurat yang harus kamu miliki sebesar {0}", danaDarurat);
            Console.WriteLine("Jika kamu belum memilikinya sama sekali, kamu wajib  ");
            Console.WriteLine("menyisihkan uang sebesar {0} per bulan selama {1} bulan.", cicilDanrat, jangkaDanrat);
            Console.WriteLine();
        }

    }
}