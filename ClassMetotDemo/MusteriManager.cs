using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{

    class MusteriManager
    {
        List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine("Tebrikler Musteri Listenize Eklendi ! : " + musteri.Ad + " " + musteri.SoyAd);
        }



        public void MusteriListele(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi : " + musteri.Ad + " " + musteri.SoyAd);

            foreach (Musteri Musteri in musteriler)
            {
                Console.WriteLine("Müşteri Id : " + musteri.ID);
                Console.WriteLine("Müşteri Adı : " + musteri.Ad);
                Console.WriteLine("Müşteri Soyadı : " + musteri.SoyAd);
                Console.WriteLine("Müşteri Yas :" + musteri.Yas);
                Console.WriteLine("Müşteri TelNo : " + musteri.Tel);
            }
        }


        public void MusteriSil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine("Müşteri Listeden Silinnmiştir !  : " + musteri.Ad + " " + musteri.SoyAd);
        }
    }
}