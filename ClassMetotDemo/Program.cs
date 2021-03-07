using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1;
            musteri1.Ad = "Edanur";
            musteri1.SoyAd = "Arslan";
            musteri1.Yas = 21;
            musteri1.Tel = 11111;


            Musteri musteri2 = new Musteri();
            musteri2.ID = 2;
            musteri2.Ad = "Hiranur";
            musteri2.SoyAd = "Çiçek";
            musteri2.Yas = 11;
            musteri2.Tel = 22222;


            Musteri musteri3 = new Musteri();
            musteri3.ID = 3;
            musteri3.Ad = "Eren";
            musteri3.SoyAd = "Cantalı";
            musteri3.Yas = 19;
            musteri2.Tel = 33333;


            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.ID);
                Console.WriteLine(musteri.Ad);
                Console.WriteLine(musteri.SoyAd);
                Console.WriteLine(musteri.Yas);
                Console.WriteLine(musteri.Tel);
                Console.WriteLine("-------------");

            }


            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriSil(musteri3);
            musteriManager.MusteriListele(musteri2);

            Console.ReadLine();

        }

    }
}

