using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Abstract
{
    public interface IBoatService
    {
        Boat Add(Boat entity);
        void Delete(int id);
        Boat GetById(int id);
        List<Boat> GetAllList(Expression<Func<Boat, bool>> filter);
        Boat Update(Boat entity);
    }
}
