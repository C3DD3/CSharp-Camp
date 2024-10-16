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
            ////2,4,6,8
            ////sarı, kırmızı, mavi, yeşil, mor
            ////adana, giresun, ordu, istanbul, samsun
            ////DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElemanSayısı]

            //String[] colors = new String[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Mavi";
            //colors[2] = "Mor";
            //colors[3] = "Yeşil";

            //for (int i = 0; i < 4; i++)
            //{
            //    colors[i] = colors[i] ;
            //    Console.WriteLine(colors[i]);
            //}

            //string[] cities = { "istanbul", "Giresun", "Hakkari", "Şırnak" };

            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizide ki Tüm Elemanları Listeleme

            //// String

            //string[] colors = { "Kırmızı", "Mavi", "Yeşil", "Mor", "Sarı", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            ////İnt

            //int[] num = { 1, 28, 34, 42, 78, 45, 223, 25, 23 };

            //for (int i = 0; i < num.Length; i++)
            //{
            //    if (num[i] % 3 == 0)
            //    {
            //        Console.WriteLine(num[i]);
            //    }
            //}

            ////Char

            //char[] symbols = { 'a', 'b', 'c', '*', '/', '-' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //} 

            #endregion

            #region Integer Bir Dizideki Elemanların En Büyüğünü Bulma

            //int[] myArray = { 48, 75, 125, 456, 248, 77, 28, 34, 1453 };
            //int maxNum = 0;

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNum)
            //    {
            //        maxNum = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNum);

            #endregion

            #region Dizi Metotları

            //// Sort --> Büyükten Küçüğe Sıralama

            //int[] nums = { 1, 8, 11, 25, 65, 45, 24, 28 };
            //Array.Sort(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //// Reverse --> Dizinin Elemanlarını Tersten Sıralama

            //int[] nums = { 1, 8, 11, 25, 65, 45, 24, 28 };
            //Array.Reverse(nums);
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}

            //// Aranan Elemanın Hangi İndexte Olduğunu Dönen Metot

            //string[] customers = { "Ali", "Veli", "Eyüp", "Sinan", "Cedde" };
            //int index = Array.IndexOf(customers, "Cedde");
            //Console.WriteLine(index);

            //// Max ve Min Metotları da Mevcut Bunlar Yeterince Yapılabilir Bulduğum İçin Yazmayacağım

            #endregion

            #region Kullanıcıdan Dizinin Eleman Değerlerini Alma

            string[] cities = new string[4];

            for (int i = 0; i < 4; i++) 
            {

                Console.Write($"Diziye eklemek istediğiniz {i + 1}. elemanı giriniz: "); //Dolar Sembolu parametresel ifadeleri tırnak düzenini bozmadan kullanabilmemizi sağlar
                cities[i] = Console.ReadLine();
            }

            Console.WriteLine();
             
            for (int j = 0; j < cities.Length; j++) {
                Console.WriteLine(cities[j]);
            }

                #endregion


                Console.Read();

        }
    }
}
