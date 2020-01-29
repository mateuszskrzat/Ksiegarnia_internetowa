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

        public OperationStatus<T> Get<T>(Expression<Func<T, bool>> expression) where T : class
        {
            var result = new OperationStatus<T>();
            try
            {
                using (var context = new KsiegarniaEntities())
                {
                    result.Data = context.Set<T>().FirstOrDefault(expression.Compile());
                    result.Status = result.Data != null;
                }
            }
            catch (Exception e)
            {
                result.Error = e;
            }
            return result;
        }
    }
}
