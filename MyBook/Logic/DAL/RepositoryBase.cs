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
            Database.Initialize(false);
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

        public OperationStatus<List<T>> GetMany<T>(Expression<Func<T, bool>> expression) where T : class
        {
            var result = new OperationStatus<List<T>>();
            try
            {
                using (var context = new KsiegarniaEntities())
                {
                    result.Data = context.Set<T>().Where(expression.Compile()).ToList();
                    result.Status = result.Data != null;
                }
            }
            catch (Exception e)
            {
                result.Error = e;
            }
            return result;
        }

        public OperationStatus<T> Create<T>(T entity) where T : class
        {
            var result = new OperationStatus<T>();
            try
            {
                using (var context = new KsiegarniaEntities())
                {
                    result.Data = context.Set<T>().Add(entity);
                    context.SaveChanges();
                    result.Status = result.Data != null;
                }
            }
            catch (Exception e)
            {
                result.Error = e;
            }
            return result;
        }

        public OperationStatus<bool> Delete<T>(T entity) where T : class
        {
            var result = new OperationStatus<bool>();
            try
            {
                using (var context = new KsiegarniaEntities())
                {
                    context.Set<T>().Remove(entity);
                    context.SaveChanges();
                    result.Status = true;
                }
            }
            catch (Exception e)
            {
                result.Error = e;
                result.Status = false;
            }
            return result;
        }

        public OperationStatus<bool> DeleteMany<T>(List<T> entities) where T : class
        {
            var result = new OperationStatus<bool>();
            try
            {
                using (var context = new KsiegarniaEntities())
                {
                    context.Set<T>().RemoveRange(entities);
                    context.SaveChanges();
                    result.Status = true;
                }
            }
            catch (Exception e)
            {
                result.Error = e;
                result.Status = false;
            }
            return result;
        }
    }
}
