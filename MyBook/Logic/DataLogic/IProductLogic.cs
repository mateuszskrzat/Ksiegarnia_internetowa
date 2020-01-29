using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    public interface IProductLogic
    {
        OperationStatus<Produkt> GetProduct(int id);
        OperationStatus<Produkt> CreateProduct(string name, bool available, int count, decimal cost);
        OperationStatus<List<Produkt>> GetAvailableProducts();
    }
}
