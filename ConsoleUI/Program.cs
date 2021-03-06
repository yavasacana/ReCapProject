using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new  EfCarDal());

                   
             foreach (var car in carManager.GetAll())
              
                {
                Console.WriteLine(car.Description + " " + car.ModelYear);
                }
            
            Car car1 = new Car
            {
                BrandId = 1,
                ColorId = 1,
                ModelYear = 2020,
                DailyPrice = 0,
                Description = "Alfa Romeo"
            };

            carManager.Add(car1);

            Car car2 = new Car
            {
                BrandId = 1,
                ColorId = 1,
                ModelYear = 2005,
                DailyPrice = 0,
                Description = "a"
            };

            carManager.Add(car2);

        }


    
    }
}
