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
    public class VehicleManager : IVehicleService
    {
        private IVehicleDal _vehicleDal;
        public VehicleManager(IVehicleDal vehicleDal)
        {
            _vehicleDal = vehicleDal;
        }

        public Vehicle Add(Vehicle entity)
        {
            return _vehicleDal.Add(entity);
        }

        public void Delete(int id)
        {
            _vehicleDal.Delete(id);
        }
        public List<Vehicle> GetAllList(Expression<Func<Vehicle, bool>> filter)
        {
            return _vehicleDal.GetAll(filter);
        }

        public Vehicle GetById(int id)
        {
            return _vehicleDal.GetById(id);
        }

        public Vehicle Update(Vehicle entity)
        {
            return _vehicleDal.Update(entity);

        }
    }
}
