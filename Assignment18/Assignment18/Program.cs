using System;

// Interface 1
interface IConnectable
{
    bool Connect();
}

// Interface 2
interface IRechargeable
{
    void Charge(int minutes);
}

// Interface 3
interface IDisplayable
{
    string Display();
}

// Smartphone class implementing multiple interfaces
class Smartphone : IConnectable, IRechargeable, IDisplayable
{
    public string Model { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryLevel { get; private set; }

    public Smartphone(string model)
    {
        Model = model;
        IsConnected = false;
        BatteryLevel = 0;
    }

    public bool Connect()
    {
        Console.WriteLine($"{Model} is connecting...");
        // Perform connection logic, for simplicity, always return true
        IsConnected = true;
        return true;
    }

    public void Charge(int minutes)
    {
        Console.WriteLine($"{Model} is charging for {minutes} minutes.");
        // Perform charging logic, for simplicity, just increment the battery level
        BatteryLevel += minutes;
    }

    public string Display()
    {
        return $"{Model} - Battery Level: {BatteryLevel}%";
    }
}

// Laptop class implementing multiple interfaces
class Laptop : IConnectable, IRechargeable, IDisplayable
{
    public string Brand { get; set; }
    public bool IsConnected { get; private set; }
    public int BatteryLevel { get; private set; }

    public Laptop(string brand)
    {
        Brand = brand;
        IsConnected = false;
        BatteryLevel = 0;
    }

    public bool Connect()
    {
        Console.WriteLine($"{Brand} Laptop is connecting...");
        // Perform connection logic
        IsConnected = true;
        return true;
    }

    public void Charge(int minutes)
    {
        Console.WriteLine($"{Brand} Laptop is charging for {minutes} minutes.");
        // Perform charging logic, for simplicity, just increment the battery level
        BatteryLevel += minutes;
    }

    public string Display()
    {
        return $"{Brand} Laptop - Battery Level: {BatteryLevel}%";
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Smartphone and Laptop
        Smartphone smartphone = new Smartphone("iPhone 12");
        Laptop laptop = new Laptop("Dell XPS");

        // Connect and display information for Smartphone
        smartphone.Connect();
        smartphone.Charge(60);
        Console.WriteLine(smartphone.Display());

        Console.WriteLine();

        // Connect and display information for Laptop
        laptop.Connect();
        laptop.Charge(120);
        Console.WriteLine(laptop.Display());
    }
}
