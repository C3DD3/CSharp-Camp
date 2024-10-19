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
            #region Metotlar

            ////() 
            ////Geriye değer döndürmeyen metotlar
            ////Customer --> Listele, ekle, sil, güncelle
            ////Void metotlar olarak geçerler

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan İkse");
            //    Console.WriteLine("Cengiz Aytmatov");
            //}

            //CustomerList();

            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;

            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Eyüp Sinan");

            //void CustomerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surName);
            //}

            //CustomerCard("Eyüp Sinan", "Durdu");
            //CustomerCard("Süreyya Nur", "Çomak");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1+ num2+ num3;
            //    Console.WriteLine(result);
            //}
            //Sum(1,2,3);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "CEDDE";
            //}

            //CustomerName(); ////Değer Döndü Ama Karşılığı Yok

            ////Karşılığı Olan Şekli

            //string StudentCard()
            //{
            //    string name = "Cedde";

            //    return name;
            //}

            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{

            //    string cardInfo = "Ülke: " + countryName + " \n- Başkent: " + capital + " \n- Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}

            //string x, y, z;

            //Console.Write("Ülke Adını Giriniz: ");
            //x = Console.ReadLine();

            //Console.Write("Başkenti Giriniz: ");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini Giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));

            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı-Beyaz")); //Klavyeden Girilme Koşulu Yok

            #endregion

            #region Geriye Değer Dönen İnt Parametreli Metotlar

            int Sum(int num1, int num2, int num3)
            {
                int result = num1 + num2 + num3;
                
                return result;
            }
            Console.WriteLine( Sum(1, 2, 3));

            #endregion

            #region Örnek Uygulama

            String ExamResult(string student, int exam1,  int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3 ;
                if (result >= 50)
                {
                    return student + " İsimli Öğrenci Sınavı Geçti Ortalama: " + result;
                }
                else
                {
                    return student + " Öğrenci Başarısız Oldu Ortalama: " + result;
                }
            }

            Console.WriteLine(ExamResult("Cedde", 25, 41, 85));
            Console.WriteLine(ExamResult("Kali", 36, 50, 33));
            #endregion

            Console.Read();
        }
    }
}
