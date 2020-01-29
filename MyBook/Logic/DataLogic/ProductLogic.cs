using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    public class ProductLogic : BaseLogic, IProductLogic
    {
        public OperationStatus<Produkt> GetProduct(int id)
        {
            return Repository.Get<Produkt>(x => x.Id == id);
        }

        public OperationStatus<Produkt> CreateProduct(string name, bool available, int count, decimal cost)
        {
            return Repository.Create<Produkt>(new Produkt()
            {
                Nazwa = name,
                Cena = cost,
                DataDodania = DateTime.Now,
                Dostepny = available,
                Ilosc = count
            });
        }

        public OperationStatus<List<Produkt>> GetAvailableProducts()
        {
            return Repository.GetMany<Produkt>(x => x.Dostepny);
        }
    }
}
