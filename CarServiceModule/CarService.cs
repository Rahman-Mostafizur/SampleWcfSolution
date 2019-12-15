using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CarServiceModule
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarService" in both code and config file together.
    public class CarService : ICarService
    {
        private readonly CarContext db = new CarContext();


        public Car DeleteCar(Car car)
        {
            db.Cars.Remove(car);
            db.SaveChanges();
            return car;
        }

        public Car GetCar(int id)
        {
            return db.Cars.Find(id);
        }

        public List<Car> GetCars()
        {
            return db.Cars.ToList();
        }

        public Car SaveCar(Car car)
        {
            db.Cars.Add(car);
            db.SaveChanges();
            return car;
        }

        public Car UpdateCar(Car car)
        {
            db.Entry(car).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return car;
        }
    }
}
