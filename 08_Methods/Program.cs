using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Void Metotlar
			// () ile biterler
			//Geriye değer döndürmeyen metotlar
			//Customer --> Listele, ekle, sil, güncelle
			//void

			void List()
			{
				Console.WriteLine("Emircan");
				Console.WriteLine("Bağdu");
			}
			List();



			#endregion

			#region Geriye Değer Döndürmeyen Parametreli Metotlar

			void WriteMethod(string name)
			{
				Console.WriteLine(name);
			}

			WriteMethod("Emircan");

			#endregion

			#region Geriye Değer Döndüren Metotlar

			string Merhaba()
			{ return "Merhaba"; }

			Merhaba();

			#endregion

			#region Geriye Değer Döndüren Parametreli Metotlar

			string Card(string name,string surname)
			{
				string cardinfo = "Ad: " + name + "		Soyad : " + surname;

				return cardinfo;
			}

			string x,y;
			Console.WriteLine("Adınızı Giriniz: ");
			x= Console.ReadLine();
			Console.WriteLine("Soyadınızı Giriniz");
			y= Console.ReadLine();

			 Console.WriteLine(Card(x,y));
			Console.WriteLine(Card("Emircan", "KAYAA"));


			#endregion
			Console.ReadLine();
		}
	}
}
