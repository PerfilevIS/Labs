using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFacttory
{
    internal class FactoryClass
  
    {
        public interface ICarFactory
        {
            Car CreateCar(string name, int maxSpeed, int distance);
        }

        public class SedanFactory : ICarFactory
        {
            public Car CreateCar(string name, int maxSpeed, int distance)
            {
                return new Sedan(name, maxSpeed, distance);
            }
        }

        public class SUVFactory : ICarFactory
        {
            public Car CreateCar(string name, int maxSpeed, int distance)
            {
                return new SUV(name, maxSpeed, distance);
            }
        }

        public abstract class Car
        {
            public string Name { get; set; }
            public int MaxSpeed { get; set; }
            public int Distance { get; set; }
            public int CurrentSpeed { get; set; }
            public int CurrentDistance { get; set; }

            public Car(string name, int maxSpeed, int distance)
            {
                Name = name;
                MaxSpeed = maxSpeed;
                Distance = distance;
                CurrentSpeed = 0;
                CurrentDistance = 0;
            }

            public virtual void Move()
            {
                if (CurrentSpeed < MaxSpeed)
                {
                    CurrentSpeed++;
                }
                else
                {
                    CurrentSpeed--;
                }
                CurrentDistance += CurrentSpeed;
            }

            public bool IsFinished()
            {
                return CurrentDistance >= Distance;
            }
        }

        public class Sedan : Car
        {
            public Sedan(string name, int maxSpeed, int distance) : base(name, maxSpeed, distance)
            {
            }
        }

        public class SUV : Car
        {
            public SUV(string name, int maxSpeed, int distance) : base(name, maxSpeed, distance)
            {
            }
        }

        public class Race
        {
            public List<Car> Cars { get; set; }
            public int Distance { get; set; }

            public Race(List<Car> cars, int distance)
            {
                Cars = cars;
                Distance = distance;
            }

            public void Start()
            {
                while (!AllFinished())
                {
                    foreach (Car car in Cars)
                    {
                        car.Move();
                        Console.WriteLine($"{car.Name}: {car.CurrentSpeed} km/h, {car.CurrentDistance} km");
                    }
                }
                PrintResults();
            }

            private bool AllFinished()
            {
                foreach (Car car in Cars)
                {
                    if (!car.IsFinished())
                    {
                        return false;
                    }
                }
                return true;
            }

            private void PrintResults()
            {
                Cars.Sort((x, y) => y.CurrentDistance.CompareTo(x.CurrentDistance));
                for (int i = 0; i < Cars.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {Cars[i].Name}");
                }
            }
        }

    }
}
