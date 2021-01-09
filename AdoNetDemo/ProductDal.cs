
// DAL = Data access layer

// in this project I used MySQL server not SQL Server with JetBrains Rider

/*
// for sql server connection the same way with mySql // integrated security=true means connect with windows authentication
SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;initial catalog=ETrade;integrated security=true");
if(connection.State == ConnectionState.Closed){
connection.Open();
}
SqlCommand command = new Command("Select * from Product");
*/

// BU ŞEKİL KULLANILMIYORMUŞ FAKAT MANTIKEN ÖĞRENMEK ÖNEMLİ JAVADA DA BENZERİNİ YAPMIŞTIM HEPSİ AYNI MANTIK

using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace AdoNetDemo
{
    public class ProductDal
    {
        private const string connectionString = @"server=localhost;user=root;database=etrade;port=3306;password=root";
        private readonly MySqlConnection _connection = new MySqlConnection(connectionString);
        
        public /*DataTable*/ List<Product> GetAll()
        {
            ConnectionControl();
            const string query = "SELECT * FROM etrade.product";
            var command = new MySqlCommand(query, _connection);
            var dataReader = command.ExecuteReader();

            //var dataTable = new DataTable(); // we are gonna return back to List because no one use them anymore
            //dataTable.Load(dataReader);

            var products = new List<Product>();
            while (dataReader.Read())
            {
                // This code did not work IDK why
                /*product = new Product(Convert.ToInt32(dataReader["ID"]), 
                 dataReader["Name"].ToString(), 
                 Convert.ToDecimal(dataReader["UnitPrice"]),
                 Convert.ToInt32(dataReader["StockAmount"]));*/

                var product = new Product
                {
                 Id = Convert.ToInt32(dataReader["ID"]), 
                 Name = dataReader["Name"].ToString(), 
                 UnitPrice = Convert.ToDecimal(dataReader["UnitPrice"]),
                 StockAmount = Convert.ToInt32(dataReader["StockAmount"])
                };
                products.Add(product);
            }

            dataReader.Close();/* after you done close them */
            _connection.Close();

            //return dataTable;
            return products;
        }

        public void Add(Product product)
        {
            ConnectionControl();
            const string query = "INSERT INTO etrade.product (Name, UnitPrice, StockAmount) VALUES(@name, @unitPrice, @stockAmount)";
            var command = new MySqlCommand(query, _connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitPrice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockAmount", product.StockAmount);
            
            command.ExecuteNonQuery();
            
            _connection.Close(); // don't forget to close
        }
        
        private void ConnectionControl()
        {
            // I can use try catch but in course he did not
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        
    }
}