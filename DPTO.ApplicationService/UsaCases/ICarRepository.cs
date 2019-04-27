using DPTO.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace DPTO.ApplicationService.UseCases
{
    public interface ICarRepository
    {
        List<Car> GetCars();

        Car GetCarById(int id);

        void CreateCar(Car car);
    }
}
