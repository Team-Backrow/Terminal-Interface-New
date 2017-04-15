using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bangazon_Terminal_App.consoleapp.DAL
{
    class ProductRepository : IProductStorage
    {
        IDbConnection _terminalConnection;

        public ProductRepository()
        {
            _terminalConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        }


        public Products AddProduct(int ProductId, string ProductName)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetProducts()
        {
            _terminalConnection.Open();

            try
            {
                var getProductCommand = _terminalConnection.CreateCommand();
                getProductCommand.CommandText = "SELECT * FROM Product";

                var reader = getProductCommand.ExecuteReader();

                var productList = new List<Products>();
                while (reader.Read())
                {
                    var product = new Products
                    {
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1)
                    };
                    productList.Add(product);
                }
                return productList;
            }
            finally
            {
                _terminalConnection.Close();
            }
        }
    }
}
