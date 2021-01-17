using System;

namespace RefKullanimi
{
    class Program
    {
        static void Main()
        {
            int x = 5;

            Console.WriteLine("ilk değer : " + x);

            degistir(ref x);

            Console.WriteLine("ref'den gelen değer : " + x); //ref bir değişken için kullanılır. ref de ilk değer olmalıdır. (int x=5;)
        }

        static void degistir(ref int y)
        {
            y = 30;
        }
    }
}
