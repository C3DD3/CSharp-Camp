using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Şuana_Kadar_ki_Konularla_Genel_Örnek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Örnek Sınav Sistemi Uygulaması

            Console.WriteLine("***** C# Eğitim Kampı Sınav Uygulaması *****\n\n\n\n");

            //Sınıftaki öğrencilerin sayısını kullanıcıdan alma
            Console.WriteLine("----------------------------------------");
            Console.Write("Sınıfınızda Kaç Öğrenci Var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("----------------------------------------");

            //Öğrenci isimlerini ve not ortalamalarını saklayacak diziler

            string[] studentNames = new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"\n{i+1}. Öğrencinin adını giriniz: ");
                studentNames[i] = Console.ReadLine();
                Console.WriteLine();

                double totalExamResult = 0;

                //Her Öğrenci İçin 3 Tane Sınav Notu Alma

                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"{studentNames[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());

                    totalExamResult += value;
                }

                studentExamAvg[i] = totalExamResult / 3;
            }

            //Sınav Ortalamalarını Gösterme
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Öğrencilerin İsim Bazlı Ortalaması ve Geçip Kalma Durumu");
            Console.WriteLine("----------------------------------------------------------\n");

            for (int i = 0;i < studentCount;i++)
            {
                Console.WriteLine($"{studentNames[i]} isimli öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin Ortalaması ve Geçip Kalma Durumu
                if(studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersi geçti.\n");
                }
                else
                {
                    Console.WriteLine($"{studentNames[i]} adlı öğrenci dersten kaldı.\n");
                }
            }





            #endregion
            Console.Read();
        }
    }
}
