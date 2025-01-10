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
            //2.4.6.8
            //sarı,kırmızı,mavi,turuncu
            //adana, ankara, istanbul, sivas
            //DeğişkenTürü[] DizininAdı = new DeğişkenTürü[Eleman Sayısı]


            //string[] colors = new string[4];
            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Sarı";
            //colors[3] = "Beyaz";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[3]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;
            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "İstanbul", "Atina", "Ankara" };
            //Console.WriteLine(cities[3]);

            #endregion

            #region Dizideki tüm elemanları listeleme
            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "MAvi", "Yeşil", "Turuncu", "Pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 85, 96, 75, 125, 635, 522, 520, 7456, 2365, 1120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%3==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', '*', '/' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myarray = { 47, 85, 95, 25, 66, 120, 77, 65, 78 };
            //int maxNumber = myarray[0];
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] >maxNumber)
            //    {
            //        maxNumber = myarray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "Ali", "Ahmet", "Ayşe", "Buse", "Cem", "Deniz" };

            //Console.WriteLine(persons.Length);

            //int[] numbers= { 47, 85, 95, 25, 66, 120, 77, 65, 78 };
            //Array.re(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers = { 47, 85, 95, 25, 66, 120, 77, 65, 78 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotlar

            //string[] customers = {"Ali","Buse","Ayşe","Merve","Çinar","Kaya"};

            //int index = Array.IndexOf(customers, "Merve");
            //Console.WriteLine(index);

            //int[] numbers = { 47, 85, 95, 25, 66, 120, 77, 65, 78 };
            //Console.WriteLine("Dizinin En Büyük Elemanı: " + numbers.Max() + "  Dizinin En Küçük Elemanı: "+numbers.Min());


            //string[] cities = new string[5];

            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write("Lütfen {i+1}. Şehri Giriniz: ");
            //    cities[i]= Console.ReadLine();
            //}


            //Console.WriteLine();
            //Console.WriteLine("-------------------------------------");
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 47, 85, 95, 25, 66, 120, 77, 65, 78 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);
            #endregion

            //int[] numbers = { 47, 85, 95, 25, 66, 120, 77, 65, 78 };

            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine("--------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i]%2==0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine("--------------------------");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            Console.Read();
        }
    }
}
