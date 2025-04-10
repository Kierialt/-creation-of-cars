namespace Cars;


class Program
{
    static void Main()
    {
        Car car = new Car("Toyota", "Corolla", 2023, 10); // Создаем машину с 10 литрами топлива
        car.DisplayInfo();

        Console.WriteLine("\nЕдем 100 км:");
        car.Drive(100);
        car.DisplayInfo();

        Console.WriteLine("\nПопробуем проехать 500 км (не хватит топлива):");
        car.Drive(500);
        car.DisplayInfo();

        Console.WriteLine("\nЗаправляем 30 литров:");
        car.Refuel();
        car.DisplayInfo();

        Console.WriteLine("\nЗаправляем 20 литров:");
        car.Refuel();
        car.DisplayInfo();

        Console.WriteLine("\nПопробуем проехать 502 км (не хватит топлива):");
        car.Drive(502);
        car.DisplayInfo();
        
        Console.WriteLine("\nЗаправляем 200 литров (превышен бак):");
        car.Refuel();
        car.DisplayInfo();
        
        Console.WriteLine("\nПопробуем проехать 637 км (хватит топлива):");
        car.Drive(637);
        car.DisplayInfo();
        
        
        
        
        
        
        
        ElectricCar electricCar = new ElectricCar("Toyota", "Corolla", 2023, 10); // Создаем машину с 10 литрами топлива
        electricCar.DisplayInfo();

        Console.WriteLine("\nЕдем 100 км:");
        electricCar.Drive(100);
        electricCar.DisplayInfo();

        Console.WriteLine("\nПопробуем проехать 500 км (не хватит топлива):");
        electricCar.Drive(500);
        electricCar.DisplayInfo();

        Console.WriteLine("\nЗаправляем 30 литров:");
        electricCar.Charge();
        electricCar.DisplayInfo();

        Console.WriteLine("\nЗаправляем 20 литров:");
        electricCar.Charge();
        electricCar.DisplayInfo();

        Console.WriteLine("\nПопробуем проехать 502 км (не хватит топлива):");
        electricCar.Drive(502);
        electricCar.DisplayInfo();
        
        Console.WriteLine("\nЗаправляем 200 литров (превышен бак):");
        electricCar.Charge();
        electricCar.DisplayInfo();
        
        Console.WriteLine("\nПопробуем проехать 637 км (хватит топлива):");
        electricCar.Drive(637);
        electricCar.DisplayInfo();
    }
}