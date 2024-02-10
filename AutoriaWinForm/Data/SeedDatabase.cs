using Autoria.Helpers;
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
                    EngineCapacity ="0",
                    Odometer = "28 тис. км пробіг",
                    Price = "1522762",
                    DateCreated = DateTime.Now
                };

                _context.Cars.Add(car);
                _context.SaveChanges();

                string[] images = 
                {
                    "https://cdn2.riastatic.com/photosnew/auto/photo/audi_e-tron__534777912hd.webp",
                    "https://cdn2.riastatic.com/photosnew/auto/photo/audi_e-tron__534777907hd.webp",
                    "https://cdn0.riastatic.com/photosnew/auto/photo/audi_e-tron__534777905hd.webp",
                    "https://cdn0.riastatic.com/photosnew/auto/photo/audi_e-tron__534777915hd.webp",
                    "https://cdn2.riastatic.com/photosnew/auto/photo/audi_e-tron__534777917hd.webp",
                    "https://cdn0.riastatic.com/photosnew/auto/photo/audi_e-tron__534777920hd.webp",
                    "https://cdn1.riastatic.com/photosnew/auto/photo/audi_e-tron__534777936hd.webp",
                    "https://cdn2.riastatic.com/photosnew/auto/photo/audi_e-tron__534777927hd.webp",
                    "https://cdn1.riastatic.com/photosnew/auto/photo/audi_e-tron__534777931hd.webp",
                    "https://cdn0.riastatic.com/photosnew/auto/photo/audi_e-tron__534777930hd.webp",
                    "https://cdn2.riastatic.com/photosnew/auto/photo/audi_e-tron__534777932hd.webp",
                    "https://cdn2.riastatic.com/photosnew/auto/photo/audi_e-tron__534777937hd.webp",
                    "https://cdn0.riastatic.com/photosnew/auto/photo/audi_e-tron__534777940hd.webp",
                    "https://cdn2.riastatic.com/photosnew/auto/photo/audi_e-tron__534777957hd.webp",
                };
                short i = 1;
                foreach (string url in images)
                {
                    var fileName = ImageWorker.ImageSave(url, car.Model);
                    CarImageEntity carImage = new CarImageEntity
                    {
                        Name = fileName,
                        Priority = i,
                        CarId = car.Id,
                        DateCreated = DateTime.Now
                    };
                    i++;
                    _context.CarImages.Add(carImage);
                    _context.SaveChanges();
                }

            }
            
        }
    }
}
