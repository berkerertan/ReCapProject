using Business.Abstract;
using Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarService _carService;
        public CarManager(ICarService carService)
        {
            _carService = carService;
        }
        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }

        public List<Car> GetBrandId(int id)
        {
            return _carService.GetBrandId(id);
        }

        public List<Car> GetDailyPrice(decimal min, decimal max)
        {
            return _carService.GetDailyPrice(min, max);
        }
    }
}
