using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region IF
			//int sinav1, sinav2, sinav3,ort;
			//string results;

			//Console.Write("1.Sınav :");
			//sinav1 = int.Parse(Console.ReadLine());

			//Console.Write("2.Sınav :");
			//sinav2 = int.Parse(Console.ReadLine());

			//Console.Write("3.Sınav :");
			//sinav3 = int.Parse(Console.ReadLine());

			//ort = (sinav1 + sinav2 + sinav3) / 3;

			//if (ort > 0 & ort<70)
			//{
			//	Console.WriteLine("Kaldı");
			//}
			//if (ort > 70 & ort < 100)
			//{
			//	Console.WriteLine("Geçti");
			//}
			//else
			//{
			//	Console.WriteLine("Hatalı sonuç");		

			//}
			//Console.Read();

			#endregion


			#region mod alma
			//int sayi1, sayi2, sonuc;
			//Console.Write("Mod alınacak sayı : ");
			//sayi1 = int.Parse(Console.ReadLine());

			//Console.WriteLine("Kaça göre modu alınacak :");
			//sayi2 = int.Parse(Console.ReadLine());

			//sonuc = sayi1 % sayi2;

			//Console.WriteLine(sonuc);
			#endregion

			#region switch case

			int sayi1, sayi2, sonuc;
			char islem = '+';

			Console.Write("Yapılacak İşlemi Seçiniz : + - * / ");
			islem = char.Parse(Console.ReadLine());

			Console.Write("Sayi1'i giriniz : ");
			sayi1 = int.Parse(Console.ReadLine());

			Console.Write("Sayi2'yi giriniz : ");
			sayi2 = int.Parse(Console.ReadLine());

			switch (islem)
			{
				case '+': Console.WriteLine(sonuc = sayi1 + sayi2); break;
				case '-': Console.WriteLine(sonuc = sayi1 - sayi2); break;
				case '/': Console.WriteLine(sonuc = sayi1 / sayi2); break;
				case '*': Console.WriteLine(sonuc = sayi1 * sayi2); break;
				default: Console.WriteLine("Hata"); break;

			}




			#endregion



			Console.Read();

		}
	}
}
