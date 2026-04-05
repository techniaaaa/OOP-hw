using SpacecraftApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacecraftApp
{

    internal class Shuttle : Spacecraft
    {
        public Shuttle(string name, double fuelLevel, double maxFuel) : base(name, fuelLevel, maxFuel)
        {

        }

        public override void Launch(string destination)
        {
            if (FuelLevel > 0.2)
            {
                Program.Log($"Launching the ship {Name} to the {destination}");


                //code of the launch, specific for !!!shuttles!!!
                double amount = 7.7;

                ConsumeFuel(amount);
            }
            else
            {
                Program.Log("Can't launch the ship, since the fuel level is less than 20%");
            }
        }
    }
}
