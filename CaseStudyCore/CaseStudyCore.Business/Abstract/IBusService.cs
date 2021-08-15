using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.Business.Abstract
{
    public interface IBusService
    {
        List<Bus> GetAllList(Expression<Func<Bus, bool>> filter);
    }
}
