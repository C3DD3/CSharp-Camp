using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //String İfadeler

            ////Foreach(1;2;3;4)

            ////1:Değişken türü
            ////2:Değişken adı
            ////3:In
            ////4:Liste, Koleksiyon, Dizi

            //string[] cities = { "Mılano", "Roma", "Budapeşte", "Ankara", "İstanbul", "Varşova" };

            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            ////Aritmetik İfadeler

            //int[] nums = { 1, 78, 42, 85, 223, 447, 79 };

            //foreach (int i in nums)
            //{
            //    Console.WriteLine(i);
            //}

            ////Dizideki Tek Sayıları Gösterme İşlemi

            //int[] nums = { 1, 78, 42, 85, 223, 447, 79 };

            //foreach (int i in nums)
            //{
            //    if (i % 2 != 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            ////Dizideki Bütün ELemanları Toplama

            //int[] nums = { 1, 78, 42, 85, 223, 447, 79 };
            //int sum = 0;

            //foreach (int i in nums)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);





            #endregion

            #region Liste İşlemlerinde Foreach Döngüsü

            //List<int> numbers = new List<int>()
            //{
            //    1,2,4,8,5,27,65,42
            //};
            ////Console.WriteLine(numbers); //verileri döndürmüyor

            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion

            #region Bir Kelimeyi Harflerine Bölme

            //string word = "Selamlar";

            //foreach (char s in word)
            //{
            //    Console.WriteLine(s);
            //}

            #endregion



            Console.Read();
        }
    }
}
