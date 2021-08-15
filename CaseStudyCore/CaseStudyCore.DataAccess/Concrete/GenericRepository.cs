using CaseStudyCore.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.DataAccess.Concrete
{
    public class GenericRepository<T, TContext> : IRepository<T>
        where T : class, new()
        where TContext : DatabaseContext, new()
    {
        public T Add(T entity)
        {
            using (var context = new TContext()) //unit of work ü implemente eder
            {
                context.Set<T>().Add(entity);
                context.SaveChanges();
                return entity;
            }
        }

        public void Delete(int id)
        {
            using (var context = new TContext()) //unit of work ü implemente eder
            {
                var deletedEntity = GetById(id);
                context.Set<T>().Remove(deletedEntity);
                context.SaveChanges();
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            using(var context=new TContext())
            {
                return context.Set<T>().ToList();
            }
        }

        public T GetById(int id)
        {
            using (var context = new TContext())
            {
                return context.Set<T>().Find(id);
            }
        }

        
        public T Update(T entity)
        {
            using (var context = new TContext()) //unit of work ü implemente eder
            {
                context.Set<T>().Update(entity);
                context.SaveChanges();
                return entity;
            }
        }
    }
}
