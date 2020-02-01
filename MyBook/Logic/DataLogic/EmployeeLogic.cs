using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    public class EmployeeLogic : BaseLogic, IEmployeeLogic
    {
        public OperationStatus<Pracownik> CreateEmployee(string name, string surname, string email, string password)
        {
            return Repository.Create(new Pracownik()
            { 
                Imie = name,
                Nazwisko = surname,
                Emial = email,
                Haslo = password,
            });
        }

        public OperationStatus<bool> DeleteEmployee(Pracownik employee)
        {
            return Repository.Delete(employee);
        }

        public OperationStatus<List<Pracownik>> GetAllEmployees()
        {
            return Repository.GetMany<Pracownik>();
        }

        public OperationStatus<Pracownik> GetEmployee(int id)
        {
            return Repository.Get<Pracownik>(x => x.Id == id);
        }
    }
}
