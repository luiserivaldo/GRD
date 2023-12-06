using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;
using System;

namespace TransportDecarbonisation {
    class Program {
        public int currentudget = 1000;
        public int yearlyBudget = 100; // Budget received per year
        public int bonusBudget = 300; // Budget received if milestone is achieved per year
        public int startingYear = 2021;
        public int majorMilestoneYear1 = 2030;
        public int majorMilestoneYear2 = 2050;

        static void Main () {
            // List of Vehicles as Objects
            Vehicle rail = new Vehicle("Public", "Rail", 720, 0.02f);
            Vehicle car = new Vehicle("Private", "Car", 5086, 0.291f);
            ElectricVehicle electricCar = new ElectricVehicle("Private", "Electric Car", 5086, 0.291f);
            Vehicle bus = new Vehicle("Public", "Bus", 385, 0.044f);
            ElectricVehicle electricBus = new ElectricVehicle("public", "EV Bus", 385, 0.044f);
            Vehicle bicycle = new Vehicle("Private", "Bicycle", 57, 0);
            Vehicle walking = new Vehicle("Private", "Walking", 87, 0);

            // [FOR TESTING] Output the contents of "Car"
            Console.WriteLine("Car:");
            Console.WriteLine($"VehicleSector: {car.VehicleSector}");
            Console.WriteLine($"VehicleName: {car.VehicleName}");
            Console.WriteLine($"MilesTravelled: {car.MilesTravelled}");
            Console.WriteLine($"CarbonEmissionsPerMile: {car.CarbonEmissionsPerMile}");

            // [FOR TESTING] Output the contents of "ElectricCar"
            Console.WriteLine("\nElectricCar:");
            Console.WriteLine($"VehicleSector: {electricCar.VehicleSector}");
            Console.WriteLine($"VehicleName: {electricCar.VehicleName}");
            Console.WriteLine($"MilesTravelled: {electricCar.MilesTravelled}");
            Console.WriteLine($"CarbonEmissionsPerMile: {electricCar.CarbonEmissionsPerMile}");
        }
    }
}
