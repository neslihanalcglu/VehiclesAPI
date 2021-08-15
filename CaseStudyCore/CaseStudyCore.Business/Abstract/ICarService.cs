using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAllList(Expression<Func<Car, bool>> filter);
    }
}
