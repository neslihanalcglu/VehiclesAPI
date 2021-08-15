
using CaseStudyCore.Business.Abstract;
using CaseStudyCore.DataAccess.Abstract;
using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Concrete
{
    public class BusManager : IBusService
    {
        private IBusDal _busDal;
        public BusManager(IBusDal busDal)
        {
            _busDal = busDal;
        }
        public List<Bus> GetAllList(Expression<Func<Bus, bool>> filter)
        {
            return _busDal.GetAll(filter);
        }
    }
}
