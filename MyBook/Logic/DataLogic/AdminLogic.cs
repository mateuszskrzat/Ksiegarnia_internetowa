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
            return this.Repository.Get<Administrator>(x => x.Id == id);
        }
    }
}
