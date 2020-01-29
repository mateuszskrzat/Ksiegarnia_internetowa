using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DAL
{
    public class RepositoryBase : DbContext
    {
        public RepositoryBase() : base()
        {
            this.Connect();
            Database.Initialize(false);
        }

        private void Connect() // provide db connection
        {

        }

        public void Get<T>(Expression<Func<T, bool>> expression)
        {
            
        }
    }
}
