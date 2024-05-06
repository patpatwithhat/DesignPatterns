using Factory.Entites;
using Factory.Enums;

namespace Factory.Factories
{
    public class VehicleFactory
    {
        public static Vehicle CreateVehicle(VehicleTypes type)
        {
            switch (type)
            {
                case VehicleTypes.Car:
                    return new Car();
                case VehicleTypes.Bike:
                    return new Bike();
                case VehicleTypes.Truck:
                    return new Truck();
                default:
                    throw new ArgumentException("Invalid vehicle type.");
            }
        }
    }
}
