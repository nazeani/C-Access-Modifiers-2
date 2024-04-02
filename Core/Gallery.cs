using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Core
{
    public class Gallery
    {
        Car[] cars = { };
        public Gallery() 
        {
            cars = new Car[0];
        }
        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length+1);
            cars[cars.Length-1]=car;
        }
        public Car[] GetAllCars()
        {
            return cars;
        }
        public void ShowAllCars()
        {
            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.Id},{car.Name}");
            }
        }
        public void FindCarById(int id)
        {
            foreach (Car car in cars)
            {
                if (car.Id == id)
                {
                    Console.WriteLine($"{car.Id},{car.Name}");


                }
            }
        }
        public void FindCarByCarCode(string carcode) 
        {
            foreach (Car car in cars) 
            {
                if(car.CarcCode == carcode) 
                {

                    Console.WriteLine($"{car.Id},{car.Name}");
                }
            }
        }
        public void FindCarsBySpeedInterval(int minSalary,int maxSalary) 
        {
            foreach(Car car in cars)
            {
                if(car.Speed>=minSalary &&  car.Speed<=maxSalary)
                {

                    Console.WriteLine($"{car.Id},{car.Name}");
                }   
            }
        }
    }
}
