namespace Cars;

public class ElectricCar : Car
{
    private int _batteryLevel; // от 0 до 100

    public int BatteryLevel => _batteryLevel;

    public ElectricCar(string brand, string model, int year, int initialCharge)
        : base(brand, model, year)
    {
        _batteryLevel = Math.Min(initialCharge, 100); // максимум 100%
    }

    public void Charge(int percent)
    {
        _batteryLevel = Math.Min(_batteryLevel + percent, 100);
        Console.WriteLine($"{Brand} заряжена до {_batteryLevel}%");
    }

    public override void Drive(int kilometers)
    {
        int neededPercent = kilometers / 10;
        if (neededPercent > _batteryLevel)
        {
            Console.WriteLine($"Недостаточно заряда! Доступно только {_batteryLevel * 10} км.");
            return;
        }

        _batteryLevel -= neededPercent;
        _mileage += kilometers;
        Console.WriteLine($"{Brand} проехала {kilometers} км. Остаток заряда: {_batteryLevel}%");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"{Brand} {Model} (электро, {Year}) — пробег: {_mileage} км, заряд: {_batteryLevel}%");
    }
}