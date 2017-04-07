using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bangazon_Terminal_App.consoleapp.DAL
{
    public interface IRepository
    {
        void AddCustomer(int CustomerID);
        void GetCustomer(int CustomerID);
        void AddProduct(int ProductID);
        void GetProduct(int ProductID);
        void GetOrder(int OrderID);
        void RemoveProduct(int ProductID, int OrderID);
        void AddPayment(int PaymentTypeID);
        void GetPayment(int PaymentTypeID);
    }
}
