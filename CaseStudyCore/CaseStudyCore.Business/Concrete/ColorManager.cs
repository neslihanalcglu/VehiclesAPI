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
    public class ColorManager : IColorService
    {
        private IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
        public List<Color> GetAllList(Expression<Func<Color, bool>> filter)
        {
            return _colorDal.GetAll(filter);
        }
    }
}
