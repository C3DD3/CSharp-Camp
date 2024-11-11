using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ado.net

            string tableNumber;

            Console.WriteLine("***** C# Veri Tabanlı Ürün - Kategori Bilgi Sistemi");
            Console.WriteLine("\n\n------------------------------------------------------");
            Console.WriteLine("1-Kategoriler ");
            Console.WriteLine("2-Ürünler ");
            Console.WriteLine("3-Siparişler ");
            Console.WriteLine("4-Çıkış Yap ");

            Console.Write("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("------------------------------------------------------");

            MySqlConnection mySqlConnection = new MySqlConnection("Server=localhost; Database=EgitimKampiDb; Uid=root; Pwd=Facebok521302001;");
            mySqlConnection.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("Select * From TblCategory", mySqlConnection); 
            MySqlDataAdapter adapter = new MySqlDataAdapter(mySqlCommand);

            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            mySqlConnection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString());
                } 
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
