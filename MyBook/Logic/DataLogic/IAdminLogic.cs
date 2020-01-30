using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataLogic
{
    public interface IAdminLogic
    {
        OperationStatus<Administrator> GetAdmin(int id);
        OperationStatus<Administrator> GetAllAdmins();
        OperationStatus<Administrator> CreateAdmin(string name, string surname, string email, string password);
        OperationStatus<bool> DeleteAdmin(Administrator admin);
    }
}
