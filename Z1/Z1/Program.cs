using System;

// Абстрактный класс для транспортных средств
public abstract class Vehicle
{
    public string Manufacturer { get; set; }

    public Vehicle(string manufacturer)
    {
        Manufacturer = manufacturer;
    }
}

// Интерфейс для сухопутной техники
public interface ILandVehicle
{
    double EngineVolume { get; set; }
    double MaxPayload { get; set; }
    string FuelBrand { get; set; }
}

// Легковой автомобиль
public class PassengerCar : Vehicle, ILandVehicle
{
    public double EngineVolume { get; set; }
    public double MaxPayload { get; set; }
    public string FuelBrand { get; set; }
    public string BodyType { get; set; }

    public PassengerCar(string manufacturer, double engineVolume, double maxPayload, string fuelBrand, string bodyType)
        : base(manufacturer)
    {
        EngineVolume = engineVolume;
        MaxPayload = maxPayload;
        FuelBrand = fuelBrand;
        BodyType = bodyType;
    }
}

// Грузовой автомобиль
public class Truck : Vehicle, ILandVehicle
{
    public double EngineVolume { get; set; }
    public double MaxPayload { get; set; }
    public string FuelBrand { get; set; }

    public Truck(string manufacturer, double engineVolume, double maxPayload, string fuelBrand)
        : base(manufacturer)
    {
        EngineVolume = engineVolume;
        MaxPayload = maxPayload;
        FuelBrand = fuelBrand;
    }
}

// Самолет
public class Airplane : Vehicle
{
    public double MaxAltitude { get; set; }
    public double RunwayLength { get; set; }

    public Airplane(string manufacturer, double maxAltitude, double runwayLength)
        : base(manufacturer)
    {
        MaxAltitude = maxAltitude;
        RunwayLength = runwayLength;
    }
}

// Мотоцикл
public class Motorcycle : Vehicle, ILandVehicle
{
    public double EngineVolume { get; set; }
    public bool HasSidecar { get; set; }
    

    public Motorcycle(string manufacturer, double engineVolume, bool hasSidecar)
        : base(manufacturer)
    {
        EngineVolume = engineVolume;
        HasSidecar = hasSidecar;
    }
}

// Катер
public class Boat : Vehicle
{
    public double EngineVolume { get; set; }
    public bool HasCabin { get; set; }

    public Boat(string manufacturer, double engineVolume, bool hasCabin)
        : base(manufacturer)
    {
        EngineVolume = engineVolume;
        HasCabin = hasCabin;
    }
}