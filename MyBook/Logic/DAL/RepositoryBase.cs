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
                    result.Data = context.Set<T>().FirstOrDefault(expression);
                    result.Status = result.Data != null;
                }
            }
            catch (Exception e)
            {
                result.Error = e;
            }
            return result;
        }

        public OperationStatus<List<T>> GetMany<T>() where T : class
        {
            var result = new OperationStatus<List<T>>();
            try
            {
                using (var context = new KsiegarniaEntities())
                {
                    result.Data = context.Set<T>().ToList();
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
                    result.Data = context.Set<T>().Where(expression).ToList();
                    result.Status = result.Data != null;
                }
            }
            catch (Exception e)
            {
                result.Error = e;
            }
            return result;
        }

        public OperationStatus<List<TSource>> GetMany<TSource, Tresult>(Expression<Func<TSource, bool>> expression, Expression<Func<TSource, Tresult>> orderBy = null, bool descending = true, int? take = null) where TSource : class
        {
            var result = new OperationStatus<List<TSource>>();
            try
            {
                using (var context = new KsiegarniaEntities())
                {
                    if (take != null && take > 0)
                    {
                        if (orderBy != null)
                        {
                            if (descending)
                            {
                                result.Data = context.Set<TSource>().Where(expression).OrderByDescending(orderBy).Take(take.Value).ToList();
                            }
                            else
                            {
                                result.Data = context.Set<TSource>().Where(expression).OrderBy(orderBy).Take(take.Value).ToList();
                            }
                        }
                        else
                        {
                            result.Data = context.Set<TSource>().Where(expression).Take(take.Value).ToList();
                        }
                    }
                    else
                    {
                        if (orderBy != null)
                        {
                            if (descending)
                            {
                                result.Data = context.Set<TSource>().Where(expression).OrderByDescending(orderBy).ToList();
                            }
                            else
                            {
                                result.Data = context.Set<TSource>().Where(expression).OrderBy(orderBy).ToList();
                            }
                        }
                        else
                        {
                            result.Data = context.Set<TSource>().Where(expression).ToList();
                        }
                    }

                    
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
