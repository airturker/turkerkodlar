using System;

namespace OutKullanimi
{
    class Program
    {
        static void Main()
        {
            int x = 5;

            Console.WriteLine("ilk değer : " + x);

            degistir(out x);

            Console.WriteLine("out'den gelen değer : " + x); //out birden fazla değişken için döndürülür. ve değer atanmayabilir. (int x;)
        }

        static void degistir(out int y)
        {
            y = 30;
        }
    }
}
