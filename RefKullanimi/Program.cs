using System;

namespace RefKullanimi
{
    class Referans
    {
        public void Kare(ref int i, ref int k)
        {
            i = i * k;
        }
    }

    class RefOrnek
    {
        static void Main()
        {
            Referans rf = new Referans();

            int a = 10;
            int b = 20;
            Console.WriteLine("Çağrıdan önce: " + a);

            rf.Kare(ref a, ref b);

            Console.WriteLine("Çağrıdan sonra: " + a);
        }
    }
}
