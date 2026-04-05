using System;
using System.Runtime.CompilerServices;

namespace SpacecraftApp
{
    internal abstract class Spacecraft : IFuelConsumer
    {

        private double _maxFuel;
        private double _fuelLevel; 
        public string Name { get; set; }


        public double MaxFuel
        {
            get => _maxFuel;
            set
            {
                if (value >= 0)
                {
                    _maxFuel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Max fuel volume can't be negative");
                }
            }
        }
        public double FuelLevel
        {
            get => _fuelLevel;

            set
            {
                if ((value >= 0) && (value <= 1))
                {
                    _fuelLevel = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Fuel level can't be negative or over 1");
                }
            }
        }


        public Mission CurrentMission { get; set; }

        public Spacecraft(string name, double fuelLevel, double maxFuel)
        {
            Name = name;
            FuelLevel = fuelLevel;
            MaxFuel = maxFuel;
            Program.Log($"New ship of type {this.GetType().Name} was created. Name: {Name}; current fuel level: {FuelLevel}; max fuel volume: {MaxFuel}");


        }

        public abstract void Launch(string destination);

        public virtual void Status()
        {
            Program.Log($"Name: {Name}, Fuel Level: {FuelLevel*100}%");
        }


        public void ConsumeFuel(double amount)
        {
            double currentFuel = FuelLevel * MaxFuel;
            double newFuel = currentFuel - amount;
            if (newFuel < 0) newFuel = 0;
            FuelLevel = newFuel / MaxFuel;
            Program.Log($"The ship {Name} consumed {amount} litres of fuel. Current fuel level: {FuelLevel*100}%");


        }

    }

}
