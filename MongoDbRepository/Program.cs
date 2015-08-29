using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MongoDbRepository
{
    class Program
    {
        static void Main(string[]args)
        {
            var car = new Car() {
                Manufacturer = "Mercedes-Benz",
                Model = "New A Class",
                Colour = "Gray"
            };

            var carRepository = new MongoDbRepository<Car>();
                                   
            Console.WriteLine("Inserting car");
            var insertResult = carRepository.Insert(car);
            
            Console.WriteLine("Updating car");
            car.Colour = "Blue";
            var updateResult = carRepository.Update(car);

            Console.WriteLine("Search cars");
            var searchResult = carRepository.SearchFor(c => c.Colour == "Blue");

            Console.WriteLine("Get all cars");
            var getAllResult = carRepository.GetAll();

            Console.WriteLine("Getting car by id");
            var getByIdResult = carRepository.GetById(car.Id);

            Console.WriteLine("Deleting car");
            var deleteResult = carRepository.Delete(car);
            
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
