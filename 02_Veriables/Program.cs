using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Veriables
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region double değişkenler
			////ondalıklı sayılar için kullanılır.

			//double number;
			//number = 7.75;
			//Console.WriteLine(number);//Ekrana yazdırma 


			#endregion

			#region Char Değişkenler
			////Karakter tutmak için kullanılır.
			//char symbol= 'A';
			//Console.WriteLine(symbol);
			#endregion

			#region Klavyeden veri girişleri 

			Console.WriteLine("*******CSharp Hava Yolları Yolcu Bilgisi *******");
			Console.WriteLine();
			string passsengerName, passengerSurname;
			int price;
			Console.Write("Yolcu Adı : ");
			passsengerName =Console.ReadLine();

			Console.Write("Yolcu Soyadı : ");
			passengerSurname =Console.ReadLine();

			Console.Write("Fiyat");
			price = int.Parse(Console.ReadLine());//girilen sayıyı int türüne çevirme double olursa double char olursa char yazılır.

			Console.WriteLine();
			Console.WriteLine("Yolcu: "+passsengerName+" "+passengerSurname);
			Console.WriteLine("Fiyat:"+price);

			#endregion

			Console.Read();//Herhangi bir tuşa basana kadar console kapanmaz.
		}
	}
}
