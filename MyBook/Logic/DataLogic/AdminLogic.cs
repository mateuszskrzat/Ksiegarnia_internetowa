using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    public class AdminLogic : BaseLogic, IAdminLogic
    {
        public OperationStatus<Administrator> GetAdmin(int id)
        {
            return Repository.Get<Administrator>(x => x.Id == id);
        }

        public OperationStatus<List<Administrator>> GetAllAdmins()
        {
            return Repository.GetMany<Administrator>(x => x);
        }

        public OperationStatus<Administrator> CreateAdmin(string name, string surname, string email, string password)
        {
            return Repository.Create(new Administrator()
            {
                Imie = name,
                Nazwisko = surname,
                Emial = email,
                Haslo = password
            }
            );
        }

        public OperationStatus<bool> DeleteAdmin(Administrator admin)
        {
            return Repository.Delete(admin);
        }
    }
}
