using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.ComponentModel;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryDal());
        foreach (var car in carManager.GetDailyPrice(50, 100))
        {
            Console.WriteLine(car.BrandId);
        }

    }
}