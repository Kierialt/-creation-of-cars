namespace Cars;

public class Car
{
    public static int TotalCars;
    
    private int _year;
    private int _mileage;     
    private double _fuelLevel;
    
    private const double FuelCapacity = 100;
    private const double FuelConsumption = 1;

    
    public string Brand { get; }
    public string Model { get; }

    public int Year
    {
        get { return _year; }
        set
        {
            if (value < 1886)
            {
                Console.WriteLine("Error: Year of manufacture can't be less than 1886");
            }
            else
            {
                _year = value;
            }
        }
    }
    public int Mileage => _mileage;
    public double FuelLevel => _fuelLevel;
    public Car(string brand, string model, int year,double initialFuel)
    {
        Model= model;
        Year = year;
        Brand = brand;
        _mileage = 0;
        _fuelLevel = Math.Min(initialFuel, FuelCapacity);
        TotalCars++;
    }
    public void DisplayInfo()
    {
        Console.WriteLine($"Brand: {Brand}, Model: {Model}, Year: {_year}, Mileage: {Mileage} km, Fuel Level: {FuelLevel}");
    }
    
    
    public void Drive(int kilometers)
    {
        if (kilometers < 0)
        {
            Console.WriteLine("Error: kilometers cannot be negative!");
            return;
        }

        double neededFuel = (kilometers / 10.0 * FuelConsumption); // сколько топлива нужно на проездку км
        if (neededFuel > _fuelLevel)
        {
            int newkm;
            Console.WriteLine($"You want to drive {kilometers} km.");
            newkm = (int)(FuelLevel * 10 / FuelConsumption);
            Console.WriteLine($"Not enough fuel,You can drive only {newkm} km.");
            neededFuel = _fuelLevel;
            _mileage += newkm;
            _fuelLevel -= neededFuel;
            Console.WriteLine($"{Brand} {Model} rives {newkm} km. New mileage: {Mileage} km.");
        }
        else
        {
            _mileage += kilometers;
            _fuelLevel -= neededFuel;
            Console.WriteLine($"Drived {kilometers} km. Fuel remaining: {FuelLevel:F1} liters.");
        }
    }

    public void Refuel()
    {
        Console.Write("How much would you like to refuel? ");
        double liters = Convert.ToDouble(Console.ReadLine());
        if (liters <= 0)
        {
            Console.WriteLine("Error: liters cannot be negative!");
            return;
        }
        if (liters + FuelLevel > FuelCapacity)
        {
            Console.WriteLine($"Error: more than 100 liters cannot be filled. You can fill only {FuelCapacity - FuelLevel:f1} liters!");
            _fuelLevel = FuelCapacity;
        }
        else
        {
            _fuelLevel += liters;
            Console.WriteLine($"The {liters:f1} fuel were filled. Now {FuelLevel:f1} liters in back");  
        }
    }

    public static void ShowTotalCars()
    {
        Console.WriteLine($"{TotalCars} cars were created yet");
    }
}