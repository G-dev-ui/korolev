using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); 
    }
}
// Абстрактный класс для транспортных средств
public abstract class Vehicle
{
    public string Manufacturer { get; set; }
}

// Абстрактный класс для автомобилей
public abstract class Car : Vehicle
{
    public double EngineVolume { get; set; }
    public double MaxPayload { get; set; }
    public string FuelBrand { get; set; }
    public string BodyType { get; set; }
}

// Легковой автомобиль
public class PassengerCar : Car
{
   
}

// Грузовой автомобиль
public class Truck : Car
{

}

// Самолет
public class Airplane : Vehicle
{
    public double MaxAltitude { get; set; }
    public double RunwayLength { get; set; }
}

// Мотоцикл
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }
}

// Катер
public class Boat : Vehicle
{
    public double EngineVolume { get; set; }
    public bool HasCabin { get; set; }
}
