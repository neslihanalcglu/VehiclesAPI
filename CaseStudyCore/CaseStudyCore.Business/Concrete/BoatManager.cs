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
    public class BoatManager:IBoatService
    {
        private IBoatDal _boatDal;
        public BoatManager(IBoatDal boatDal)
        {
            _boatDal = boatDal;
        }
        public Boat Add(Boat entity)
        {
            return _boatDal.Add(entity);
        }

        public void Delete(int id)
        {
            _boatDal.Delete(id);
        }

        public List<Boat> GetAllList(Expression<Func<Boat, bool>> filter)
        {
            return _boatDal.GetAll(filter);
        }

        public Boat GetById(int id)
        {
            return _boatDal.GetById(id);
        }


        public Boat Update(Boat entity)
        {
            return _boatDal.Update(entity);
        }

    }
}
