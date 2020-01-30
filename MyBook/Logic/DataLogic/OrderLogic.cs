using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    class OrderLogic : BaseLogic, IOrderLogic
    {
        public OperationStatus<Zamowienie> CreateOrder(string name, string surname, string email, string city, string street, int houseNumber)
        {
            return Repository.Create(new Zamowienie({
                Imie = name,
                Nazwisko = surname,
                Email = email,
                Miasto = city,
                Ulica = street,
                NumerDomu = houseNumber
            }));
        }

        public OperationStatus<bool> Delete(Zamowienie order)
        {
            return Repository.Delete(order);
        }

        public OperationStatus<List<Zamowienie>> GetAllOrders()
        {
            return Repository.GetMany<Zamowienie>(x => x);
        }

        public OperationStatus<Zamowienie> GetOrder(int id)
        {
            return Repository.Get<Zamowienie>(x => x.Id == id);
        }
    }
}
