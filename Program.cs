namespace Cars.Clsses;


class Program
{
    static void Main()
    {
        Car myCar = new Car("Toyota", "Corolla", 2023, 10); // Создаем машину с 10 литрами топлива
        myCar.DisplayInfo();

        Console.WriteLine("\nЕдем 100 км:");
        myCar.Drive(100);
        myCar.DisplayInfo();

        Console.WriteLine("\nПопробуем проехать 500 км (не хватит топлива):");
        myCar.Drive(500);
        myCar.DisplayInfo();

        Console.WriteLine("\nЗаправляем 30 литров:");
        myCar.Refuel(30);
        myCar.DisplayInfo();

        Console.WriteLine("\nЗаправляем 20 литров:");
        myCar.Refuel(20);
        myCar.DisplayInfo();

        Console.WriteLine("\nПопробуем проехать 502 км (не хватит топлива):");
        myCar.Drive(502);
        myCar.DisplayInfo();
        
        Console.WriteLine("\nЗаправляем 200 литров (превышен бак):");
        myCar.Refuel(200);
        myCar.DisplayInfo();
        
        Console.WriteLine("\nПопробуем проехать 637 км (хватит топлива):");
        myCar.Drive(637);
        myCar.DisplayInfo();
    }
}