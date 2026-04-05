using SpacecraftApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacecraftApp
{
    internal class Rocket : Spacecraft
    {

        public Rocket(string name, double fuelLevel, double maxFuel) : base(name, fuelLevel, maxFuel)
        {

        }


        public override void Launch(string destination)
        {
            if (FuelLevel > 0.2)
            {
                Program.Log($"Launching the ship {Name} to the {destination}");

                //code of the launch, specific for rockets!!!

                //lets initialize a provisory variable 'amount'(of the fuel consumed, in litres), which we could get via calculating the distance between the 'destination' and current coordinates,
                //or with the trajectory, and we would include a different coefficient of fuel consuming in this case. Temporarily let it be equal to 6.7
                double amount = 6.7;

                ConsumeFuel(amount);

                
            }
            else
            {
                Program.Log("Can't launch the ship, since the fuel level is less than 20%");
            }
        }
    }
}
