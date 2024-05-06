# DesignPatterns

## Description
This repository contains a collection of implemented examples for various design patterns in C#, specifically tailored for software development needs. Each pattern is illustrated through practical exercises, demonstrating its application in realistic scenarios. The examples cover foundational patterns such as Singleton, Factory, Observer, and Builder, each designed to provide a clear understanding of how these patterns can be implemented in C# to solve common software design problems.

## Contents
**Singleton Pattern**: Ensures that a class has only one instance and provides a global point of access to it.

**Factory Pattern**: Demonstrates creating objects without specifying the exact class of object that will be created.

**Observer Pattern**: Allows a subject to notify an array of observers about changes without knowing who these observers are.

**Builder Pattern**: Separates the construction of a complex object from its representation, allowing the same construction process to create various representations.

## Tasks
**Singleton**: Develop an AppConfig class that uses the singleton design pattern. <br>
This class should serve as a central place to store and retrieve various configuration values.
* Use the implementation of the singleton pattern, which is thread-safe and enables efficient instantiation on first use.
* Add methods such as GetValue(string key) and SetValue(string key, string value) to the AppConfig class that allow configuration values to be read and written.
* Demonstrate in a small example how you can retrieve the AppConfig instance and set and retrieve configuration values to show that regardless of the number of instances that appear to be created, the same instance is always accessed.


**Factory**: Design a factory pattern for a vehicle management system that makes it possible to create different vehicle types such as Car, Bike and Truck. <br>
* Define an abstract class Vehicle with a method Drive().
* Create specific classes Car, Bike and Truck that inherit from Vehicle and implement the Drive() method.
* Implement a VehicleFactory class that controls the creation of vehicles based on a parameter (for example, an enum like Vehicles).

**Observer**: Implement the Observer pattern for a simple weather monitoring system.<br>
* Create an interface IObserver with a method Update().
* Define a WeatherStation class that manages the state of the weather (temperature, humidity) and notifies all registered observers (IObserver) in case of changes.
* Develop a concrete observer class WeatherDisplay that implements IObserver and displays the current weather on the console when there are changes.
* Add methods to WeatherStation to register and remove observers. 
* Demonstrate this functionality in a test example.

**Builder**: Develop a builder pattern for a computer system configurator tool. This tool should make it possible to assemble different types of computers, such as gaming PCs, office PCs and multimedia PCs.<br>
* Define a Computer class with properties such as processor, graphics card, memory and storage.
* Create an interface ComputerBuilder with methods such as SetProcessor(), SetGraphicsCard(), AddMemory() and SetStorage().
* Implement different builder classes such as GamingComputerBuilder, OfficeComputerBuilder and MultimediaComputerBuilder that offer specific configurations.
* Add a ComputerShop class that uses the builder to customize the computer.
* Demonstrate the use of the builder with an example of how a gaming PC is put together
