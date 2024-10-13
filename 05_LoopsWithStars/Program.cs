using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_LoopsWithStars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Dik üçgen oluşturma

			//for (int i = 1; i <= 5; i++)
			//{
			//	for (int j = 1; j <=i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			#endregion

			#region Ters üçgen oluşturma

			//for (int i = 5; i>=1; i--)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			//Console.ReadLine();
			#endregion

			#region Ters Ve Dik Üçgen Beraber
			//for (int i = 1; i <= 5; i++)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}

			//for (int i = 5; i >= 1; i--)
			//{
			//	for (int j = 1; j <= i; j++)
			//	{
			//		Console.Write("*");
			//	}
			//	Console.WriteLine();
			//}
			//Console.ReadLine();
			#endregion

			#region Baklama Dilimi
			
				int n = 5; // Baklavanın yarı yüksekliği

				// Baklavanın üst kısmı
				for (int i = 1; i <= n; i++)
				{
					// Boşlukları yazdırma
					for (int j = n - i; j > 0; j--)
					{
						Console.Write(" ");
					}

					// Yıldızları yazdırma
					for (int k = 1; k <= (2 * i - 1); k++)
					{
						Console.Write("*");
					}

					Console.WriteLine(); // Satır atlama
				}

				// Baklavanın alt kısmı
				for (int i = n - 1; i >= 1; i--)
				{
					// Boşlukları yazdırma
					for (int j = n - i; j > 0; j--)
					{
						Console.Write(" ");
					}

					// Yıldızları yazdırma
					for (int k = 1; k <= (2 * i - 1); k++)
					{
						Console.Write("*");
					}

					Console.WriteLine(); // Satır atlama
				}
				Console.ReadLine();

		#endregion


	}
}
}
