using AutoriaWinForm.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoriaWinForm.Data
{
    public class SeedDatabase
    {
        private readonly AutoriaContext _context;
        public SeedDatabase() 
        {
            _context = new AutoriaContext();    
        }

        public void SeedCar()
        {
            if(!_context.Cars.Any())
            {
                CarEntity car = new CarEntity
                {
                    Brand = "Audi",
                    FuelType = "Еклектро",
                    Model = "e-tron",
                    EngineCapacity = 0,
                    Odometer = "28 тис. км пробіг",
                    Price = 1522762,
                    DateCreated = DateTime.Now
                };

                _context.Cars.Add(car);
                _context.SaveChanges();


            }
            
        }
    }
}
