using System;

namespace OutKullanimi
{
	class OutParametre
	{
		int uc, bes = 0;
		public int GetSayi(int n, out int sayi)
		{

			for (int i = 1; i <= n; i++)
			{

				if (i % 3 == 0)
					uc++;

				if (i % 5 == 0)
					bes++;
			}
			sayi = bes;

			return uc;
		}
	}

	class OutOrnek
	{
		static void Main()
		{
			OutParametre op = new OutParametre();
			int a, b;

			a = op.GetSayi(25, out b);

			System.Console.WriteLine("Üçe bölünen sayısı: " + a);
			System.Console.WriteLine("Beşe bölünen sayısı: " + b);
		}
	}
}
