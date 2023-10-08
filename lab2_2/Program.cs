using System;

class Vehicle
{
    private double x;
    private double y;
    private int price;
    private int speed;
    private int year;

    public Vehicle(double x, double y, int price, int speed, int year)
    {
        this.x = x;
        this.y = y;
        this.price = price;
        this.speed = speed;
        this.year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Coordinates: ({0}, {1});\nPrice: {2};\nSpeed: {3};\nYear: {4}", x, y, price, speed, year);
    }
}

class Plane : Vehicle
{
    private int altitude;
    private int passengers;

    public Plane(double x, double y, int price, int speed, int year, int altitude, int passengers)
        : base(x, y, price, speed, year)
    {
        this.altitude = altitude;
        this.passengers = passengers;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Altitude: {0};\nPassengers: {1}", altitude, passengers);
    }
}

class Car : Vehicle
{
    public Car(double x, double y, int price, int speed, int year)
        : base(x, y, price, speed, year)
    {
    }
}

class Ship : Vehicle
{
    private int passengers;
    private string port;

    public Ship(double x, double y, int price, int speed, int year, int passengers, string port)
        : base(x, y, price, speed, year)
    {
        this.passengers = passengers;
        this.port = port;
    }

    public void ShowInfo()
    {
        base.ShowInfo();
        Console.WriteLine("Passengers: {0};\nPort: {1}", passengers, port);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle(53.551813, 8.486644, 10000, 100, 2010);
        vehicle1.ShowInfo();

        Console.WriteLine();

        Vehicle car1 = new Car(38.015491, 23.719140, 200000, 100, 2011);
        vehicle1.ShowInfo();

        Console.WriteLine();

        Plane plane1 = new Plane(53.955757, 7.646183, 1000000, 500, 2020, 10000, 200);
        plane1.ShowInfo();

        Console.WriteLine();

        Ship ship1 = new Ship(40.103285, 18.870132, 500000, 50, 2015, 500, "Brindisi");
        ship1.ShowInfo();

        // Console.ReadLine();
    }
}