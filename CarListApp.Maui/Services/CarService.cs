using CarListApp.Maui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarListApp.Maui.Services;

public class CarService
{
    public List<Car> GetCars()
    {
        return new List<Car>()
        {
            new Car
            {
                Id = 1,
                Make = "Volkswagen",
                Model = "Golf",
                Vin = "123"
            },
            new Car
            {
                Id = 2,
                Make = "Toyota",
                Model = "GR Corolla",
                Vin = "123"
            },
            new Car
            {
                Id = 3,
                Make = "Audi",
                Model = "RS3",
                Vin = "123"
            },
            new Car
            {
                Id = 4,
                Make = "BMW",
                Model = "M140i",
                Vin = "123"
            },
            new Car
            {
                Id = 5,
                Make = "Mercedes",
                Model = "A45",
                Vin = "123"
            },
        };
    }
}
