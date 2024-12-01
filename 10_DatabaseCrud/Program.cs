using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud --> Create, Read, Update, Delete
            Console.WriteLine("***** Menü Sipariş İşlem Paneli *****\n");
            Console.WriteLine("----------------------------------------");

            #region Kategori Ekleme İşlemi

            //Console.Write("Eklemek İstediğiniz Kategorinin Id' si: ");
            //string categoryId = Console.ReadLine();

            //Console.Write("Eklemek İstediğiniz Kategorinin İsmi: ");
            //string categoryName = Console.ReadLine();


            //MySqlConnection mySqlConnection = new MySqlConnection("Server=localhost; Database=EgitimKampiDb; Uid=root; Pwd=Facebok521302001;");
            //mySqlConnection.Open();

            //MySqlCommand mySqlCommand = new MySqlCommand ("insert into TblCategory (CategoryId, CategoryName) values(@p1,@p2)", mySqlConnection) ;
            //mySqlCommand.Parameters.AddWithValue("@p1", categoryId);
            //mySqlCommand.Parameters.AddWithValue("@p2", categoryName);
            //mySqlCommand.ExecuteNonQuery();
            //mySqlConnection.Close();

            //Console.WriteLine("Kategori Başarılı Bir Şekilde Eklendi.");

            #endregion

            #region Ürün Ekleme İşlemi

            //int productId;
            //string productName;
            //decimal productPrice;
            //bool productStatus;

            //Console.Write("Ürün ID: ");
            //productId = int.Parse(Console.ReadLine());

            //Console.Write("Ürün Adı: ");
            //productName = Console.ReadLine();

            //Console.Write("Ürün Fiyatı: ");
            //productPrice = decimal.Parse(Console.ReadLine());

            //MySqlConnection connection = new MySqlConnection("Server=localhost; Database=EgitimKampiDb; Uid=root; Pwd=Facebok521302001;");
            //connection.Open();

            //MySqlCommand command = new MySqlCommand("insert into TblProduct (productId, productName, productPrice, productStatus) values(@productId, @productName, @productPrice, @productStatus)", connection);

            //command.Parameters.AddWithValue("@productId", productId);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);

            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Ürün Eklemesi Başarılı...");


            #endregion

            #region Ürün Listeleme İşlemi

            //MySqlConnection connection = new MySqlConnection("Server=localhost; Database=EgitimKampiDb; Uid=root; Pwd=Facebok521302001;");
            //connection.Open();

            //MySqlCommand command = new MySqlCommand("SELECT * FROM TblProduct", connection);

            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}

            //connection.Close();

            #endregion

            #region Ürün Silme İşlemi

            //Console.Write("Silinecek Ürün ID'si: ");
            //int ProductId = int.Parse(Console.ReadLine());

            //MySqlConnection connection = new MySqlConnection("Server=localhost; Database=EgitimKampiDb; Uid=root; Pwd=Facebok521302001;");
            //connection.Open();

            //MySqlCommand command = new MySqlCommand("DELETE FROM TblProduct WHERE ProductId = @ProductId", connection);
            //command.Parameters.AddWithValue("@ProductId", ProductId);
            //command.ExecuteNonQuery();


            //MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //connection.Close();

            //Console.WriteLine("Silme İşlemi Yapıldı...");

            #endregion

            #region Ürün Güncelleme İşlemi

            //Console.Write("Güncellenecek Ürün Id: ");
            //int productId = int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek Ürün Adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek Ürünün Fiyatı: ");
            //Decimal productPrice = Decimal.Parse(Console.ReadLine());

            //MySqlConnection connection = new MySqlConnection("Server=localhost; Database=EgitimKampiDb; Uid=root; Pwd=Facebok521302001;");
            //connection.Open();

            //MySqlCommand command = new MySqlCommand("UPDATE TblProduct SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();


            //connection.Close();

            //Console.WriteLine("Güncelleme Başarılı...");

            #endregion

            Console.Read();
        }
    }
}
