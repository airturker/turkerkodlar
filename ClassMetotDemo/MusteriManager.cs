using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri eklendi! : " + musteri.Adi);
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteri silindi! : " + musteri.Adi);
        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine("Tebrikler. Müşteriler listelendi! : " + musteri.Adi);
        }
    }
}
