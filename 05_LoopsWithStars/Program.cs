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
            #region Alt Alta 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine("*");
            //}

            #endregion

            #region Yan Yana 10 Tane Yıldız Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.Write("*");
            //}

            #endregion

            #region Alt Alta 10 Tane Yıldız Oluşturma Her Satırda 10 Tane yıldız Olsun

            //for (int i = 1; i <= 10; i++)
            //{

            //    Console.WriteLine("**********");
            //}

            #endregion

            #region Dik Üçgen Oluşturma

            //for (int i = 1; i <= 10; i++)
            //{
            //    for(int j = 1; j <= i ; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}

            #endregion

            #region Ters Dik Üçgen Oluşturma

            //for (int i = 10; i > 0; i--)
            //{
            //    for(int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik Üçgen ve Ters Dik Üçgeni Alt Alta Çizdirme

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //for (int k = 9; k > 0; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Dik Üçgen ve Ters Dik Üçgeni Alt Alta Çizdirme

            //for (int i = 1; i <= 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();

            //}
            //for (int k = 9; k > 0; k--)
            //{
            //    for (int m = 1; m <= k; m++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            #endregion

            #region Yıldızlarla Baklava Dilimi Çizdirme

            ////üst kısım
            //int n = 10;
            //for (int i = 1; i <= n; i++)
            //{
            //    for (int j = n - 1; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    n -= 1;
            //    Console.WriteLine();
            //}

            ////alt kısım

            //int m = 10;
            //int z = 6;
            //for (int i = 1; i <= m; i++)
            //{
            //    for (int j = 1; j <= z; j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int k = 7; k >= 2 * i - 1; k--)
            //    {
            //        Console.Write("*");
            //    }
            //    m -= 1;
            //    z += 1;
            //    Console.WriteLine();
            //}

            #endregion

            #region Piramit
            //int n = 5;
            //for (int i = 1; i <= n; i++)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region Ters Piramit
            //int n = 5;
            //for (int i = n; i >= 1; i--)
            //{
            //    //boşluklar
            //    for (int j = n - i; j > 0; j--)
            //    {
            //        Console.Write(" ");
            //    }
            //    //yıldızlar
            //    for (int k = 1; k <= 2 * i - 1; k++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion


            Console.Read();
        }
    }
}
