using static CarFacttory.FactoryClass;

class Program
{
    static void Main(string[] args)
    {
        ICarFactory sedanFactory = new SedanFactory();
        ICarFactory suvFactory = new SUVFactory();

        List<Car> cars = new List<Car>();
        cars.Add(sedanFactory.CreateCar("Sedan 1", 150, 1000));
        cars.Add(sedanFactory.CreateCar("Sedan 2", 160, 1000));
        cars.Add(suvFactory.CreateCar("SUV 1", 180, 1000));
        cars.Add(suvFactory.CreateCar("SUV 2", 190, 1000));

        Race race = new Race(cars, 1000);
        race.Start();
    }
}