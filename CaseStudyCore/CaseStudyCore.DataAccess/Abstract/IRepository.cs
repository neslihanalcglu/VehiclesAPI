using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.DataAccess.Abstract
{
    public interface IRepository<T> where T : class, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter);
        T Add(T entity);
        void Delete(int id);
        T GetById(int id);
        T Update(T entity);
    }
}
