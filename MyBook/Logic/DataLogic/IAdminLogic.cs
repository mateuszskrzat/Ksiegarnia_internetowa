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
    }
}
