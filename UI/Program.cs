using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System.ComponentModel;
using System.Data;

internal class Program
{
    private static void Main(string[] args)
    {
        EfCarDal carManager = new EfCarDal();
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.Description);
        }

    }
}