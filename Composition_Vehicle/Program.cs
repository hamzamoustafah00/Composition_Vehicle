using System;

// Engine class
class Engine
{
    public void Start()
    {
        Console.WriteLine("Engine started.");
    }

    public void Stop()
    {
        Console.WriteLine("Engine stopped.");
    }
}

// Wheel class
class Wheel
{
    public void Rotate()
    {
        Console.WriteLine("Wheel rotating.");
    }
}

// Vehicle class composed of Engine and Wheels
class Vehicle
{
    private Engine vehicleEngine;
    private Wheel[] vehicleWheels;

    public Vehicle()
    {
        vehicleEngine = new Engine();
        vehicleWheels = new Wheel[4];
        for (int i = 0; i < 4; i++)
        {
            vehicleWheels[i] = new Wheel();
        }
    }

    public void Start()
    {
        vehicleEngine.Start();
    }

    public void Stop()
    {
        vehicleEngine.Stop();
    }

    public void Drive()
    {
        foreach (var wheel in vehicleWheels)
        {
            wheel.Rotate();
        }
        Console.WriteLine("Vehicle is in motion.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating a vehicle and performing actions using composition
        Vehicle myVehicle = new Vehicle();

        myVehicle.Start(); // Start the vehicle's engine
        myVehicle.Drive(); // Drive the vehicle
        myVehicle.Stop(); // Stop the vehicle's engine
    }
}
