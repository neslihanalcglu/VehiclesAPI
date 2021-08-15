using CaseStudyCore.Business.Abstract;
using CaseStudyCore.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseStudyCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private IVehicleService _vehicleService;
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        /// <summary>
        /// Get All Vehicle
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public List<Vehicle> GetList()
        {
            var entity= _vehicleService.GetAllList();
            return entity;
        }

        [HttpGet("{id}")]
        public Vehicle GetById(int id)
        {
            return _vehicleService.GetById(id);
        }
        [HttpPost]
        public Vehicle Post([FromBody] Vehicle vehicle)
        {
            return _vehicleService.Add(vehicle);
        }
        [HttpPut]
        public Vehicle Put([FromBody] Vehicle company)
        {
            return _vehicleService.Update(company);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _vehicleService.Delete(id);
        }
    }
}
