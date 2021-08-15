using CaseStudyCore.DataAccess.Abstract;
using CaseStudyCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudyCore.DataAccess.Concrete
{
    public class CarDal : GenericRepository<Car, DatabaseContext>, ICarDal
    {
    }
}
