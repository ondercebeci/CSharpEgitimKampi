using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Döngüler

            //For(x,y,z)
            //x: Başlangıç değeri
            //y: Bitiş değeri
            //z: Artış-Azalış değeri
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine("C# Eğitim Kampı");
            //}

            //for (int i = 1; i <= 20; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 3; i <= 50; i+=3)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.Write("Lütfen ekrana yazılmasını istediğiniz adedi girin: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}
            #endregion

            #region For Döngüleri ile Karar Yapıları

            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i%5==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //int value = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    value += i;
            //}
            //Console.WriteLine(value);

            //int totalValue = 0;
            //for (int i = 1; i < 20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;

            //        Console.WriteLine(i);
            //    }
            //}
            //Console.WriteLine("----------------------");
            //    Console.WriteLine(totalValue);

            //int Count = 0;

            //for (int i = 1; i < 50; i++)
            //{
            //    if (i%7==0)
            //    {
            //        Count++;
            //        Console.WriteLine(i);
            //    }

            //}
            //Console.WriteLine("---------------------------------");
            //Console.WriteLine(Count);

            //int bacteriumCount = 1;

            //for (int i = 1; i <= 24; i++)
            //{
            //    bacteriumCount *= 2;
            //    Console.WriteLine(i+". saatin sonunda oluşan bakteri sayısı: " + bacteriumCount);
            //}


            #endregion

            #region While Döngüsü

            //While(Şart)
            //{
            //işlemler
            //}
            //int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}
            //int i = 1;
            //while (i<=10)
            //{
            //    if (i%3==0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;

            //}

            //int totalValue = 0;
            //int i = 1;
            //while (i<=10)
            //{
            //    totalValue += i;

            //    i++;
            //}
            //Console.WriteLine(totalValue);
            #endregion

            #region Örnek Sınav Sorusu
            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu giriniz.
            //Console.Write("3 basamaklı bir sayı giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds,sum=0;

            //ones = number % 10;
            //tens = (number % 100) / 10;
            //hundreds = number / 100;

            //sum = ones + tens + hundreds;
            //Console.WriteLine("Sayının basamak toplamları: " + sum);
            
            
            
            
         

            #endregion

            Console.Read();
        }
    }
}
