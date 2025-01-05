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
            #region Double Değişkenler
            //double number;
            //number = 4.85;
            //Console.WriteLine(number);

            //Console.WriteLine("**** Fiyat Listesi ****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 21.45;
            //strawberryPrice = 45;
            //potatoPrice = 9.15;
            //tomatoPrice = 6.75;
            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + " Tl");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + " Tl");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + " Tl");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + " Tl");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + " Tl");
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.758;
            //potatoGram = 4.858;
            //tomatoGram = 3.745;

            //double apppleTotalPrice = applePrice * appleGram;
            //double orangeTotalPrice = orangePrice * orangeGram;
            //double strawberryTotalPrice = strawberryPrice * strawberryGram;
            //double potatoTotalPrice = potatoPrice * potatoGram;
            //double tomatoTotalPrice = tomatoPrice * tomatoGram;

            //Console.WriteLine("Alınan Ürün: Elma - Birim Fiyatı: " + applePrice + "- Gramajı: " + appleGram + " - Toplam Tutar: " + apppleTotalPrice + " Tl");
            //Console.WriteLine("Alınan Ürün: Portakal - Birim Fiyatı: " + orangePrice + "- Gramajı: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice + " Tl");
            //Console.WriteLine("Alınan Ürün: Çilek - Birim Fiyatı: " + strawberryPrice + "- Gramajı: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice + " Tl");
            //Console.WriteLine("Alınan Ürün: Patates - Birim Fiyatı: " + potatoPrice + "- Gramajı: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice + " Tl");
            //Console.WriteLine("Alınan Ürün: Domates - Birim Fiyatı: " + tomatoPrice + "- Gramajı: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice + " Tl");
            //Console.WriteLine();

            //double shoppingTotalPrice = apppleTotalPrice + tomatoTotalPrice + strawberryTotalPrice + orangeTotalPrice + potatoTotalPrice;
            //Console.WriteLine("Alışverişin Toplam Tutarı: " + shoppingTotalPrice+" TL");

            #endregion

            #region Char Değişkenler

            //ABCDEFGH
            //DEF...
            //TOPLANTI SAAT 20:00'DE
            //" '

            //Char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);
            #endregion

            #region Klavyeden veri girişleri string değişkenler


            //Console.WriteLine("**** CSharp Hava Yolları yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdendityNumber;

            //Console.Write("Yolcu Adı:");
            //passengerName = Console.ReadLine();
            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();
            //Console.Write("Yolcu Yaşı:");
            //passengerAge = Console.ReadLine();

            //Console.Write("Şehir Bilgisi:");
            //passengerCity = Console.ReadLine();
            //Console.Write("Yolcu Tc Kimlik No Bilgisi:");
            //passengerIdendityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("----------------------------------------");
            //Console.WriteLine("Yolcu Tc Kimlik No: "+passengerIdendityNumber+" - Yolcu Ad Soyad: " + passengerName + " " + passengerSurname+ " " + passengerDistrict +" / "+passengerCity + " - Yaşı: "+passengerAge);



            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice=20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabının Sayısını Giriniz: "); 
            //shoesCount = int.Parse( Console.ReadLine());

            //Console.Write("Lütfen aldığınız Bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız Tv sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine(totalPrice);

            #endregion

            #region klavyeden ondalıklı sayı işlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1. sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3. sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine();

            //Console.WriteLine("Ortalama Sınav Notunuz: " + result);
            #endregion

            #region Klavyeden karakter girişleri

            //char gender;

            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);
            #endregion
             
            Console.Read();
        }
    }
}
