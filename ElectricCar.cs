namespace Cars;

public class ElectricCar : Car, IVehicle
{
    private double _batteryLevel; // от 0 до 100
    private double _mileageForElectricCars;
    
    private const int ChargeCapacity = 100;
    private const int ChargeConsumption = 1; 
    public double BatteryLevel => _batteryLevel;
    public double MileageForElectricCars => _mileageForElectricCars;
    

    public ElectricCar(string brand, string model, int year, int initialCharge)
        : base(brand, model, year, 0)
    {
        _batteryLevel = Math.Min(initialCharge, ChargeCapacity); // максимум 100%
    }

    public new void StartEngine()
    {
        Console.WriteLine($"{Brand} electric motor is on.");
    }

    public new void StopEngine()
    {
        Console.WriteLine($"{Brand} electric motor is off.");
    }
    public new void DisplayInfo()
    {
        Console.WriteLine($"{Brand} {Model} (electro {Year}) - mileage: {MileageForElectricCars} km, Battery Level: {BatteryLevel}%");
    }

    public new void Drive(int kilometers)
    {
        if (kilometers <= 0)
        {
            Console.WriteLine("You cannot drive negative or zero kilometers!");
            return;
        }

        double neededPercent = (kilometers / 10.0 * ChargeConsumption);

        if (neededPercent > _batteryLevel)
        {
            Console.WriteLine($"You want to drive {kilometers} km.");
            int maxKm = (int)(_batteryLevel * 10) / ChargeConsumption;

            Console.WriteLine($"Not enough battery. You can drive only {maxKm} km.");
            neededPercent = _batteryLevel;
            _mileageForElectricCars += maxKm;
            _batteryLevel -= neededPercent;

            Console.WriteLine($"{Brand} {Model} drove {maxKm} km. New mileage: {MileageForElectricCars:f1} km.");
        }
        else
        {
            _mileageForElectricCars += kilometers;
            _batteryLevel -= neededPercent;

            Console.WriteLine($"{Brand} {Model} drove {kilometers} km. Battery remaining: {BatteryLevel:f1}%.");
        }
    }

    public void Charge()
    {
        Console.Write("What percentage do you want to charge your electric car? ");
        int percent = Convert.ToInt32(Console.ReadLine());
        if (percent <= 0)
        {
            Console.WriteLine("Error: percent cannot be negative!");
        }
        if (percent + _batteryLevel > ChargeCapacity)
        {
            Console.WriteLine($"Error: more than 100 percent cannot be charged. You can charge only {ChargeCapacity - BatteryLevel} percent!");
            _batteryLevel = ChargeCapacity;
        }
        else
        {
            _batteryLevel += percent;
            Console.WriteLine($"The {percent} of battery were charge. Now your electric car has {BatteryLevel} percent");  
        }
    }
}