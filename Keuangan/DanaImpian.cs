using System;

namespace Keuangan
{
    public class DanaImpian : SortirUang
    {
        double penghasilan;
        double pengeluaran;
        char adaBarang;
        double investasi;
        public double danaPegangan;
        public string barangImpian;
        public double hargaBarang;
        public double jangkaBarang;
        public double mulaiCicil;
        public double kurangDana;
        public double jangkaRealBarang;

        public DanaImpian()
        {

        }

        public DanaImpian(double penghasilan, double pengeluaran, char adaBarang, double investasi)
        {
            this.penghasilan = penghasilan;
            this.pengeluaran = pengeluaran;
            this.adaBarang = adaBarang;
            this.investasi = investasi;
        }

        public void hitung()
        {
            danaPegangan = 0.5*investasi;

            if(adaBarang == 'Y')
            {
                Console.Write("Barang Apa itu? ");
                barangImpian = Console.ReadLine();
                Console.Write("Berapa harganya? ");
                hargaBarang = Convert.ToDouble(Console.ReadLine());
                Console.Write("Dalam berapa bulan kamu ingin membelinya? ");
                jangkaBarang = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine();

                mulaiCicil = hargaBarang/jangkaBarang;

                if(mulaiCicil <= danaPegangan)
                {
                    Console.WriteLine("Kamu dapat membeli {0}, selama {1} bulan,", barangImpian, jangkaBarang);
                    Console.WriteLine("jika menabung sebesar {0} per bulan.", mulaiCicil);
                }
                else
                {
                    kurangDana = mulaiCicil-danaPegangan;
                    jangkaRealBarang = Math.Ceiling(hargaBarang/danaPegangan);

                    Console.WriteLine("Uang bulananmu akan terkuras!!!");
                    Console.WriteLine("Berikut saran yang dapat kami berikan: ");
                    Console.WriteLine("1)Menabung {0}, dalam {1} bulan.", danaPegangan, jangkaRealBarang);
                    Console.WriteLine("2)Mencari penghasilan tambahan minimal {0} per bulan", kurangDana);
                }

                Console.WriteLine();
                Console.WriteLine("Jangan boros menggunakan uangnya ya");
                Console.WriteLine("Kamu lebih baik menyisihkan {0} untuk berjaga-jaga", danaPegangan);
                Console.WriteLine("jika seandainya nanti terdapat keperluan mendadak.");
            }
            else
            {
                Console.WriteLine("Kamu sebaiknya menyisihkan {0} untuk berjaga-jaga ", investasi);
                Console.WriteLine("jika seandainya nanti terdapat keperluan mendadak.");
            }

        }
    }
}