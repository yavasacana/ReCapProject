using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()  //ctor.. cnstrtr
        {               //Veritabanı varsaydığım ortamda bulunan veriler
            _cars = new List<Car> {
                new Car{Id=1,BrandId=1,ColorId=1,ModelYear=2000,DailyPrice=100,Description="Temiz"},
                new Car{Id=2,BrandId=1,ColorId=2,ModelYear=2001,DailyPrice=100,Description="Hasarlı"},
                new Car{Id=3,BrandId=2,ColorId=1,ModelYear=2004,DailyPrice=100,Description="temizzz",},
                new Car{Id=4,BrandId=2,ColorId=3,ModelYear=2006,DailyPrice=150,Description="Hasarlı"},
                new Car{Id=5,BrandId=3,ColorId=3,ModelYear=2006,DailyPrice=150,Description="Hasarlı"},
                new Car{Id=6,BrandId=3,ColorId=1,ModelYear=2006,DailyPrice=200,Description="Hasarlı"},
                new Car{Id=7,BrandId=4,ColorId=4,ModelYear=2007,DailyPrice=200,Description="Hasarlı"},


            };
            List<Brand> brands = new List<Brand>
            {
                new Brand{BrandId=1,BrandName="Audi"},
                new Brand{BrandId=2,BrandName="Nissan"},
                new Brand{BrandId=1,BrandName="Lada"},
                new Brand{BrandId=2,BrandName="Skoda"}

            };


        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);        //Linq Language Integrated Query
                                                                                 // c => c.Id sembolizasyonu; Lambda
            _cars.Remove(car);
        }
        public List<Car> GetAll()    //use "return" command for listing!!!
        {
            return _cars;
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
 
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

      
        public List<Car> GetById(int Id)                //get only Id!!!
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

       

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
    }
}
