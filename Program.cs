namespace Cars;


class Program
{
    static void Main()
    {
        IVehicle vehicle = null;
        bool running = true;

        while (running)
        {
            Console.WriteLine("\n---MENU---");
            Console.WriteLine("1. Create Car");
            Console.WriteLine("2. Create Electric Car");
            Console.WriteLine("3. Start engine");
            Console.WriteLine("4. Drive");
            Console.WriteLine("5. Stop engine");
            Console.WriteLine("6. Refuel / Recharge");
            Console.WriteLine("7. Show Total cars");
            Console.WriteLine("0. Exit");

            Console.Write("\nEnter your choice: ");
            string choice = Console.ReadLine();


            switch (choice)
            {
                case "1": Console.WriteLine("Brand?"); break;
                
            }
        }
    }
}