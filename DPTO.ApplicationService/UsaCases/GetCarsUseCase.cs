using DPTO.ApplicationService.UseCases;
using DPTO.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPTO.ApplicationService.UsaCases
{
    public class GetCarsUseCase
    {
        private ICarRepository _repository;

        public GetCarsUseCase(ICarRepository repository)
        {
            _repository = repository;
        }

        public List<CarDto> Handle()
        {
            return _repository.GetCars()
                .Select(car => new CarDto
                {
                    Name = car.Name,
                    AddedOn = car.AddedOn
                })
                .ToList();
        }
    }
}
