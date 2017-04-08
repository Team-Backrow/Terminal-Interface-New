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

        public void AddProduct(int ProductID)
        {
            throw new NotImplementedException();
        }

        public void GetProduct(int ProductID)
        {
            throw new NotImplementedException();
        }
    }
}
