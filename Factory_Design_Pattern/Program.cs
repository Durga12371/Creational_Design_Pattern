using System;

// Product interface
//This is an interface for creating the objects.
public interface ITransport
{
    void Deliver();
}

// Concrete product classes
//This is a class which implements the Product interface
public class Truck : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by truck");
    }
}

public class Ship : ITransport
{
    public void Deliver()
    {
        Console.WriteLine("Delivering by ship");
    }
}

// Factory interface or Creator
//This is an abstract class and declares the factory method,
//which returns an object of type Product.
public interface ITransportFactory
{
    ITransport CreateTransport();
}

// Concrete factory classes Or Concrete Creator
//This is a class which implements the Creator class and overrides
//the factory method to return an instance of a ConcreteProduct.
public class TruckFactory : ITransportFactory
{
    public ITransport CreateTransport()
    {
        return new Truck();
    }
}

public class ShipFactory : ITransportFactory
{
    public ITransport CreateTransport()
    {
        return new Ship();
    }
}

// Client code
public class Program
{
    public static void Main(string[] args)
    {
        ITransportFactory truckFactory = new TruckFactory();
        ITransport truck = truckFactory.CreateTransport();
        truck.Deliver(); // Output: Delivering by truck

        ITransportFactory shipFactory = new ShipFactory();
        ITransport ship = shipFactory.CreateTransport();
        ship.Deliver(); // Output: Delivering by ship
    }
}
