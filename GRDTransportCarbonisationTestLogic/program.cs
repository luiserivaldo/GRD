public class Vehicle {
    // Class properties
    public string VehicleSector { get; set; }
    public string VehicleName { get; set; }
    public int MilesTravelled { get; set; }
    public virtual float CarbonEmissionsPerMile { get; set; }

    // Vehicle Constructor
    public Vehicle(string vehicleSector, string vehicleName, int milesTravelled, float carbonEmissionsPerMile)
    {
        VehicleSector = vehicleSector;
        VehicleName = vehicleName;
        MilesTravelled = milesTravelled;
        CarbonEmissionsPerMile = carbonEmissionsPerMile;
    }
}

public class ElectricVehicle : Vehicle {
    // Use parent Vehicle class as constructor
    public ElectricVehicle(string vehicleSectorsector, string vehicleName, int milesTravelled, float carbonEmissionsPerMile)
        : base(vehicleSectorsector, vehicleName, milesTravelled, carbonEmissionsPerMile)
    {
    }

    // modify carbonEmissionsPerMile property to be 30% of the parent class value
    public override float CarbonEmissionsPerMile
    {
        get { return (float)(base.CarbonEmissionsPerMile * 0.3); }
        set { base.CarbonEmissionsPerMile = value; }
    }
}

class Program {
    static void Main () {
        // List of Vehicles as Objects
        Vehicle rail = new Vehicle("Public", "Rail", 720, 0.02f);
        Vehicle car = new Vehicle("Private", "Car", 5086, 0.291f);
        ElectricVehicle electricCar = new ElectricVehicle("Private", "Electric Car", 5086, 0.291f);
        Vehicle bus = new Vehicle("Public", "Bus", 385, 0.044f);
        ElectricVehicle electricBus = new ElectricVehicle("public", "EV Bus", 385, 0.044f);
        Vehicle bicycle = new Vehicle("Private", "Bicycle", 57, 0);
        Vehicle walking = new Vehicle("Private", "Walking", 87, 0);

        // Accessing the properties of "Car"
        Console.WriteLine("Car:");
        Console.WriteLine($"VehicleSector: {car.VehicleSector}");
        Console.WriteLine($"VehicleName: {car.VehicleName}");
        Console.WriteLine($"MilesTravelled: {car.MilesTravelled}");
        Console.WriteLine($"CarbonEmissionsPerMile: {car.CarbonEmissionsPerMile}");

        // Accessing the properties of "ElectricCar"
        Console.WriteLine("\nElectricCar:");
        Console.WriteLine($"VehicleSector: {electricCar.VehicleSector}");
        Console.WriteLine($"VehicleName: {electricCar.VehicleName}");
        Console.WriteLine($"MilesTravelled: {electricCar.MilesTravelled}");
        Console.WriteLine($"CarbonEmissionsPerMile: {electricCar.CarbonEmissionsPerMile}");
    }
}
