using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    interface IOrderLogic
    {
        OperationStatus<Zamowienie> CreateOrder(string name, string surname, string email, string city, string street, int houseNumber);
        OperationStatus<Zamowienie> GetOrder(int id);
        OperationStatus<Zamowienie> GetAllOrders();
        OperationStatus<bool> Delete(Zamowienie order);
    }
}
