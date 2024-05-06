using Factory.Entites;
using Factory.Enums;
using Factory.Factories;

Vehicle myCar = VehicleFactory.CreateVehicle(VehicleTypes.Car);
myCar.Drive();

Vehicle myBike = VehicleFactory.CreateVehicle(VehicleTypes.Bike);
myBike.Drive();

Vehicle myTruck = VehicleFactory.CreateVehicle(VehicleTypes.Truck);
myTruck.Drive();