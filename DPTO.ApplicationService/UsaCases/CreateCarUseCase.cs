using DPTO.ApplicationService.UseCases;
using DPTO.Domain;
using DPTO.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPTO.ApplicationService.UsaCases
{
    public class CreateCarUseCase
    {
        private ICarRepository _repository;

        public CreateCarUseCase(ICarRepository repository)
        {
            _repository = repository;
        }
        public void Handle(CarParams car)
        {
            var newCar = new Car
            {
                Name = car.Name,
                AddedOn = DateTime.Now
            };
            _repository.CreateCar(newCar);
        }
    }
}
