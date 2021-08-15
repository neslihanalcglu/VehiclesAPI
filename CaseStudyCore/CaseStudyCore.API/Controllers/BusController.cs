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
    public class BusController : ControllerBase
    {
        private IBusService _busService;
        public BusController(IBusService busService)
        {
            _busService = busService;
        }

        /// <summary>
        /// Get All Bus
        /// </summary>
        /// <returns></returns>
        [HttpGet("getall")]
        public List<Bus> GetList(string color)
        {
            var entity = _busService.GetAllList(x=>x.Color.ColorName==color);
            return entity;
        }
    }
}
