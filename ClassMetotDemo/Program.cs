using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "M.Türker";
            musteri1.Soyadi = "Özakıncı";

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Engin";
            musteri2.Soyadi = "Demiroğ";

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ali";
            musteri3.Soyadi = "Veli";

            MusteriManager musterimanager = new MusteriManager();
            musterimanager.Ekle(musteri1);
            musterimanager.Sil(musteri2);
            musterimanager.Listele(musteri3);
        }
    }
}
