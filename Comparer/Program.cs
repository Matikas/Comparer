using Comparer;

var bmwCars = new List<BmwCar>
{
    new BmwCar(true, "x5", 50),
    new BmwCar(true, "X6", 40),
    new BmwCar(false, "F10", 55),
    new BmwCar(false, "b", 20),
    new BmwCar(false, "a", 20),
};

var bmwComparer = new BmwCarComparer();
var fuelComparer = new BmwFuelComparer();

//bmwCars.Sort(fuelComparer);
var ordereCars = bmwCars.OrderBy(x => x.Fuel);

Console.ReadLine();