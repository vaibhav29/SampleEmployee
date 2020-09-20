using Microsoft.EntityFrameworkCore;
using SampleEmployee.Data;
using SampleEmployee.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SampleEmployee.Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        protected SampleEmployeeContext DbContext { get; set; }
        public Repository(SampleEmployeeContext repositoryContext)
        {
            this.DbContext = repositoryContext;
        }
        public IQueryable<T> FindAll()
        {
            return this.DbContext.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.DbContext.Set<T>().Where(expression).AsNoTracking();
        }
        public void Create(T entity)
        {
            this.DbContext.Set<T>().Add(entity);
        }
        public void Update(T entity)
        {
            this.DbContext.Set<T>().Update(entity);
        }
        public void Delete(T entity)
        {
            this.DbContext.Set<T>().Remove(entity);
        }

        
    }
}
