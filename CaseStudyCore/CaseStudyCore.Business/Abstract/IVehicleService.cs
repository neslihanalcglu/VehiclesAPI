using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Abstract
{
    public interface IVehicleService
    {
        List<Vehicle> GetAllList(Expression<Func<Vehicle, bool>> filter);
        Vehicle Add(Vehicle entity);
        void Delete(int id);
        Vehicle GetById(int id);
        Vehicle Update(Vehicle entity);
    }
}
