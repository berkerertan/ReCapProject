using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryDal() 
        {
            _cars = new List<Car>()
            {
                new Car {Id=1,BrandId=1, ColorId=1,DailyPrice=2000, Description="Renault Clio",ModelYear=2015},
                new Car {Id=2,BrandId=1, ColorId=2,DailyPrice=1500, Description="Renault Fluence",ModelYear=2012},
                new Car {Id=3,BrandId=2, ColorId=3,DailyPrice=2500, Description="BMW 320",ModelYear=2008},
                new Car {Id=4,BrandId=3, ColorId=1,DailyPrice=3500, Description="Mercedes Vito",ModelYear=2021},
                new Car {Id=5,BrandId=3, ColorId=2,DailyPrice=4000, Description="Mercedes E200",ModelYear=2018}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }
        public void Delete(Car car)
        {
            Car carToDelete=_cars.SingleOrDefault(c=>c.Id==car.Id); 
            _cars.Remove(carToDelete);
        }
        public List<Car> GetAll()
        {
            return _cars;
        }
        public Car GetById(int Id)
        {
            return _cars.SingleOrDefault(c => c.Id == Id);
        }
        public void Update(Car car)
        {
            Car carToUpdate=_cars.SingleOrDefault(c=>c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }


    }
}
