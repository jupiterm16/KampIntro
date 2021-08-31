using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunMarka = "Riccon";
            urun1.UrunAcıklama = "Unisex Siyah Sneaker 0012072";
            urun1.UrunFiyat = 87.30;

            Urun urun2 = new Urun();
            urun2.UrunMarka = "Tonny Black";
            urun2.UrunAcıklama = "Unisex Spor Ayakkabı Tbqnt";
            urun2.UrunFiyat = 95.99;

            Urun urun3 = new Urun();
            urun3.UrunMarka = "SOHO";
            urun3.UrunAcıklama = "Beyaz Kadın Sneaker 14361";
            urun3.UrunFiyat = 54.90;

            Urun[] urunler = new Urun[] {urun1, urun2, urun3};

            int i = 0;
            while (i<3)
            {
                Console.WriteLine(urunler[i].UrunMarka + urunler[i].UrunAcıklama+ urunler[i].UrunFiyat);
                i++;
            }


        }
        
    }
    class Urun
    {
        public string UrunMarka { get; set; }
        public string UrunAcıklama { get; set; }
        public double UrunFiyat { get; set; }


    }

}
