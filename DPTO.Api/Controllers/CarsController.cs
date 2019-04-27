using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using DPTO.ApplicationService.UsaCases;
using DPTO.ApplicationService.UseCases;
using DPTO.Domain;
using DPTO.Dto;
using DPTO.Infrastructure;
using DPTO.Infrastructure.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DPTO.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private GetCarsUseCase _getCarsUseCase;
        private CreateCarUseCase _createCarUseCase;

        public CarsController(GetCarsUseCase getCarsUseCase, CreateCarUseCase createCarUseCase)
        {
            _getCarsUseCase = getCarsUseCase;
            _createCarUseCase = createCarUseCase;
        }

        // GET api/values
        [HttpGet]
        public List<CarDto> Get()
        {
            return _getCarsUseCase.Handle();
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] CarParams car)
        {
            _createCarUseCase.Handle(car);
        }
    }
}