namespace TransportDecarbonisation {
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
            get { return (float)(base.CarbonEmissionsPerMile * 0.3); } // 70% reduction from regular cars
            set { base.CarbonEmissionsPerMile = value; }
        }
    }
}