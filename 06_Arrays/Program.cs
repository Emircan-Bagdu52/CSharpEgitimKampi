using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Temel Dizi Örnekleri
			////2.4.6.8
			////sarı,lacivert,kırmızı,beyaz
			////DeğişkenTürü [] DiziAdı=new DeğişkenTürü[ElemanSayısı]
			////DeğişkenTürü [] DiziAdı={"dizinin1.elemanı","dizinin2.elemanı"}
			//string[] colors = new string[4];
			//colors[0] = "sarı";
			//colors[1] = "lacivert";
			//colors[2] = "kırmızı";
			//colors[3] = "beyaz";
			//Console.WriteLine(colors[1]);
			#endregion

			#region Dizilerdeki Tüm Elemanları Listeleme

			//string[] colors = { "Sarı", "Lacivert", "Mavi", "Kırmızı", "Beyaz" };

			//for (int i = 0; i < colors.Length; i++)
			//{
			//	Console.WriteLine(colors[i]);
			//}

			#endregion

			#region Dizi Örnekler
			
			int[] myArray = { 11, 3, 25, 37, 78, 96, 100, 888, 573, 1, 3, 7 };
			int maxNumber = myArray[0];
			for (int i = 0; i < myArray.Length; i++)
			{
				if (myArray[i] > maxNumber)
				{
					maxNumber = myArray[i];
					
				}
			

			}
			Console.WriteLine(maxNumber);



			#endregion

			Console.ReadLine();
		}
	}
}
